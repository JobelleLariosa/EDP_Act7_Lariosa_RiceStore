using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Lariosa_RiceStore
{
    public partial class LogIn : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private object pnlNav;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn

            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public LogIn()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            server = "127.0.0.1";
            database = "bsit3c_edp";
            uid = "root";
            password = "jobelle";

            string connectionString;
            connectionString = "server=127.0.0.1;uid=root;pwd=jobelle;database=bsit3c_edp";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private (int, string) Credential(string username, string password)
        {
            int userID = -1; // Default value indicating no user found
            string userName = null;

            string query = "SELECT idCredential, username FROM credential WHERE BINARY username = @username AND BINARY password = @password AND isActive = 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    userID = reader.GetInt32("idCredential"); // Retrieve the user ID from the result
                    userName = reader.GetString("username"); // Retrieve the username from the result
                }
            }

            return (userID, userName);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int maxAttempts = 3;
            int attempts = 0;
            bool loginSuccessful = false;

            while (attempts < maxAttempts && !loginSuccessful)
            {
                if (!OpenConnection())
                {
                    MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break; // Exit the loop if connection failed
                }

                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                var userCredentials = Credential(username, password); // Retrieve the user ID and username

                if (userCredentials.Item1 != -1)
                {
                    string loggedInUserName = userCredentials.Item2;

                    Dashboard dashboardForm = new Dashboard(loggedInUserName); // Pass the user ID and username to Dashboard form
                    dashboardForm.Show();
                    this.Hide(); // Hide the login form
                    loginSuccessful = true;
                }
                else
                {
                    attempts++;
                    if (attempts < maxAttempts)
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Optionally clear the password field for a new attempt
                        passwordTextBox.Text = "";
                    }
                }

                CloseConnection(); // Close the connection before retrying
            }

            if (attempts >= maxAttempts)
            {
                MessageBox.Show($"Maximum login attempts ({maxAttempts}) reached. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally handle this, such as closing the application or taking other actions
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myform = new Sign_Up();
            this.Hide();
            myform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new Recovery();
            this.Hide();
            myform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    }

