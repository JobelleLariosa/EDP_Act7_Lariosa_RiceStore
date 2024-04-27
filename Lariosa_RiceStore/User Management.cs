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
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Lariosa_RiceStore
{
    public partial class User_Management : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private object pnlNav;
        private int currentUserID; // Field to hold the current user ID
        private string currentUserName;

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

        public User_Management()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

       
        public void InitializeDatabase()
        {
            server = "127.0.0.1";
            database = "bsit3c_edp";
            uid = "root";
            password = "jobelle";

            string connectionString;
            connectionString = "server=127.0.0.1;uid=root;pwd=jobelle;database=bsit3c_edp";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
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

        public bool CloseConnection()
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

        public User_Management(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            UserM.Text = $"Welcome, {currentUserName}"; // Display the current username
        }
        public void RefreshAccountList()
        {

            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                string query = "SELECT * FROM credential";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshAccountList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM credential WHERE BINARY name LIKE @name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", "%" + textBox_search.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Retrieve the new profile information from the user
            string newUsername = txtBxUsername1.Text.Trim();
            string newPassword = txtBxPassword1.Text.Trim();
            string newName = txtBxName1.Text.Trim();
            string newEmail = txtBxEmail1.Text.Trim();
            int accountId = Convert.ToInt32(textBoxID.Text.Trim()); // Assuming textBoxID contains the account ID

            // Validate the input
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                connection.Open();
                string query = "UPDATE credential SET username = @username, password = @password, name = @name, email = @email "
                             + "WHERE idCredential = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", newUsername);
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@name", newName);
                cmd.Parameters.AddWithValue("@email", newEmail);
                cmd.Parameters.AddWithValue("@id", accountId);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account profile updated successfully.");
                    RefreshAccountList(); // Refresh the DataGridView to reflect the changes
                }
                else
                {
                    MessageBox.Show("Failed to update account profile. Account not found.");
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }


        }

        public void UpdateAccountStatus(int status)
        {
            // Get the selected user from the DataGridView
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            // Retrieve the selected user's ID from the DataGridView
            int idCredential = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idCredential"].Value);

            // Update the user's status in the database
            try
            {
                connection.Open();
                string query = "UPDATE credential SET IsActive = @status WHERE idCredential = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idCredential);
                cmd.Parameters.AddWithValue("@status", status);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    string action = status == 1 ? "activated" : "deactivated";
                    MessageBox.Show("User account " + action + " successfully.");
                    RefreshAccountList(); // Refresh the DataGridView to reflect the changes
                }
                else
                {
                    MessageBox.Show("Failed to update user account. User not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateAccountStatus(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateAccountStatus(0);
        }

        private void txtBxPassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard1_Click(object sender, EventArgs e)
        {

            var customerForm = new Dashboard(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var customerForm = new Sales(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            var customerForm = new Customers(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            var customerForm = new Supplier_Int(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var customerForm = new Generator(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var customerForm = new User_Management(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Management_Load(object sender, EventArgs e)
        {

        }

        private void Rice_Stock_Click(object sender, EventArgs e)
        {
            var customerForm = new Suppliers_Varieties(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void Rice_Variety_Click(object sender, EventArgs e)
        {
            var customerForm = new OrderRice(); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }
    }
}
