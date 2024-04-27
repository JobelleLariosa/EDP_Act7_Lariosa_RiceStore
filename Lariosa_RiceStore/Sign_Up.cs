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
    public partial class Sign_Up : Form
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


        public Sign_Up()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Add Account

        private void AddAccount(string username, string password, string name, string email, bool isActive, string position)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO credential (username, password, name, email, isActive, position) VALUES (@username, @password, @name, @email, @status, @position)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", isActive);
                cmd.Parameters.AddWithValue("@position", position);

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;
            string name = txtBxName.Text;
            string email = txtBxEmail.Text;
            string position = txtBoxPosition.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                // Assuming isActive is set to true by default upon registration
                AddAccount(username, password, name, email, true, position);
                MessageBox.Show("Account added successfully.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var myform = new LogIn();
            this.Hide();
            myform.Show();
        }


    }
}
