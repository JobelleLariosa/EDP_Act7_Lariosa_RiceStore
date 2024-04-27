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
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;

namespace Lariosa_RiceStore
{
    public partial class Customers : Form
    {
        private object pnlNav;
        private string currentUserName;
        private int currentUserID;

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

        public Customers()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public Customers(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            User1.Text = $"Welcome, {currentUserName}"; // Display the current username
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VariRice_Logo_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var customerForm = new Sales(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void DisplayCustomer()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.salespercustomer;";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                customerview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    connection.Dispose();
                }
            }
        }


        private void DisplayAllCustomer()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.customers;";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                dataGridCustomers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    connection.Dispose();
                }
            }
        }


        private void AddCustomer(int Customer_ID, string CustomerName, string ContactNumber, string Location, string Payment, string Email)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Prepare the SQL query
                string query = "INSERT INTO customers (CustomerID, CustomerName, ContactNumber, Location, Payment, Email) VALUES (@CustomerID, @CustomerName, @ContactNumber, @Location, @Payment, @Email)";

                MySqlCommand cmdNewCustomer = new MySqlCommand(query, connection);
                cmdNewCustomer.Parameters.AddWithValue("@CustomerID", Customer_ID);
                cmdNewCustomer.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmdNewCustomer.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                cmdNewCustomer.Parameters.AddWithValue("@Location", Location);
                cmdNewCustomer.Parameters.AddWithValue("@Payment", Payment);
                cmdNewCustomer.Parameters.AddWithValue("@Email", Email);

                connection.Open();

                // Execute the query
                int rowsAffected = cmdNewCustomer.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer added successfully.");
                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure connection closure and disposal
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    connection.Dispose();
                }
            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomers_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CustomerID1.Text, out int customerID))
            {
                string customername = CustomerName.Text;
                string contactnumber = CustomerNum.Text;
                string location = Location.Text;
                string payment = textBox7.Text;
                string email = Emailtxt.Text;

                if (!string.IsNullOrEmpty(customername) &&
                    !string.IsNullOrEmpty(contactnumber) &&
                    !string.IsNullOrEmpty(location) &&
                    !string.IsNullOrEmpty(payment) &&
                    !string.IsNullOrEmpty(email))
                {
                    try
                    {
                        AddCustomer(customerID, customername, contactnumber, location, payment, email);
                        MessageBox.Show("Customer added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            else
            {
                MessageBox.Show("Error: Unable to parse customer ID.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayAllCustomer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                string query = "SELECT * FROM bsit3c_edp.salespercustomer WHERE BINARY CustomerName LIKE @CustomerName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CustomerName", "%" + txtSearch.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                customerview.DataSource = dt;
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

        private void DataVisualization_Click(object sender, EventArgs e)
        {

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
    }
    }

