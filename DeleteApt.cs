using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Scheduler
{
    public class DeleteApt
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public void FindApt(string aptId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string GetApt = "DELETE FROM appointment WHERE appointmentID = @aptId";

                using (MySqlCommand GetAptCmd = new MySqlCommand(GetApt, conn))
                {
                    GetAptCmd.Parameters.AddWithValue("@aptId", aptId);
                    GetAptCmd.ExecuteNonQuery();
                }

            }
        }
    }
}
