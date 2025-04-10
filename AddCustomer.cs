using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Scheduler
{
    
    public partial class AddCustomer : Form
    {
        private MainScreen mainScreen;
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
       
        readonly DateTime currentDate = DateTime.Now;
        int countryID;
        int cityID;
        int addressID;
        int customerID;
        public AddCustomer(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
          
        }

        public bool CheckBoxs ()
        {
            string phonePattern = "^(\\d{3}[-]\\d{4})$";
            Regex phoneCheck = new Regex(phonePattern);

            string zipCodePtrn = @"^\d{5}$";
            Regex postalCheck = new Regex(zipCodePtrn);

            bool Info = true;

            if (string.IsNullOrEmpty(NameBox.Text))
            {
                MessageBox.Show("Please enter a name");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(AddressBox.Text))
            {
                MessageBox.Show("Please enter a valid address");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(PhoneBox.Text))
            {
                MessageBox.Show("Please enter a valid phone number");
                Info = false;
                return Info;
            }
            else if (!phoneCheck.IsMatch(PhoneBox.Text))
            {
                MessageBox.Show("Please enter a valid phone number in the xxx-xxxx format");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(CountryBox.Text))
            {
                MessageBox.Show("Please enter a country");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(CityBox.Text))
            {
                MessageBox.Show("Please enter a city");
                Info = false;
                return Info;
            }
            else if (string.IsNullOrEmpty(ZIpBox.Text))
            {
                MessageBox.Show("Please enter a valid postal code");
                Info = false;
                return Info;
            }
            else if (!postalCheck.IsMatch(ZIpBox.Text))
            {
                MessageBox.Show("Please enter a valid postal code");
                Info = false;
                return Info;
            }

           return Info;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
        
     
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // insert data following the sql ERD diagram country,city,address //
            // using a transaction  so if any insertion fails thier wont be any half entries into the database// 
            // using a diffrent function for each step of the data transaction// 

            if (CheckBoxs())
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    using (MySqlTransaction tran = conn.BeginTransaction())

                    {
                        try
                        {
                            DateTime currentDate = DateTime.Now;
                            int countryID = GetOrInsertCountry( conn, tran);
                            int cityID = GetOrInsertCity(countryID, conn, tran);
                            int addressID = GetOrInsertAddress(cityID, conn, tran);
                            int customerID = GetOrInsertCustomer(addressID, conn, tran);

                            tran.Commit();
                            MessageBox.Show("Success!");
                            mainScreen.BindAptGrid();
                            this.Close();
                            
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Data transaction Failed" + ex.Message);
                        }
                    }
                }
            }
        }
        private int GetOrInsertCountry (MySqlConnection conn, MySqlTransaction tran)
        {
            string getCountryQuery = "SELECT countryID FROM country WHERE country = @country";

            using (MySqlCommand getCountryCmd = new MySqlCommand(getCountryQuery, conn, tran))
            {
                getCountryCmd.Parameters.AddWithValue("@country", CountryBox.Text);

                var findCountry = getCountryCmd.ExecuteScalar();

                if (findCountry != null)
                {
                    countryID = Convert.ToInt32(findCountry);
                    return countryID;
                }
                else
                {
                    string insertCountry = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                                             "VALUES" +
                                                             "(@country, @createDate, @createdBy,@lastUpdate,@lastUpdateBy);" +
                                                             "SELECT LAST_INSERT_ID();";

                    MySqlCommand insertCountryCmd = new MySqlCommand(insertCountry, conn, tran);



                    insertCountryCmd.Parameters.AddWithValue("@country", CountryBox.Text);
                    insertCountryCmd.Parameters.AddWithValue("@createDate", currentDate);
                    insertCountryCmd.Parameters.AddWithValue("@createdBy", "test");
                    insertCountryCmd.Parameters.AddWithValue("@lastUpdate", currentDate);
                    insertCountryCmd.Parameters.AddWithValue("@lastUpdateBy", "test");

                    countryID = Convert.ToInt32(insertCountryCmd.ExecuteScalar());

                    MessageBox.Show("Country added");
                    return countryID;

                }
            }

        }
        private int GetOrInsertCity( int countryID, MySqlConnection conn, MySqlTransaction tran) 
        {

            string getCityQuery = "SELECT cityID FROM city WHERE countryID = @countryID AND city = @city";

            using (MySqlCommand getCityCmd = new MySqlCommand(getCityQuery, conn, tran))
            {
                getCityCmd.Parameters.AddWithValue("@countryID", countryID);
                getCityCmd.Parameters.AddWithValue("@city", CityBox.Text);

                var findCity = getCityCmd.ExecuteScalar();

                if (findCity != null)
                {
                    cityID = Convert.ToInt32(findCity);
                    return cityID;
                }
                else
                {
                    string insertCity = "INSERT INTO city (city, countryID, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                                             "VALUES" +
                                                             "(@city,@countryID,@createDate,@createdBy,@lastUpdate,@lastUpdateBy);" +
                                                             "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand insertCityCmd = new MySqlCommand(insertCity, conn, tran))
                    {

                        insertCityCmd.Parameters.AddWithValue("@city", CityBox.Text);
                        insertCityCmd.Parameters.AddWithValue("@countryID", countryID);
                        insertCityCmd.Parameters.AddWithValue("@createDate", currentDate);
                        insertCityCmd.Parameters.AddWithValue("@createdBy", "test");
                        insertCityCmd.Parameters.AddWithValue("@lastUpdate", currentDate);
                        insertCityCmd.Parameters.AddWithValue("@lastUpdateBy", "test");

                        cityID = Convert.ToInt32(insertCityCmd.ExecuteScalar());
                        MessageBox.Show("city with " + cityID + " added");
                        return cityID;

                    }
                }
            }
          }
        private int GetOrInsertAddress( int cityID, MySqlConnection conn, MySqlTransaction tran) 
        {
            string getAddress = "SELECT addressID FROM address WHERE cityID = @cityID AND address = @address";

            using (MySqlCommand getAddressCmd = new MySqlCommand(getAddress, conn, tran))
            {
                getAddressCmd.Parameters.AddWithValue("@cityID", cityID);
                getAddressCmd.Parameters.AddWithValue("@address", AddressBox.Text);

                var findAddress = getAddressCmd.ExecuteScalar();

                if (findAddress != null)
                {
                    addressID = Convert.ToInt32(findAddress);
                    return addressID;
                }
                else
                {
                    string insertAddress = "INSERT INTO address (address, cityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                             "VALUES" +
                             "(@address,@cityID,@postalCode,@phone,@createDate,@createdBy,@lastUpdate,@lastUpdateBy);" +
                             "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand insertAddressCmd = new MySqlCommand(insertAddress, conn, tran))
                    {

                        insertAddressCmd.Parameters.AddWithValue("@address", AddressBox.Text);
                        insertAddressCmd.Parameters.AddWithValue("@cityID", cityID);
                        insertAddressCmd.Parameters.AddWithValue("@postalCode", ZIpBox.Text);
                        insertAddressCmd.Parameters.AddWithValue("@phone", PhoneBox.Text);
                        insertAddressCmd.Parameters.AddWithValue("@createDate", currentDate);
                        insertAddressCmd.Parameters.AddWithValue("@createdBy", "test");
                        insertAddressCmd.Parameters.AddWithValue("@lastUpdate", currentDate);
                        insertAddressCmd.Parameters.AddWithValue("@lastUpdateBy", "test");

                        addressID = Convert.ToInt32(insertAddressCmd.ExecuteScalar());
                        MessageBox.Show("Address with " + addressID + " added");
                        return addressID;

                    }
                }
            }

        }
        private int GetOrInsertCustomer( int addressID, MySqlConnection conn, MySqlTransaction tran)
        {
            string getCustomer = "SELECT customerID FROM customer WHERE addressID = @addressID AND customerName = @customerName";

            using (MySqlCommand getCustomerCmd = new MySqlCommand(getCustomer, conn, tran))
            {
                getCustomerCmd.Parameters.AddWithValue("@addressID", addressID);
                getCustomerCmd.Parameters.AddWithValue("@customerName", NameBox.Text);

                var findCustomer = getCustomerCmd.ExecuteScalar();

                if (findCustomer != null)
                {
                    customerID = Convert.ToInt32(findCustomer);
                    return customerID;
                }
                else
                {
                    string query = "INSERT INTO customer (customerName, addressID, actives, createdBy, createDate, lastUpdate, lastUpdateBy )" +
                                             " VALUES" +
                                             " (@CustomerName,@addressID,@Active,@createdBy,@createDate,@lastUpdate,@lastUpdateBy) ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Active", 1);
                        cmd.Parameters.AddWithValue("@createdBy","test");
                        cmd.Parameters.AddWithValue("@addressId", addressID);
                        cmd.Parameters.AddWithValue("@createDate", currentDate);
                        cmd.Parameters.AddWithValue("@lastUpdate", currentDate);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", "test");

                        int Affected = cmd.ExecuteNonQuery();

                        if (Affected > 0)
                        {
                            MessageBox.Show("Customer added");
                        }
                        this.Close();
                        return customerID;
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
