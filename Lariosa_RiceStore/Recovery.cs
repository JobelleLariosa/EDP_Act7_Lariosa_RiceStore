using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Lariosa_RiceStore
{
    public partial class Recovery : Form
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

        public Recovery()
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtRecoveryUsername.Text;
            string email = txtRecoveryEmail.Text;

            try
            {
                if (OpenConnection())
                {
                    string query = "SELECT COUNT(*) FROM credential WHERE BINARY username = @username AND email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // Define parameters and set their values
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        query = "SELECT password FROM credential WHERE username = @username AND email = @email";
                        cmd.CommandText = query;

                        // Execute the query and retrieve the password
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                string recoveredPassword = dataReader.GetString(0);
                                MessageBox.Show($"Your password is: {recoveredPassword}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or email");
                    }

                    CloseConnection();
                }
                else
                {
                    MessageBox.Show("Error connecting to the database");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var myform = new LogIn();
            this.Hide();
            myform.Show();
        }

        private void Recovery_Load(object sender, EventArgs e)
        {

        }
    }
}

