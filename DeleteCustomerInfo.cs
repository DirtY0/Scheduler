using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class DeleteCustomerInfo
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
     
        public int FindCustomer(string customerId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string GetAddress = "SELECT addressID FROM customer WHERE customerID = @customerId";

                using (MySqlCommand GetAddressCmd = new MySqlCommand(GetAddress, conn))
                {
                    GetAddressCmd.Parameters.AddWithValue("@customerId", customerId);
                    var addressID = GetAddressCmd.ExecuteScalar();
                    return Convert.ToInt32(addressID);
                }
               

            }
        }
        public void DeleteAddress(int addressID)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string DeleteAddress = "DELETE FROM address WHERE addressID  = @addressId";

                using (MySqlCommand DeleteAddressCmd = new MySqlCommand(DeleteAddress, conn))
                {
                    DeleteAddressCmd.Parameters.AddWithValue("@addressId", addressID);
                    DeleteAddressCmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCustomer(string customerId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string DeleteCustomer = "DELETE FROM customer WHERE customerID = @customerID";

                using (MySqlCommand DeleteCustomerCmd = new MySqlCommand(DeleteCustomer, conn))
                {
                    DeleteCustomerCmd.Parameters.AddWithValue("@customerID", customerId);
                    DeleteCustomerCmd.ExecuteNonQuery();
                }

            }


        }

    }
}

