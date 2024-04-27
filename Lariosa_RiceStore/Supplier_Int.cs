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
    public partial class Supplier_Int : Form
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

        public Supplier_Int()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public Supplier_Int(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            User2.Text = $"Welcome, {currentUserName}"; // Display the current username
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

        private void button1_Click(object sender, EventArgs e)
        {
            var myform = new Generator();
            this.Hide();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myform = new User_Management();
            this.Hide();
            myform.Show();
        }

        private void Dashboard1_Click(object sender, EventArgs e)
        {
            var myform = new Dashboard();
            this.Hide();
            myform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplaySupplierSummary();
        }

        private void DisplaySupplierSummary()
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the views

                string DisplaySupplierSummary = "SELECT * FROM bsit3c_edp.supplier_view;";

                MySqlCommand cmd = new MySqlCommand(DisplaySupplierSummary, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                DataDridSupp.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                string query = "SELECT * FROM bsit3c_edp.supplier_view WHERE BINARY SupplierName LIKE @SupplierName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SupplierName", "%" + textBxSearchSupp.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataDridSupp.DataSource = dt;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                // SQL query to retrieve data
                string query = "SELECT * FROM bsit3c_edp.supplier_view;";
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
                chart1.DataSource = dataTable;

                // Set the X and Y value members
                chart1.Series["Variety_Quanty"].XValueMember = "VarietyName";
                chart1.Series["Variety_Quanty"].YValueMembers = "Quantity";

                // Set the chart type to Line
                chart1.Series["Variety_Quanty"].ChartType = SeriesChartType.Line;

                chart1.Series["Variety_Quanty"].ChartType = SeriesChartType.Line;

                // Set axis titles
                chart1.ChartAreas[0].AxisX.Title = "VarietyName";
                chart1.ChartAreas[0].AxisY.Title = "Quantity";


                // Refresh the chart
                chart1.DataBind();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during database operations
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection when done
                connection.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)

        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                // SQL query to retrieve data
                string query = "SELECT * FROM bsit3c_edp.supplier_view;";
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
                chart2.DataSource = dataTable;

                // Set the X and Y value members
                chart2.Series["Variety_Price"].XValueMember = "VarietyName";
                chart2.Series["Variety_Price"].YValueMembers = "Price";

                // Set the chart type to Line (for example)
                chart2.Series["Variety_Price"].ChartType = SeriesChartType.Line;

                // Set axis titles
                chart2.ChartAreas[0].AxisX.Title = "VarietyName";
                chart2.ChartAreas[0].AxisY.Title = "Price";
                // Refresh the chart
                chart2.DataBind();
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

        private void chart1_Click(object sender, EventArgs e)
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

        private void ExportToExcel_Supplier(DataTable dataTable, string templateFilePath, string newFilePath)
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



        public DataTable GetDataTable_Supplier()

        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();
                string query = "SELECT * FROM bsit3c_edp.supplier_view";
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
        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();
                connection.Open();

                // Retrieve data from the supplier_view table
                DataTable supplierDataTable = GetDataTable_Supplier();

                // Retrieve data from the credentials table
                DataTable credentialsDataTable = new DataTable();
                string credentialsQuery = "SELECT name, position, idCredential FROM credential WHERE idCredential = 3"; // Corrected table name and added idCredential
                using (MySqlCommand credentialsCommand = new MySqlCommand(credentialsQuery, connection))
                {
                    using (MySqlDataAdapter credentialsAdapter = new MySqlDataAdapter(credentialsCommand))
                    {
                        credentialsAdapter.Fill(credentialsDataTable);
                    }
                }

                string templateFilePath = @"C:\Users\HP\Documents\VeriRice_Template.xlsx";
                string newFilePath = @"C:\Users\HP\Documents\GeneratedReport_Supplier.xlsx";

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

        private void Supplier_Int_Load(object sender, EventArgs e)
        {

        }
    }
}





