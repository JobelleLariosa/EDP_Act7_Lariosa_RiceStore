using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using System.Windows.Forms;

namespace Lariosa_RiceStore
{
    public partial class Suppliers_Varieties : Form
    {
        private int currentUserID; // Field to hold the current user ID
        private string currentUserName;

        public Suppliers_Varieties(string userName)
        {
            InitializeComponent();
            currentUserName = userName; // Assign the received username to the currentUserName field
            User2.Text = $"Welcome, {currentUserName}"; // Display the current username
        }

        public int CurrentUserID { get; set; }

        private void AddSupplier(int SupplierID, string SupplierName, string ContactPerson, string ContactNumber)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Prepare the SQL query
                string query = "INSERT INTO suppliers (SupplierID, SupplierName, ContactPerson, ContactNumber) VALUES (@SupplierID, @SupplierName, @ContactPerson, @ContactNumber)";
                MySqlCommand cmdNewCustomer = new MySqlCommand(query, connection);
                cmdNewCustomer.Parameters.AddWithValue("@SupplierID", SupplierID);
                cmdNewCustomer.Parameters.AddWithValue("@SupplierName", SupplierName);
                cmdNewCustomer.Parameters.AddWithValue("@ContactPerson", ContactPerson);
                cmdNewCustomer.Parameters.AddWithValue("@ContactNumber", ContactNumber);

                connection.Open();

                // Execute the query
                int rowsAffected = cmdNewCustomer.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Supplier added successfully.");
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


        private void AddStocks(int StockID, int VarietyID, int SupplierID, int Quantity, decimal Price, DateTime PurchaseDate)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Prepare the SQL query
                string query = "INSERT INTO ricestock (StockID, VarietyID, SupplierID, Quantity, Price, PurchaseDate) VALUES (@StockID, @VarietyID, @SupplierID, @Quantity, @Price, @PurchaseDate)";
                MySqlCommand cmdNewCustomer = new MySqlCommand(query, connection);
                cmdNewCustomer.Parameters.AddWithValue("@StockID", StockID);
                cmdNewCustomer.Parameters.AddWithValue("@VarietyID", VarietyID);
                cmdNewCustomer.Parameters.AddWithValue("@SupplierID", SupplierID);
                cmdNewCustomer.Parameters.AddWithValue("@Quantity", Quantity);
                cmdNewCustomer.Parameters.AddWithValue("@Price", Price);
                cmdNewCustomer.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);

                connection.Open();

                // Execute the query
                int rowsAffected = cmdNewCustomer.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New stocks are added successfully.");
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



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Supplier_ID = txtBxSuppID.Text;
            string SupplierName = txtBxSuppName.Text;
            string ContactPerson = txtBxContactName.Text;
            string ContactNumber = txtBxContactNumber.Text;

            if (!string.IsNullOrEmpty(Supplier_ID) &&
                !string.IsNullOrEmpty(SupplierName) &&
                !string.IsNullOrEmpty(ContactPerson) &&
                !string.IsNullOrEmpty(ContactNumber))
            {
                // Attempt to parse Supplier_ID
                if (int.TryParse(Supplier_ID, out int parsedSupplierID))
                {
                    // Call the AddSupplier method with parsed values
                    AddSupplier(parsedSupplierID, SupplierName, ContactPerson, ContactNumber);
                    MessageBox.Show("Supplier added successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid Supplier ID format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.supplier_view";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                dataGridSupplier_Stocks.DataSource = dt;
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

        private void button5_Click(object sender, EventArgs e)
        {
            string StockID = txtbxStockID.Text;
            string VarietyID = txtbxVarietyID.Text;
            string SupplierID = txtbxSupplierID.Text;
            string Quantity = txtbxQuantity.Text;
            string Price = txtbxPrice.Text;
            string PurchaseDate = txtbxPurchaseDate.Text;

            if (!string.IsNullOrEmpty(StockID) &&
                !string.IsNullOrEmpty(VarietyID) &&
                !string.IsNullOrEmpty(SupplierID) &&
                !string.IsNullOrEmpty(Quantity) &&
                !string.IsNullOrEmpty(Price) &&
                !string.IsNullOrEmpty(PurchaseDate))
            {
                if (int.TryParse(Quantity, out int quantity) && decimal.TryParse(Price, out decimal price) && DateTime.TryParse(PurchaseDate, out DateTime purchaseDate))
                {
                    // Call the AddStocks method with parsed values
                    AddStocks(int.Parse(StockID), int.Parse(VarietyID), int.Parse(SupplierID), quantity, price, purchaseDate);
                }
                else
                {
                    MessageBox.Show("Invalid quantity, price, or purchase date format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }




        private void button8_Click(object sender, EventArgs e)
        {

            string StockID = txtbxStockID.Text;
            string VarietyID = txtbxVarietyID.Text;
            string SupplierID = txtbxSupplierID.Text;
            string Quantity = txtbxQuantity.Text;
            string Price = txtbxPrice.Text;
            string PurchaseDate = txtbxPurchaseDate.Text;

            if (!string.IsNullOrEmpty(StockID) &&
                !string.IsNullOrEmpty(VarietyID) &&
                !string.IsNullOrEmpty(SupplierID) &&
                !string.IsNullOrEmpty(Quantity) &&
                !string.IsNullOrEmpty(Price) &&
                !string.IsNullOrEmpty(PurchaseDate))
            {
                if (int.TryParse(Quantity, out int quantity) && decimal.TryParse(Price, out decimal price) && DateTime.TryParse(PurchaseDate, out DateTime purchaseDate))
                {
                    MySqlConnection connection = null;
                    try
                    {
                        connection = Connection.GetConnection();

                        string updateQuery = "UPDATE ricestock SET VarietyID = @VarietyID, SupplierID = @SupplierID, Quantity = @Quantity, Price = @Price, PurchaseDate = @PurchaseDate WHERE StockID = @StockID";

                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@StockID", StockID);
                            command.Parameters.AddWithValue("@VarietyID", VarietyID);
                            command.Parameters.AddWithValue("@SupplierID", SupplierID);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Stock updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows updated. Stock not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid quantity, price, or purchase date format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }

        }


        private void button9_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Query the view
                string query = "SELECT * FROM bsit3c_edp.ricestock";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to GridView
                dataGridViewStock.DataSource = dt;
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


        private void AddVariety(int VarietyID, string VarietyName)
        {
            MySqlConnection connection = null;
            try
            {
                connection = Connection.GetConnection();

                // Prepare the SQL query
                string query = "INSERT INTO ricevarieties (VarietyID, VarietyName) VALUES (@VarietyID, @VarietyName)";
                MySqlCommand cmdNewCustomer = new MySqlCommand(query, connection);
                cmdNewCustomer.Parameters.AddWithValue("@VarietyID", VarietyID);
                cmdNewCustomer.Parameters.AddWithValue("@VarietyName", VarietyName);

                connection.Open();

                // Execute the query
                int rowsAffected = cmdNewCustomer.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("New variety are added successfully.");
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
        }

        private void label13_Click(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {
            string varietyIDText = txtBoxVarietyID.Text;
            string varietyName = txtBoxVarietyName.Text;

            if (!string.IsNullOrEmpty(varietyIDText) && !string.IsNullOrEmpty(varietyName))
            {
                // Attempt to parse variety ID
                if (int.TryParse(varietyIDText, out int parsedVarietyID))
                {
                    // Call the AddVariety method with parsed values
                    AddVariety(parsedVarietyID, varietyName);
                    MessageBox.Show("Variety added successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid variety ID format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            string varietyIDText = txtBoxVarietyID.Text;
            string varietyName = txtBoxVarietyName.Text;

            if (!string.IsNullOrEmpty(varietyIDText) && !string.IsNullOrEmpty(varietyName))
            {
                // Attempt to parse variety ID
                if (int.TryParse(varietyIDText, out int parsedVarietyID))
                {
                    MySqlConnection connection = null;
                    try
                    {
                        connection = Connection.GetConnection(); // Assuming this method returns a MySqlConnection object

                        string updateQuery = "UPDATE ricevarieties SET VarietyName = @VarietyName WHERE VarietyID = @VarietyID";

                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@VarietyName", varietyName);
                            command.Parameters.AddWithValue("@VarietyID", parsedVarietyID);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Variety updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows updated. Variety not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid variety ID format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}


