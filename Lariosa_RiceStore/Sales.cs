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
    public partial class Sales : Form
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

        public Sales()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }


        public Sales(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            User1.Text = $"Welcome, {currentUserName}"; // Display the current username
        }

        private void DisplaySalesData()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.` topvarietiesbysales`";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                dataGridView1.DataSource = dt;
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

        private void SummarySales()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.salessummary";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                summary.DataSource = dt;
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

        private void DisplayTotalSales()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the views
                string querySalesQuantity = "SELECT SUM(TotalSalesQuantity) AS TotalSalesQuantity FROM top_varietiessales";


                MySqlCommand cmdSalesQuantity = new MySqlCommand(querySalesQuantity, connection);

                connection.Open();

                // Execute the queries and get the results
                object resultSalesQuantity = cmdSalesQuantity.ExecuteScalar();

                if (resultSalesQuantity != null)
                {
                    // Convert the results to the appropriate data type (if needed)
                    int totalSalesQuantity = Convert.ToInt32(resultSalesQuantity);

                    // Display the total sales quantity and total sales profit
                    sale_total.Text = totalSalesQuantity.ToString();
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
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
                Customerstabl.DataSource = dt;
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
        private void DisplayProfit()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the views

                string querySalesProfit = "SELECT SUM(TotalRevenue_Profit) AS TotalRevenue_Profit FROM salessummary";


                MySqlCommand cmdSalesProfit = new MySqlCommand(querySalesProfit, connection);

                connection.Open();

                // Execute the queries and get the results
                object resultSalesProfit = cmdSalesProfit.ExecuteScalar();

                if (resultSalesProfit != null)
                {
                    // Convert the results to the appropriate data type (if needed)
                    int totalSalesProfit = Convert.ToInt32(resultSalesProfit);

                    // Display the total sales quantity and total sales profit
                    profit.Text = totalSalesProfit.ToString();
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
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



        private void AddSales(int sales_id, int variety_id, int customer_id, int quantity, DateTime salesDate)
        {
            MySqlConnection connection = null;
            try
            {
                using (connection = Connection.GetConnection())
                {
                    // Prepare the SQL query
                    string query = "INSERT INTO sales (SaleID, VarietyID, CustomerID, Quantity, SaleDate) VALUES (@SalesID, @VarietyID, @CustomerID, @Quantity, @SaleDate)";

                    using (MySqlCommand cmdNewSales = new MySqlCommand(query, connection))
                    {
                        cmdNewSales.Parameters.AddWithValue("@SalesID", sales_id);
                        cmdNewSales.Parameters.AddWithValue("@VarietyID", variety_id);
                        cmdNewSales.Parameters.AddWithValue("@CustomerID", customer_id);
                        cmdNewSales.Parameters.AddWithValue("@Quantity", quantity);
                        cmdNewSales.Parameters.AddWithValue("@SaleDate", salesDate);

                        connection.Open();

                        // Execute the query
                        int rowsAffected = cmdNewSales.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sales added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure connection closure and disposal
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void Dashboard1_Click(object sender, EventArgs e)
        {
            var customerForm = new Dashboard(currentUserName); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DisplaySalesData();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User1_Click(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {
            DisplayTotalSales();
        }

        private void Total_Pofit_Click(object sender, EventArgs e)
        {
            DisplayProfit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SummarySales();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void new_sales_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Rice_Variety_Click(object sender, EventArgs e)
        {
            var customerForm = new OrderRice(); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void ExportToExcel_Sales(DataTable dataTable, string templateFilePath, string newFilePath)
        {
            try
            {
                // Load the existing Excel template
                using (var workbook = new XLWorkbook(templateFilePath))
                {
                    // Access the worksheet by name
                    var worksheet = workbook.Worksheet("Export Data");

                    // Find the starting cell where you want to insert the data
                    int startRow = 9;
                    int startColumn = 2;

                    // Insert header from DataTable into the worksheet
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(startRow, startColumn + col).Value = dataTable.Columns[col].ColumnName;
                    }

                    // Insert data from the DataTable into the worksheet
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            // Get the value from the DataTable cell
                            object cellValue = dataTable.Rows[row][col];

                            // Adjust the cell position based on the template
                            worksheet.Cell(startRow + row + 1, startColumn + col).Value = cellValue != null ? cellValue.ToString() : "";
                        }
                    }

                    // Save the modified workbook to a new file
                    workbook.SaveAs(newFilePath);
                }

                // Show a message box to indicate successful export
                MessageBox.Show($"Export to {newFilePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public DataTable GetDataTable_Sales()

        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();
                string query = "SELECT * FROM bsit3c_edp.salessummary";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return dataTable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();

                // Retrieve data from the supplier_view table
                DataTable supplierDataTable = GetDataTable_Sales();

                // Retrieve data from the credentials table
                DataTable credentialsDataTable = new DataTable();
                string credentialsQuery = "SELECT name, position, idCredential FROM credential WHERE idCredential = 14"; // Corrected table name and added idCredential
                using (MySqlCommand credentialsCommand = new MySqlCommand(credentialsQuery, connection))
                {
                    using (MySqlDataAdapter credentialsAdapter = new MySqlDataAdapter(credentialsCommand))
                    {
                        credentialsAdapter.Fill(credentialsDataTable);
                    }
                }

                string templateFilePath = @"C:\Users\HP\Documents\VeriRice_Template.xlsx";
                string newFilePath = @"C:\Users\HP\Documents\GeneratedReport_Sales.xlsx";

                // Load the existing Excel template
                using (var workbook = new XLWorkbook(templateFilePath))
                {
                    // Access the worksheet by name
                    var worksheet = workbook.Worksheet("Export Data");

                    // Find the starting cell where you want to insert the data
                    int startRow = 9;
                    int startColumn = 2;

                    // Insert header from supplierDataTable into the worksheet
                    for (int col = 0; col < supplierDataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(startRow, startColumn + col).Value = supplierDataTable.Columns[col].ColumnName;
                    }

                    // Insert data from supplierDataTable into the worksheet
                    for (int row = 0; row < supplierDataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < supplierDataTable.Columns.Count; col++)
                        {
                            // Get the value from the supplierDataTable cell
                            object cellValue = supplierDataTable.Rows[row][col];

                            // Adjust the cell position based on the template
                            worksheet.Cell(startRow + row + 1, startColumn + col).Value = cellValue != DBNull.Value ? cellValue.ToString() : "";
                        }
                    }

                    // Reflect name in cell C6, position in cell F6, and idCredential in cell I7
                    if (credentialsDataTable.Rows.Count > 0)
                    {
                        worksheet.Cell("C6").Value = credentialsDataTable.Rows[0]["name"].ToString();
                        worksheet.Cell("F6").Value = credentialsDataTable.Rows[0]["position"].ToString();
                        worksheet.Cell("I7").Value = credentialsDataTable.Rows[0]["idCredential"].ToString();
                        worksheet.Cell("G55").Value = credentialsDataTable.Rows[0]["name"].ToString();
                    }

                    // Save the modified workbook to a new file
                    workbook.SaveAs(newFilePath);
                }

                // Show a message box to indicate successful export
                MessageBox.Show($"Export to {newFilePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void ExportToExcel_Sale(DataTable dataTable, string templateFilePath, string newFilePath)
        {
            try
            {
                // Load the existing Excel template
                using (var workbook = new XLWorkbook(templateFilePath))
                {
                    // Access the worksheet by name
                    var worksheet = workbook.Worksheet("Export Data");

                    // Find the starting cell where you want to insert the data
                    int startRow = 9;
                    int startColumn = 2;

                    // Insert header from DataTable into the worksheet
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(startRow, startColumn + col).Value = dataTable.Columns[col].ColumnName;
                    }

                    // Insert data from the DataTable into the worksheet
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            // Get the value from the DataTable cell
                            object cellValue = dataTable.Rows[row][col];

                            // Adjust the cell position based on the template
                            worksheet.Cell(startRow + row + 1, startColumn + col).Value = cellValue != null ? cellValue.ToString() : "";
                        }
                    }

                    // Save the modified workbook to a new file
                    workbook.SaveAs(newFilePath);
                }

                // Show a message box to indicate successful export
                MessageBox.Show($"Export to {newFilePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public DataTable GetDataTable_Sale()

        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();
                string query = "SELECT * FROM bsit3c_edp.salespercustomer";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return dataTable;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();

                // Retrieve data from the supplier_view table
                DataTable supplierDataTable = GetDataTable_Sale();

                // Retrieve data from the credentials table
                DataTable credentialsDataTable = new DataTable();
                string credentialsQuery = "SELECT name, position, idCredential FROM credential WHERE idCredential = 12"; // Corrected table name and added idCredential
                using (MySqlCommand credentialsCommand = new MySqlCommand(credentialsQuery, connection))
                {
                    using (MySqlDataAdapter credentialsAdapter = new MySqlDataAdapter(credentialsCommand))
                    {
                        credentialsAdapter.Fill(credentialsDataTable);
                    }
                }

                string templateFilePath = @"C:\Users\HP\Documents\VeriRice_Template.xlsx";
                string newFilePath = @"C:\Users\HP\Documents\GeneratedReport.xlsx";

                // Load the existing Excel template
                using (var workbook = new XLWorkbook(templateFilePath))
                {
                    // Access the worksheet by name
                    var worksheet = workbook.Worksheet("Export Data");

                    // Find the starting cell where you want to insert the data
                    int startRow = 9;
                    int startColumn = 2;

                    // Insert header from supplierDataTable into the worksheet
                    for (int col = 0; col < supplierDataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(startRow, startColumn + col).Value = supplierDataTable.Columns[col].ColumnName;
                    }

                    // Insert data from supplierDataTable into the worksheet
                    for (int row = 0; row < supplierDataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < supplierDataTable.Columns.Count; col++)
                        {
                            // Get the value from the supplierDataTable cell
                            object cellValue = supplierDataTable.Rows[row][col];

                            // Adjust the cell position based on the template
                            worksheet.Cell(startRow + row + 1, startColumn + col).Value = cellValue != DBNull.Value ? cellValue.ToString() : "";
                        }
                    }

                    // Reflect name in cell C6, position in cell F6, and idCredential in cell I7
                    if (credentialsDataTable.Rows.Count > 0)
                    {
                        worksheet.Cell("C6").Value = credentialsDataTable.Rows[0]["name"].ToString();
                        worksheet.Cell("F6").Value = credentialsDataTable.Rows[0]["position"].ToString();
                        worksheet.Cell("I7").Value = credentialsDataTable.Rows[0]["idCredential"].ToString();
                        worksheet.Cell("G55").Value = credentialsDataTable.Rows[0]["name"].ToString();
                    }

                    // Save the modified workbook to a new file
                    workbook.SaveAs(newFilePath);
                }

                // Show a message box to indicate successful export
                MessageBox.Show($"Export to {newFilePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }
    }
}
