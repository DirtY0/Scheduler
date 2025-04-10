using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Scheduler
{
    public partial class ModifyApt : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        MainScreen mainScreen;
        private int aptId;
        public DateTime currentDate = DateTime.Now;
        public ModifyApt(int aptID, MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            aptId = aptID;

        }


        private void ModifyApt_Load(object sender, EventArgs e)
        {
            Appointment app = GetAptInfo(aptId);
            ContactBox1.Text = GetCustomerName(aptId);
            IdTxtBox.Text = aptId.ToString();
            TitleBox1.Text = app.Title;
            TypeBox1.Text = app.Type;
            DescriptionBox1.Text = app.Description;
            LocationBox1.Text = app.Location;
            StartDatePicker1.Format = DateTimePickerFormat.Custom;
            StartDatePicker1.CustomFormat = "yyyy-MM-dd";
            StartTimeBox1.Format = DateTimePickerFormat.Time;
            StartTimeBox1.ShowUpDown = true;

        }

        public Appointment GetAptInfo(int aptId)
        {
            Appointment appointment = new Appointment();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string GetApt = "SELECT * FROM appointment WHERE appointmentID = @aptId";

                using (MySqlCommand GetAptCmd = new MySqlCommand(GetApt, conn))
                {
                    GetAptCmd.Parameters.AddWithValue("@aptId", aptId);

                    using (MySqlDataReader read = GetAptCmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            appointment.Title = read["title"].ToString();
                            appointment.CreatedBy = "test";
                            appointment.Description = read["descriptions"].ToString();
                            appointment.Location = read["location"].ToString();
                            appointment.UserId = Convert.ToInt32(read["userID"].ToString());
                            appointment.Contact = read["contact"].ToString();
                            appointment.Type = read["typeApt"].ToString();
                            appointment.Start = Convert.ToDateTime(read["startApt"]);
                            appointment.End = Convert.ToDateTime(read["endApt"]);
                            appointment.Url = "N/A";
                            appointment.CustomerId = Convert.ToInt32(read["customerID"]);
                            appointment.AppointmentId = Convert.ToInt32(read["appointmentID"]);
                            StartDatePicker1.Value = appointment.Start.Date;
                            StartTimeBox1.Value = DateTime.Today.Add(appointment.Start.TimeOfDay);
                        }
                        else
                        {
                            MessageBox.Show("Error getting appointment info");
                        }
                        return appointment;
                    }
                }

            }
        }

        public string GetCustomerName(int aptId)
        {
            string customerName;
            int customerId;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string GetCustomerID = "SELECT customerID FROM appointment WHERE appointmentID = @aptId";

                using (MySqlCommand GetCustomerIDCmd = new MySqlCommand(GetCustomerID, conn))
                {
                    GetCustomerIDCmd.Parameters.AddWithValue("@aptId", aptId);
                    customerId = Convert.ToInt32(GetCustomerIDCmd.ExecuteScalar());
                }
                string GetCustomerName = "SELECT customerName FROM customer WHERE customerID = @customerID";

                using (MySqlCommand GetCustomerNameCmd = new MySqlCommand(GetCustomerName, conn))
                {
                    GetCustomerNameCmd.Parameters.AddWithValue("@customerID", customerId);
                    customerName = GetCustomerNameCmd.ExecuteScalar().ToString();
                }

            }
            return customerName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckBoxs()) { return; }

            else
            {
                try
                {

                    DateTime startUtc = StartDatePicker1.Value.ToUniversalTime().Date;
                    TimeSpan startTimeUtc = StartTimeBox1.Value.ToUniversalTime().TimeOfDay;
                    DateTime Start = startUtc.Add(startTimeUtc);
                    DateTime End = Start.AddMinutes(30);

                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        {
                            string FindUserId = "SELECT userID FROM appointment WHERE appointmentID = @aptId";
                            int userId;

                            using (MySqlCommand FindUserIdCmd = new MySqlCommand(FindUserId, conn))
                            {
                                FindUserIdCmd.Parameters.AddWithValue("@aptId", aptId);

                                userId = Convert.ToInt32(FindUserIdCmd.ExecuteScalar());
                            }
                            string FindApt = "SELECT * FROM appointment WHERE userID = @userId AND startApt <=  @end AND endApt >= @start";

                            using (MySqlCommand FindAptCmd = new MySqlCommand(FindApt, conn))
                            {
                                FindAptCmd.Parameters.AddWithValue("@userId", userId);
                                FindAptCmd.Parameters.AddWithValue("@end", End);
                                FindAptCmd.Parameters.AddWithValue("@start", Start);

                                int scheduledApt = Convert.ToInt32(FindAptCmd.ExecuteScalar());

                                if (scheduledApt > 0)
                                {
                                    MessageBox.Show("Cannot schedule overlapping appointments");
                                }
                                else
                                {

                                    string updateApt = "Update appointment SET title = @title, typeApt = @type, descriptions = @description, location = @location, startApt = @Start," +
                                                                "endApt = @End, lastUpdate = @lastUpdate WHERE appointmentID = @aptId";

                                    using (MySqlCommand UpdateAptCmd = new MySqlCommand(updateApt, conn))
                                    {
                                        UpdateAptCmd.Parameters.AddWithValue("@title", TitleBox1.Text);
                                        UpdateAptCmd.Parameters.AddWithValue("@type", TypeBox1.Text);
                                        UpdateAptCmd.Parameters.AddWithValue("@description", DescriptionBox1.Text);
                                        UpdateAptCmd.Parameters.AddWithValue("@location", LocationBox1.Text);
                                        UpdateAptCmd.Parameters.AddWithValue("@Start", Start.ToLocalTime());
                                        UpdateAptCmd.Parameters.AddWithValue("@End", End.ToLocalTime());
                                        UpdateAptCmd.Parameters.AddWithValue("@lastUpdate", currentDate);
                                        UpdateAptCmd.Parameters.AddWithValue("@aptId", aptId);

                                        UpdateAptCmd.ExecuteNonQuery();
                                        MessageBox.Show("Appointment updated!");

                                        mainScreen.BindAptGrid();
                                        this.Close();
                                    }
                                }

                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating appointment " + ex.Message);
                }
            }
        }

        public bool CheckBoxs()
        {
            bool Info = true;

            if (string.IsNullOrEmpty(TitleBox1.Text))
            {
                MessageBox.Show("Please enter a title");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(TypeBox1.Text))
            {
                MessageBox.Show("Please enter a appointment type");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(DescriptionBox1.Text))
            {
                MessageBox.Show("Please enter a description");
                Info = false;
                return Info;
            }

            else if (string.IsNullOrEmpty(StartDatePicker1.Text))
            {
                MessageBox.Show("Please select a start date");
                Info = false;
                return Info;
            }
            else if (StartDatePicker1.Value.Date < currentDate.Date)
            {
                MessageBox.Show("Start date cannot be before the current date");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(StartTimeBox1.Text))
            {
                MessageBox.Show("Please select a time");
                Info = false;
                return Info;
            }

            else if (StartDatePicker1.Value.DayOfWeek == DayOfWeek.Saturday || StartDatePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Please select a day between Mon - Fri ");
                Info = false;
                return Info;
            }

            else if (StartTimeBox1.Value.Hour < 8 || StartTimeBox1.Value.Hour >= 17)
            {
                MessageBox.Show("Please select a time within bussiness hours 8am-5pm");
                Info = false;
                return Info;
            }


            else if (string.IsNullOrEmpty(ContactBox1.Text))
            {
                MessageBox.Show("Please Select your name");
                Info = false;
                return Info;
            }

            return Info;
        }

        private void StartTimeBox1_ValueChanged(object sender, EventArgs e)
        {

            DateTime RoundTime = StartTimeBox1.Value;
            // Round minutes to the nearest 30-minute increment
            int roundedMinutes = (RoundTime.Minute < 30) ? 0 : 30;
            StartTimeBox1.Value = new DateTime(RoundTime.Year, RoundTime.Month, RoundTime.Day, RoundTime.Hour, roundedMinutes, 0);
        }
    }
}

