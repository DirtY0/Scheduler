using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Scheduler
{
    public partial class Reports : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public Reports()
        {
            InitializeComponent();
            Customer cust = new Customer();
         
            foreach (string name in cust.GetNames())
            {
                ContactBox.Items.Add(name);
            }
            ContactBox.SelectedIndex = 0;
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            ContactBox.SelectedIndex = 0;
            AptInfoGrid.ClearSelection();
            MonthBox.SelectedIndex = DateTime.Now.Month;

            FillGrid2(MonthBox.SelectedIndex);
            FillGrid3();


        }
        public int GetCustomerId()
        {


            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string FindCustomer = "SELECT customerID FROM customer WHERE customerName = @customerName";

                using (MySqlCommand FindCustomerCmd = new MySqlCommand(FindCustomer, conn))
                {
                    FindCustomerCmd.Parameters.AddWithValue("@customerName", ContactBox.Text);
                    int customerID = Convert.ToInt32(FindCustomerCmd.ExecuteScalar());

                    return customerID;
                }
            }
        }
        public async void FillGrid1()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentID, title, descriptions, typeApt, location, startApt, endApt, customerID, userID FROM appointment WHERE customerID = @customerID", conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", GetCustomerId());
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                       
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        AptInfoGrid.DataSource = dt;
                        AptInfoGrid.ClearSelection();
                   
                        AptInfoGrid.Columns["appointmentID"].HeaderText = "Id";
                        AptInfoGrid.Columns["title"].HeaderText = "Title";
                        AptInfoGrid.Columns["descriptions"].HeaderText = "Description";
                        AptInfoGrid.Columns["typeApt"].HeaderText = "Type";
                        AptInfoGrid.Columns["location"].HeaderText = "Location";
                        AptInfoGrid.Columns["startApt"].HeaderText = "Start";
                        AptInfoGrid.Columns["endApt"].HeaderText = "End";
                        AptInfoGrid.Columns["customerID"].HeaderText = "Customer Id";
                        AptInfoGrid.Columns["userID"].HeaderText = "User Id";
                        AptInfoGrid.Refresh();
                        AptInfoGrid.ClearSelection();
                        // Lamda function that will alert the user of an emergency appointment that might need to be rushed. 
                        await Task.Delay(1000);
                        var aptType = dt.AsEnumerable().Select(row => row.Field<string>("typeApt")).FirstOrDefault();
                        if(aptType == "Emergency")
                        {
                            MessageBox.Show("Emergency Appointment!");
                        }
                        AptInfoGrid.ClearSelection();
                    }
                }
            }
        }

        private void ContactBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AptInfoGrid.ClearSelection();
            FillGrid1();
            AptInfoGrid.ClearSelection();

        }

        public void FillGrid2(int Month)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                int year = DateTime.Now.Year;

                DateTime firstDay = new DateTime(year, Month, 1);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);
                DataTable dt = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("SELECT a.appointmentID, a.typeApt, grouped.TotalAppointments " +
                "FROM appointment a  JOIN (SELECT typeApt, COUNT(*) AS TotalAppointments  FROM appointment " +
                "WHERE startApt >= @firstDay AND startApt <= @lastDay GROUP BY typeApt) AS grouped ON a.typeApt = grouped.typeApt " +
                 "WHERE a.startApt >= @firstDay AND a.startApt <= @lastDay", conn))
                {
                    cmd.Parameters.AddWithValue("@firstDay", firstDay);
                    cmd.Parameters.AddWithValue("@lastDay", lastDay);

                    cmd.ExecuteNonQuery();

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        AptFilterGrid.DataSource = null;
                        AptFilterGrid.Refresh();
                        sda.Fill(dt);
                        AptFilterGrid.DataSource = dt;
                        AptFilterGrid.ClearSelection();

                        AptFilterGrid.Columns["appointmentID"].HeaderText = "ID";
                        AptFilterGrid.Columns["typeApt"].HeaderText = "Type";
                        AptFilterGrid.Columns["TotalAppointments"].HeaderText = "Total Appointments";
                        AptFilterGrid.Refresh();

                        // lamda to alert user if there are no appointments for the month

                        var aptType = dt.AsEnumerable().Select(row => row.Field<string>("typeApt")).FirstOrDefault();
                        if (aptType == null)
                        {
                            MessageBox.Show("No appointmets this month!");
                        }



                    }
                }
            }
        }

        public void FillGrid3()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT  location, COUNT(*) AS Total_Appointments FROM appointment WHERE location = @location1 OR location = @location2 GROUP BY location", conn))
                {
                    {
                        cmd.Parameters.AddWithValue("@location1", "Midtown");
                        cmd.Parameters.AddWithValue("@location2","Downtown");

                    }
                   
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        
                        //lamda to sort the total appointment field so that the user can see with location is getting the most appointmets. 

                        var mostApt = dt.AsEnumerable().OrderByDescending(row => row.Field<Int64>("Total_Appointments")).CopyToDataTable();
                        LocationFilterGrid.DataSource = mostApt;
                       
                        LocationFilterGrid.Refresh();
                        LocationFilterGrid.ClearSelection();

                        LocationFilterGrid.Columns["location"].HeaderText = "Location";
                        LocationFilterGrid.Columns["Total_Appointments"].HeaderText = "Total Appointments";
                        LocationFilterGrid.Refresh();

                     
                    }
                }
            }
        }
        
        

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonthBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid month");
            }
            else
            {
                FillGrid2(MonthBox.SelectedIndex);
            }
        }
    }
}

