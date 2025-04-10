using System;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Scheduler
{
    public partial class MainScreen : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public DateTime CurrrentDate = DateTime.Now;
        int userId = UserSession.userID;
        public MainScreen()
        {
            InitializeComponent();
        }

        public void BindAptGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentID, title, descriptions, typeApt, location, startApt, endApt, customerID, userID FROM appointment", conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.ClearSelection();
                        dataGridView1.Columns["appointmentID"].HeaderText = "Id";
                        dataGridView1.Columns["title"].HeaderText = "Title";
                        dataGridView1.Columns["descriptions"].HeaderText = "Description";
                        dataGridView1.Columns["typeApt"].HeaderText = "Type";
                        dataGridView1.Columns["location"].HeaderText = "Location";
                        dataGridView1.Columns["startApt"].HeaderText = "Start";
                        dataGridView1.Columns["endApt"].HeaderText = "End";
                        dataGridView1.Columns["customerID"].HeaderText = "Customer Id";
                        dataGridView1.Columns["userID"].HeaderText = "User Id";
                        dataGridView1.Refresh();
                    }
                }


                using (MySqlCommand cmd2 = new MySqlCommand("SELECT customer.customerID,  customer.customerName, address.phone, address.postalCode, address.address" +
                    " FROM customer JOIN address ON customer.addressID = address.addressID;", conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                    {
                        DataTable dt2 = new DataTable();
                        sda.Fill(dt2);
                        dataGridView2.DataSource = dt2;
                        dataGridView2.ClearSelection();

                        dataGridView2.Columns["customerID"].HeaderText = "Id";
                        dataGridView2.Columns["customerName"].HeaderText = "Name";
                        dataGridView2.Columns["phone"].HeaderText = "Phone";
                        dataGridView2.Columns["postalCode"].HeaderText = "Postal Code";
                        dataGridView2.Columns["address"].HeaderText = "Address";
                  
                        dataGridView2.Refresh();
                    }
                }
               
            }
        }
        public void CurrentMonthGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentID, title, descriptions, typeApt, location, startApt, endApt, customerID, userID " +
                    "FROM appointment WHERE startApt  >= @firstDay AND startApt <= @lastDay", conn))
                {
                    cmd.Parameters.AddWithValue("@firstDay", firstDay);
                    cmd.Parameters.AddWithValue("@lastDay", lastDay);

                 

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        dataGridView1.DataSource = null;
                       
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.ClearSelection();

                        dataGridView1.Columns["appointmentID"].HeaderText = "Id";
                        dataGridView1.Columns["title"].HeaderText = "Title";
                        dataGridView1.Columns["descriptions"].HeaderText = "Description";
                        dataGridView1.Columns["typeApt"].HeaderText = "Type";
                        dataGridView1.Columns["location"].HeaderText = "Location";
                        dataGridView1.Columns["startApt"].HeaderText = "Start";
                        dataGridView1.Columns["endApt"].HeaderText = "End";
                        dataGridView1.Columns["customerID"].HeaderText = "Customer Id";
                        dataGridView1.Columns["userID"].HeaderText = "User Id";
                        dataGridView1.Refresh();  
                        dataGridView1.Update();
                    }
                }
            }
        }
        public void CurrentWeekGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                DateTime today = DateTime.Today;
                int DaysToMonday = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime firstDay = today.AddDays(-DaysToMonday);
                DateTime lastDay = firstDay.AddDays(4);

                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentID, title, descriptions, typeApt, location, startApt, endApt, customerID, userID " +
                    "FROM appointment WHERE startApt  >= @firstDay AND startApt <= @lastDay", conn))
                {
                    cmd.Parameters.AddWithValue("@firstDay", firstDay);
                    cmd.Parameters.AddWithValue("@lastDay", lastDay);

                    cmd.ExecuteNonQuery();

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.ClearSelection();
                        dataGridView1.Columns["appointmentID"].HeaderText = "Id";
                        dataGridView1.Columns["title"].HeaderText = "Title";
                        dataGridView1.Columns["descriptions"].HeaderText = "Description";
                        dataGridView1.Columns["typeApt"].HeaderText = "Type";
                        dataGridView1.Columns["location"].HeaderText = "Location";
                        dataGridView1.Columns["startApt"].HeaderText = "Start";
                        dataGridView1.Columns["endApt"].HeaderText = "End";
                        dataGridView1.Columns["customerID"].HeaderText = "Customer Id";
                        dataGridView1.Columns["userID"].HeaderText = "User Id";
                        dataGridView1.Refresh();
                    }
                }
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            FilterBox.SelectedIndex = 0;
            if (FilterBox.SelectedIndex == 0)
            {
                this.BindAptGrid();
            }

            await Task.Delay(1000);
            alert(userId);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newLog = new Login();
            newLog.ShowDialog();
            this.Close();
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            Form AddApt = new AddAppointment(this);
            AddApt.ShowDialog();
        }

        private void UpdateBtn1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var selctedApt = dataGridView1.SelectedRows[0].Cells["appointmentID"].Value;
                if (selctedApt != null)
                {
                    Form UpdateApt = new ModifyApt(Convert.ToInt32(selctedApt), this);
                    UpdateApt.ShowDialog();
                    dataGridView1.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("You must select an appointment to update");
            }
        }

        private void AddBtn2_Click(object sender, EventArgs e)
        {
            Form newCust = new AddCustomer(this);
            newCust.ShowDialog();
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                var selctedCust = dataGridView2.SelectedRows[0].Cells["customerID"].Value;
                if (selctedCust != null)
                {
                    Form updCust = new UpdateCustomer(Convert.ToInt32(selctedCust), this);
                    updCust.ShowDialog();
                    dataGridView2.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Selected Row does not have a valid customer");
                }

            }
            else
            {
                MessageBox.Show("You must select a customer");
            }
        }

        private void DeleteBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this customer?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var customerID = dataGridView2.SelectedRows[0].Cells["customerID"].Value.ToString();
                        var deleteData = new DeleteCustomerInfo();

                        var addressId = deleteData.FindCustomer(customerID);

                        deleteData.DeleteCustomer(customerID);
                        deleteData.DeleteAddress(addressId);

                        MessageBox.Show("Customer deleted!");
                        this.BindAptGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting customer");
            }
        }

        private void DeleteBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0 )
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this appointment? ", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var aptID = dataGridView1.SelectedRows[0].Cells["appointmentID"].Value.ToString();
                        var deleteData = new DeleteApt();

                        deleteData.FindApt(aptID);

                        MessageBox.Show("Appointment deleted!");
                        this.BindAptGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an appointment to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deleting appointment");
            }

        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FilterBox.SelectedIndex == 0)
            {
                this.BindAptGrid();
            }
            else if(FilterBox.SelectedIndex == 1) 
            {
                this.CurrentMonthGrid();
            }
            else if (FilterBox.SelectedIndex == 2)
            {
                this.CurrentWeekGrid();
            }
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();

        }
    
       public void alert(int userId)
        {
            string query = "SELECT * FROM appointment WHERE userID= @userId AND startApt BETWEEN @now AND @later";
            DateTime now = DateTime.Now.ToLocalTime();
            DateTime later = now.AddMinutes(15).ToLocalTime();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@now", now);
                        command.Parameters.AddWithValue("@later", later);


                        using (MySqlDataReader read = command.ExecuteReader())
                        {

                            if (read.HasRows)
                            {
                                MessageBox.Show("You have an appointment in 15 minutes");
                            }
                            else
                            {
                                MessageBox.Show("No upcoming appointments ");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

