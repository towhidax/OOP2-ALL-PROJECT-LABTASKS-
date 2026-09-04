using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeOrderManagementSystem
{
    public partial class Form1 : Form
    {
        public class Order
        {
            private List<string> foodItems = new List<string>();

            public bool AddItem(string item)
            {
                if (foodItems.Contains(item))
                    return false;

                foodItems.Add(item);
                return true;
            }

            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < foodItems.Count)
                        return foodItems[index];
                    else
                        throw new IndexOutOfRangeException("Invalid index entered!");
                }
                set
                {
                    if (index >= 0 && index < foodItems.Count)
                        foodItems[index] = value;
                    else
                        throw new IndexOutOfRangeException("Invalid index entered!");
                }
            }

            public List<string> GetItems() => foodItems;
            public int Count => foodItems.Count;
            public void Clear() => foodItems.Clear();
        }

        string connectionString =
            @"Data Source=RIFATPC\SQLEXPRESS;Initial Catalog=CafeDB;Integrated Security=True";

        Order currentOrder = new Order();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // INSERT BUTTON
        private void btnInsert_Click(object sender, EventArgs e)
        {
            currentOrder.Clear();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                currentOrder.AddItem(item.ToString());
            }

            string gender =
                rdoMale.Checked ? "Male" :
                rdoFemale.Checked ? "Female" :
                "Others";

            string membership =
                rdoRegular.Checked ? "Regular" :
                rdoSliver.Checked ? "Silver" :
                "Gold";

            string itemsList = string.Join(", ", currentOrder.GetItems());
            double totalBill = currentOrder.Count * 5.0; // Assumed $5.0 per item

            string query =
                "INSERT INTO Customers " +
                "(CustomerName, PhoneNumber, Gender, MembershipType, OrderItems, TotalItems, TotalBill) " +
                "VALUES (@Name, @Phone, @Gender, @Membership, @Items, @TotalItems, @TotalBill)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneName.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Membership", membership);
                cmd.Parameters.AddWithValue("@Items", itemsList);
                cmd.Parameters.AddWithValue("@TotalItems", currentOrder.Count);
                cmd.Parameters.AddWithValue("@TotalBill", totalBill);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    label6.Text = $"Items: {currentOrder.Count} | Bill: ${totalBill:0.00}";

                    MessageBox.Show("Customer & Order Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // duplicate customer name
                        MessageBox.Show("Error: A customer with this name is already registered!", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // UPDATE BUTTON — updates the existing customer's order based on the currently checked items
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            currentOrder.Clear();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                currentOrder.AddItem(item.ToString());
            }

            string itemsList = string.Join(", ", currentOrder.GetItems());
            double totalBill = currentOrder.Count * 5.0;

            string query =
                "UPDATE Customers SET OrderItems=@Items, TotalItems=@TotalItems, TotalBill=@TotalBill " +
                "WHERE CustomerName=@Name";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Items", itemsList);
                cmd.Parameters.AddWithValue("@TotalItems", currentOrder.Count);
                cmd.Parameters.AddWithValue("@TotalBill", totalBill);

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        label6.Text = $"Items: {currentOrder.Count} | Bill: ${totalBill:0.00}";
                        MessageBox.Show("Order Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No matching customer found to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // SEARCH BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customers WHERE CustomerName = @Name";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtPhoneName.Text = reader["PhoneNumber"].ToString();
                        label6.Text = $"Items: {reader["TotalItems"]} | Bill: ${reader["TotalBill"]}";
                        MessageBox.Show("Customer Record Found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Customers WHERE CustomerName = @Name";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Customer Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No Record Found to Delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtCustomerName.Clear();
            txtPhoneName.Clear();
            label6.Text = "label6";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            currentOrder.Clear();
        }
    }
}














