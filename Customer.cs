using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Scheduler
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }

        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        BindingList<string> CustNames = new BindingList<string>();


        public BindingList<string> GetNames()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string nameQuery = "SELECT customerName FROM customer";

                using(MySqlCommand GetNameCmd = new MySqlCommand(nameQuery, conn))
                {
                    MySqlDataReader read = GetNameCmd.ExecuteReader();

                    while (read.Read())
                    {
                        CustNames.Add(read.GetString("customerName"));
                    }

                }
                return CustNames;
            }

        }


    }
}
