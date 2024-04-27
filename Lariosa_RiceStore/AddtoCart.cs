using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using System.Windows.Forms;

namespace Lariosa_RiceStore
{
    public partial class AddtoCart : Form
    {
        public AddtoCart()
        {
            InitializeComponent();
        }


        private void AddSales(int saleId, int varietyId, int customerId, int quantity, DateTime salesDate)
        {
            MySqlConnection connection = null;
            try
            {
                // Establish database connection
                connection = Connection.GetConnection();

                // Define the SQL query to insert sales data
                string insertQuery = "INSERT INTO sales (SaleID, VarietyID, CustomerID, Quantity, SaleDate) VALUES (@SaleID, @VarietyID, @CustomerID, @Quantity, @SaleDate)";

                // Create MySqlCommand object with the insert query and connection
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@SaleID", saleId);
                    command.Parameters.AddWithValue("@VarietyID", varietyId);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@SaleDate", salesDate);

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sales added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add sales.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {// Ensure connection closure and disposal
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    connection.Dispose();
                }
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            string sale_id = SalesID.Text;
            string variety_id = VarietyID.Text;
            string customer_id = CustomerID.Text;
            string quantityText = Quantity.Text;
            string salesDateText = SaleDate.Text;

            if (!string.IsNullOrEmpty(sale_id) &&
                !string.IsNullOrEmpty(variety_id) &&
                !string.IsNullOrEmpty(customer_id) &&
                !string.IsNullOrEmpty(quantityText) &&
                !string.IsNullOrEmpty(salesDateText))
            {
                // Attempt to parse quantity and salesDate
                if (int.TryParse(quantityText, out int quantity) && DateTime.TryParse(salesDateText, out DateTime salesDate))
                {
                    // Call the AddSales method with parsed values
                    AddSales(int.Parse(sale_id), int.Parse(variety_id), int.Parse(customer_id), quantity, salesDate);
                    MessageBox.Show("Sales added successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid quantity or sales date format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }

        }

    

    private void button1_Click(object sender, EventArgs e)
        {
            var customerForm = new OrderRice(); // Pass the user ID and username to Customers form
            this.Hide();
            customerForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
