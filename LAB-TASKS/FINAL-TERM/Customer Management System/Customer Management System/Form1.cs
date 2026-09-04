using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace Customer_Management_System
{
    public partial class Form1 : Form
    {
        string conString = @"Data Source=RIFATPC\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


         }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rdoMale.Checked) gender = "Male";
            else if (rdoFemale.Checked) gender = "Female";
            else if (rdoOthers.Checked) gender = "Others";

            string category = "";
            if (rdoGeneral.Checked) category = "General";
            else if (rdoPremium.Checked) category = "Premium";

            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "INSERT INTO Users (UserName, Password, Gender, Category) VALUES (@UserName, @Password, @Gender, @Category)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Category", category);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Inserted Successfully!");
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT Password, Gender, Category FROM Users WHERE UserName = @UserName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", textBox1.Text); // Replace textBox1 with txtName if renamed

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtPassword.Text = reader["Password"].ToString();

                        string gender = reader["Gender"].ToString();
                        rdoMale.Checked = (gender == "Male");
                        rdoFemale.Checked = (gender == "Female");
                        rdoOthers.Checked = (gender == "Others");

                        string category = reader["Category"].ToString();
                        rdoGeneral.Checked = (category == "General");
                        rdoPremium.Checked = (category == "Premium");
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }

                    con.Close();
                }
            }
        
        