using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using Scheduler;
using System.Web.UI.WebControls;
using System.Threading;
using System.IO;

namespace Scheduler
{
    public partial class Login : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        int userId = UserSession.userID;
        public Login()
        {
            InitializeComponent();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            string userName = UserTxtBox.Text;
            string password = PasswordTxtBox.Text;

            if (userName.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (CheckUser(userName, password))
            {
                this.Hide();
                Form mainScreen = new MainScreen();
                mainScreen.ShowDialog();
                this.Close();
            }
        }

        private bool CheckUser(string userName, string password)
        {
            string query = "SELECT * FROM user WHERE userName=@userName AND password=@password";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        MySqlDataReader read = command.ExecuteReader();

                        if (!read.Read())
                        {
                            string language = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
                            string errorMessage = language == "es"
                                ? "Nombre de usuario o contraseña incorrectos."
                                : "Username or password is incorrect.";

                            MessageBox.Show(errorMessage);
                        }
                        else
                        {
                            int userId = read.GetInt32("userID");
                            UserSession.SetUser(userId);
                            LogFile(userName);
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TimeZoneInfo timeZ = TimeZoneInfo.Local;
            RegionInfo region = new RegionInfo(CultureInfo.CurrentCulture.Name);
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            string localTime = timeZ.StandardName;

            if (lang == "es")
            {
                if (timeZ.StandardName == "Pacific Standard Time")
                    localTime = "Hora estándar del Pacífico";
                else if (timeZ.StandardName == "Eastern Standard Time")
                    localTime = "Hora estándar del Este";
                else if (timeZ.StandardName == "Central Standard Time")
                    localTime = "Hora estándar Central";
                else if (timeZ.StandardName == "Mountain Standard Time")
                    localTime = "Hora estándar de la Montaña";
            }

            string regions;
            switch (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName)
            {
                case "es":
                    regions = $"Región: {region.NativeName}";
                    break;

                default:
                    regions = $"Region: {region.EnglishName}";
                    break;
            }
            TimeLbl.Text = $"{localTime}\n{regions}";

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();
            Login_Load(this, null);
        }

        private void LogFile(string userName)
        {
            string logFilePath = "Log_History.txt";
            string logTime = DateTime.Now.ToString();
            string logEntry = $"[{logTime} login successful - User: {userName}";

            try
            {
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Failed to write login history: {ex.Message}");
            }
        }

    }
}

        public static class UserSession
        {
            public static int userID { get; private set; }
            public static void SetUser(int id)
            {
                userID = id;
            }
        }
      



