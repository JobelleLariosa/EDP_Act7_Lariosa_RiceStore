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
    public partial class Generator : Form
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


        public Generator()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public Generator(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            User.Text = $"Welcome, {currentUserName}"; // Display the current username
        }
        private void progressBar3_Click(object sender, EventArgs e)
        {
                    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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
            var myform = new Dashboard();
            this.Hide();
            myform.Show();
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
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
                chart3.DataSource = dataTable;

                // Set the X and Y value members
                chart3.Series["Profit_Varity"].XValueMember = "VarietyName";
                chart3.Series["Profit_Varity"].YValueMembers = "TotalRevenue_Profit";

                // Set the chart type to Bubble
                chart3.Series["Profit_Varity"].ChartType = SeriesChartType.Bubble;

                // Set axis titles
                chart3.ChartAreas[0].AxisX.Title = "VarietyName";
                chart3.ChartAreas[0].AxisY.Title = "TotalProfit";

                // Set axis label rotation and interval for chart3
                chart3.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart3.ChartAreas[0].AxisX.Interval = 1;

                // Refresh the chart
                chart3.DataBind();
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


        private void DisplayAllTotalValue()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.salespercustomer";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                dataGridViewTotalValue.DataSource = dt;
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                // SQL query to retrieve data
                string query = "SELECT CustomerName, SUM(TotalSalesQuantity) AS TotalSalesQuantity FROM bsit3c_edp.salespercustomer GROUP BY CustomerName ORDER BY TotalSalesQuantity ASC LIMIT 8";
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
                chart4.DataSource = dataTable;

                // Set the X and Y value members
                chart4.Series["Customer_Variety"].XValueMember = "CustomerName";
                chart4.Series["Customer_Variety"].YValueMembers = "TotalSalesQuantity";

                // Set the chart type to Bar
                chart4.Series["Customer_Variety"].ChartType = SeriesChartType.Bar;

                // Set axis titles
                chart4.ChartAreas[0].AxisX.Title = "CustomerName";
                chart4.ChartAreas[0].AxisY.Title = "TotalSalesQuantity";

                // Refresh the chart
                chart4.DataBind();
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

        private void ExportToExcel(DataTable dataTable, string templateFilePath, string newFilePath)
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



        public DataTable GetDataTable()

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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();

                // Retrieve data from the supplier_view table
                DataTable supplierDataTable = GetDataTable();

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
                string newFilePath = @"C:\Users\HP\Documents\GeneratedReport_TotalValue.xlsx";

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

        private void ExportToExcel_TopCustomers(DataTable dataTable, string templateFilePath, string newFilePath)
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



        public DataTable GetDataTable_TopCustomer()

        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();
                string query = "SELECT CustomerName, SUM(TotalSalesQuantity) AS TotalSalesQuantity FROM bsit3c_edp.salespercustomer GROUP BY CustomerName ORDER BY TotalSalesQuantity";
                // Open the connection";
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


        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayAllTotalValue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();

                // Retrieve data from the supplier_view table
                DataTable supplierDataTable = GetDataTable_TopCustomer();

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
                string newFilePath = @"C:\Users\HP\Documents\GeneratedReport_TopCustomers.xlsx";

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

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT CustomerName, SUM(TotalSalesQuantity) AS TotalSalesQuantity FROM bsit3c_edp.salespercustomer GROUP BY CustomerName ORDER BY TotalSalesQuantity";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                dataGridView_TotalValue.DataSource = dt;
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
    }
}
    
  
