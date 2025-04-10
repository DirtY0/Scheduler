using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Scheduler
{
    public partial class AddAppointment : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
     
        readonly DateTime currentDate = DateTime.Now;
        int userId = UserSession.userID;
        MainScreen mainScreen;
        public AddAppointment(MainScreen mainScreen)
        {
            InitializeComponent();

            this.mainScreen = mainScreen;
            DateTime currentDate = DateTime.Now;
            Customer cust = new Customer();
            StartTimeBox.Format = DateTimePickerFormat.Time;

            foreach (string name in cust.GetNames())
            {
                ContactBox.Items.Add(name);
            }
            ContactBox.SelectedIndex = 0;
            LocationBox.SelectedIndex = 0;

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
        }
        public bool CheckBoxs()
        {
            bool Info = true;

            if (string.IsNullOrEmpty(TitleBox.Text))
            {
                MessageBox.Show("Please enter a title");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(TypeBox.Text))
            {
                MessageBox.Show("Please enter a appointment type");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(DescriptionBox.Text))
            {
                MessageBox.Show("Please enter a description");
                Info = false;
                return Info;
            }
          
            else if (string.IsNullOrEmpty(StartDatePicker.Text))
            {
                MessageBox.Show("Please select a start date");
                Info = false;
                return Info;
            }
            else if (StartDatePicker.Value.Date < currentDate.Date)
            {
                MessageBox.Show("Start date cannot be before the current date");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(StartTimeBox.Text))
            {
                MessageBox.Show("Please select a time");
                Info = false;
                return Info;
            }

            else if (StartTimeBox.Value.Hour < 8 || StartTimeBox.Value.Hour >= 17)
            {
                MessageBox.Show("Please select a time within bussiness hours 8am-5pm");
                Info = false;
                return Info;
            }
            else if (StartDatePicker.Value.DayOfWeek == DayOfWeek.Saturday || StartDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) 
                {
                MessageBox.Show("Please select a day between Mon - Fri ");
                Info = false;
                return Info;
               }


            else if (string.IsNullOrEmpty(ContactBox.Text))
            {
                MessageBox.Show("Please Select your name");
                Info = false;
                return Info;
            }

            return Info;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int GetCustomerId(string customerName)
        {
            int customerID;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string GetIDQuery = "SELECT customerID FROM customer WHERE customerName = @CustomerName";

                using (MySqlCommand GetIDCmd = new MySqlCommand(GetIDQuery, conn))
                {
                    GetIDCmd.Parameters.AddWithValue("@customerName",customerName);
                    customerID = Convert.ToInt32(GetIDCmd.ExecuteScalar());
                }

                return customerID;
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!CheckBoxs()) { return; }
            // add apt info

            DateTime startUtc = StartDatePicker.Value.ToUniversalTime().Date;
            TimeSpan startTimeUtc = StartTimeBox.Value.ToUniversalTime().TimeOfDay;
            DateTime Start = startUtc.Add(startTimeUtc);
            DateTime End = Start.AddMinutes(30);



            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                try
                {
                    string FindApt = "SELECT * FROM appointment WHERE userID = @userId AND startApt <=  @end AND endApt >= @start";

                    using (MySqlCommand FindAptCmd = new MySqlCommand(FindApt, conn))
                    {
                        FindAptCmd.Parameters.AddWithValue("@userId", userId);
                        FindAptCmd.Parameters.AddWithValue("@end", End);
                        FindAptCmd.Parameters.AddWithValue("@Start", Start);

                        int scheduledApt = Convert.ToInt32(FindAptCmd.ExecuteScalar());

                        if (scheduledApt > 0)
                        {
                            MessageBox.Show("Cannot schedule overlapping appointments");
                        }
                        else
                        {
                            string insertApt = "INSERT INTO appointment (customerID,userID,title,descriptions,location,contact,typeApt,url,startApt,endApt,createdBy,createDate,lastUpdate,lastUpdateBy)" +
                            "VALUES" +
                            "(@customerID,@userID,@title,@descriptions,@location,@contact,@type,@url,@startDate,@endDate,@createdBy,@createDate,@lastUpdate,@lastUpdateBy)";

                            using (MySqlCommand addAptCmd = new MySqlCommand(insertApt, conn))
                            {
                                addAptCmd.Parameters.AddWithValue("@customerID", GetCustomerId(ContactBox.Text));
                                addAptCmd.Parameters.AddWithValue("@userID", userId);
                                addAptCmd.Parameters.AddWithValue("@title", TitleBox.Text);
                                addAptCmd.Parameters.AddWithValue("@descriptions", DescriptionBox.Text);
                                addAptCmd.Parameters.AddWithValue("@location", LocationBox.Text);
                                addAptCmd.Parameters.AddWithValue("@contact", ContactBox.Text);
                                addAptCmd.Parameters.AddWithValue("@type", TypeBox.Text);
                                addAptCmd.Parameters.AddWithValue("@url", "N/A");
                                addAptCmd.Parameters.AddWithValue("@startDate", DateTime.Parse(Start.ToString()));
                                addAptCmd.Parameters.AddWithValue("@endDate", DateTime.Parse(End.ToString()));
                                addAptCmd.Parameters.AddWithValue("@createdBy", "test");
                                addAptCmd.Parameters.AddWithValue(@"createDate", currentDate);
                                addAptCmd.Parameters.AddWithValue("@lastUpdate", currentDate);
                                addAptCmd.Parameters.AddWithValue("@lastUpdateBy", "test");

                                addAptCmd.ExecuteNonQuery();

                                mainScreen.BindAptGrid();
                                this.Close();
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Problem adding Appointment" + ex);
                }
            }
        }
        private void StartTimeBox_ValueChanged(object sender, EventArgs e)
        {
            DateTime RoundTime = StartTimeBox.Value;

            // Round minutes to the nearest 30-minute increment
            int roundedMinutes = (RoundTime.Minute < 30) ? 0 : 30;
            StartTimeBox.Value = new DateTime(RoundTime.Year, RoundTime.Month, RoundTime.Day,  RoundTime.Hour, roundedMinutes, 0);
        }
        private void AptLbl_Click(object sender, EventArgs e)
        {

        }
    }
  }

