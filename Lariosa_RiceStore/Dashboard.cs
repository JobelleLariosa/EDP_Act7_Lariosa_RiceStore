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
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;
using System.IO;
using ClosedXML.Excel;

namespace Lariosa_RiceStore
{
	public partial class Dashboard : Form
	{
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

        public Dashboard()
		{
			InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}

       public int CurrentUserID { get; set; }

        public Dashboard(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            User.Text = $"Welcome, {currentUserName}"; // Display the current username
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VariRice_Logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var customerForm = new OrderRice(); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            var customerForm = new Sales(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            var customerForm = new Generator(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var customerForm = new User_Management(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            var myform = new LogIn();
            this.Hide();
            myform.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                // SQL query to retrieve data
                string query = "SELECT * FROM bsit3c_edp.salespercustomer";
                // Open the connection
                connection.Open();

                // Create a new MySqlCommand object with the query and connection
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Create a new MySqlDataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Create a new DataTable to hold the result
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the result of the SQL query
                adapter.Fill(dataTable);

                // Bind the DataTable to the chart
                chart5.DataSource = dataTable;

                // Set the X and Y value members
                chart5.Series["Customer_Profit"].XValueMember = "CustomerName";
                chart5.Series["Customer_Profit"].YValueMembers = "TotalSalesQuantity";

                // Set the chart type to Bubble
                chart5.Series["Customer_Profit"].ChartType = SeriesChartType.Line;

                // Set axis titles
                chart5.ChartAreas[0].AxisX.Title = "CustomerName";
                chart5.ChartAreas[0].AxisY.Title = "TotalSalesQuantity";

                // Refresh the chart
                chart5.DataBind();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during database operations
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection when done
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                // SQL query to retrieve data
                string query = "SELECT * FROM bsit3c_edp.prices_stock_varieties;";
                // Open the connection
                connection.Open();

                // Create a new MySqlCommand object with the query and connection
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Create a new MySqlDataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Create a new DataTable to hold the result
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the result of the SQL query
                adapter.Fill(dataTable);

                // Bind the DataTable to the chart
                chart6.DataSource = dataTable;

                // Set the X and Y value members
                chart6.Series["Variety_price"].XValueMember = "VarietyName";
                chart6.Series["Variety_price"].YValueMembers = "Price";

                // Set the chart type to Bubble
                chart6.Series["Variety_price"].ChartType = SeriesChartType.Line;

                // Set axis titles
                chart6.ChartAreas[0].AxisX.Title = "VarietyName";
                chart6.ChartAreas[0].AxisY.Title = "Price";

                // Refresh the chart
                chart6.DataBind();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during database operations
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection when done
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }
    }
}

