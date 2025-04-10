using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class UpdateCustomer : Form
    {
        private MainScreen mainScreen;
        private int cust;
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public DateTime currentTime = DateTime.Now;
       
        public UpdateCustomer(int id, MainScreen mainScreen)
        {
            InitializeComponent();
            cust = id;
            this.mainScreen = mainScreen;
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

            IdTxtBox2.Text = cust.ToString();
            NameBox2.Text = GetName(cust);
            int custAddressID = Convert.ToInt32(GetAddressID(cust));
            Address address = GetAddressInfo(custAddressID);
            PhoneBox.Text = address.phone.ToString();
            AddressBox.Text = address.address.ToString();
            ZipBox.Text = address.postalCode.ToString();
            City custCity = GetCityInfo(address.cityId);
            CityBox.Text = custCity.CityName.ToString();
            Country custCountry = GetCountryInfo(custCity.CountryID);
            CountryBox.Text = custCountry.CountryName.ToString();
            NameBox2.Focus();
            NameBox2.SelectionStart = 0;
            NameBox2.SelectionLength = 0;

        }

        public string GetName(int customerID)
        {
            var custName = "";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string findName = "SELECT customerName FROM customer WHERE customerID = @cust";

                using (MySqlCommand getNameCmd = new MySqlCommand(findName, conn))
                {
                    getNameCmd.Parameters.AddWithValue("@cust", customerID);
                    custName = (string)getNameCmd.ExecuteScalar();
                }
                return custName;
            }
        }
        public int GetAddressID(int customerID)
        {
            var addressID = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string findAddressID = "SELECT addressID FROM customer WHERE customerID = @cust";

                using (MySqlCommand getAddressIdCmd = new MySqlCommand(findAddressID, conn))
                {
                    getAddressIdCmd.Parameters.AddWithValue("@cust", customerID);
                    addressID = (int)getAddressIdCmd.ExecuteScalar();
                }
                return addressID;
            }
        }
        public Address GetAddressInfo(int custAddressID)
        {
            var custAddress = new Address();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string findAddressInfo = "SELECT * FROM address WHERE addressID = @addressID";

                using (MySqlCommand getAddressInfoCmd = new MySqlCommand(findAddressInfo, conn))
                {
                    getAddressInfoCmd.Parameters.AddWithValue("@addressID", custAddressID.ToString());

                    using (MySqlDataReader read = getAddressInfoCmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            custAddress.addressId = Convert.ToInt32(read["addressID"]);
                            custAddress.postalCode = read["postalCode"].ToString();
                            custAddress.address = read["address"].ToString();
                            custAddress.phone = read["phone"].ToString();
                            custAddress.cityId = Convert.ToInt32(read["cityID"]);
                            custAddress.address2 = "";
                            custAddress.createBy = "test";
                        }
                        else
                        {
                            MessageBox.Show("error getting info");
                        }
                    }
                    return custAddress;

                }
            }
        }
        public City GetCityInfo(int cityId)
        {
            var custCity = new City();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string findCityInfo = "SELECT * FROM city WHERE cityID = @cityID";

                using (MySqlCommand getCityInfoCmd = new MySqlCommand(findCityInfo, conn))
                {
                    getCityInfoCmd.Parameters.AddWithValue("@cityID", cityId);

                    using (MySqlDataReader read = getCityInfoCmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            custCity.CityId = Convert.ToInt32(read["cityID"]);
                            custCity.CreatedBy = "test";
                            custCity.CityName = read["city"].ToString();
                            custCity.CountryID = Convert.ToInt32(read["countryID"]);
                        }
                        else
                        {
                            MessageBox.Show("Error getting customer city info");
                        }
                        return custCity;
                    }
                }
            }
        }
        public Country GetCountryInfo(int countryID)
        {
            var custCountry = new Country();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string findCountryInfo = "SELECT * FROM country WHERE countryID = @countryID";

                using (MySqlCommand getCountryInfoCmd = new MySqlCommand(findCountryInfo, conn))
                {
                    getCountryInfoCmd.Parameters.AddWithValue("@countryID", countryID);

                    using (MySqlDataReader read = getCountryInfoCmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            custCountry.CountryId = Convert.ToInt32(read["countryID"]);
                            custCountry.CreatedBy = "test";
                            custCountry.CountryName = read["country"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error getting countryInfo");
                        }
                        return custCountry;
                    }

                }

            }
        }

        public bool CheckBoxs()
        {
            string phonePattern = "^(\\d{3}[-]\\d{4})$";
            Regex phoneCheck = new Regex(phonePattern);

            string zipCodePtrn = @"^\d{5}$";
            Regex postalCheck = new Regex(zipCodePtrn);

            bool Info = true;

            if (string.IsNullOrEmpty(NameBox2.Text))
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
            else if (string.IsNullOrEmpty(ZipBox.Text))
            {
                MessageBox.Show("Please enter a valid postal code");
                Info = false;
                return Info;
            }
            else if (!postalCheck.IsMatch(ZipBox.Text))
            {
                MessageBox.Show("Please enter a valid postal code");
                Info = false;
                return Info;
            }

            return Info;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateCust(int customerId, string customerName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string updateCust = "UPDATE customer SET customerName = @customerName , lastUpdate = @lastUpdate WHERE customerID = @customerId";
                    using (MySqlCommand updateCustCmd = new MySqlCommand(updateCust, conn))
                    {
                        updateCustCmd.Parameters.AddWithValue("@customerName", NameBox2.Text);
                        updateCustCmd.Parameters.AddWithValue("@lastUpdate", currentTime);
                        updateCustCmd.Parameters.AddWithValue("@customerId", cust);

                        updateCustCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Customer");
            }
        }

        public void UpdateAddress(int addressID, string address, string phone, string postalCode)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string updateAddress = "UPDATE address SET address = @address, lastUpdate = @lastUpdate, phone = @phone, postalCode = @postalCode WHERE addressID = @addressId";

                    using (MySqlCommand updateAddressCmd = new MySqlCommand(updateAddress, conn))
                    {
                        updateAddressCmd.Parameters.AddWithValue("@address", AddressBox.Text);
                        updateAddressCmd.Parameters.AddWithValue("@lastUpdate", currentTime);
                        updateAddressCmd.Parameters.AddWithValue("@phone", PhoneBox.Text);
                        updateAddressCmd.Parameters.AddWithValue("@postalCode", ZipBox.Text);
                        updateAddressCmd.Parameters.AddWithValue("@addressId", addressID);

                        updateAddressCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Address");
            }
        }

        public void UpdateCity(int cityID, string city)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string updateCity = "UPDATE city SET city = @city, lastUpdate = @lastUpdate WHERE cityID = @cityId";

                    using (MySqlCommand updateCityCmd = new MySqlCommand(updateCity, conn))
                    {
                        updateCityCmd.Parameters.AddWithValue("@city", city);
                        updateCityCmd.Parameters.AddWithValue("@lastUpdate", currentTime);
                        updateCityCmd.Parameters.AddWithValue("@cityId", cityID);

                        updateCityCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating City");
            }
        }

        public void UpdateCountry(int countryID, string country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string updateCountry = "UPDATE country SET country = @country, lastUpdate = @lastUpdate WHERE countryID = @countryId";

                    using (MySqlCommand updateCountryCmd = new MySqlCommand(updateCountry, conn))
                    {
                        updateCountryCmd.Parameters.AddWithValue("@country", country);
                        updateCountryCmd.Parameters.AddWithValue("@lastUpdate", currentTime);
                        updateCountryCmd.Parameters.AddWithValue("@countryId", countryID);

                        updateCountryCmd.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Country");
            }
        }
        

        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Address address = GetAddressInfo(GetAddressID(cust));
            City custCity = GetCityInfo(address.cityId);
            string customerName = NameBox2.Text;
            string address1 = AddressBox.Text;
            string city = CityBox.Text; 
            string country = CountryBox.Text;
            string phone = PhoneBox.Text;
            string postalCode = ZipBox.Text;
            int cityID = custCity.CityId;
            int countryID = custCity.CountryID;



            if(! CheckBoxs()) return;
            UpdateCust(cust, customerName);
            UpdateAddress(Convert.ToInt32(GetAddressID(cust)), address1, phone, postalCode);
            UpdateCity(cityID,city);
            UpdateCountry(countryID, country);
            mainScreen.BindAptGrid();
            this.Close();
           


        }
    }
}
