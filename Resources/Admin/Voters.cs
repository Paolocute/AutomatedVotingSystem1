using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace AutomatedVotingSystem1.Resources.Admin
{
    public partial class Voters : UserControl
    {
        private string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";
        public Voters()
        {
            InitializeComponent();
            LoadVoters();
            ClearFields();
        }

        private void Voters_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrEmpty(txtvName.Text) || string.IsNullOrEmpty(txtvStudentID.Text) ||
                string.IsNullOrEmpty(txtvContactNo.Text) || string.IsNullOrEmpty(txtvEmail.Text) ||
                string.IsNullOrEmpty(txtvPassword.Text) || string.IsNullOrEmpty(txtvConfirmPass.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (txtvPassword.Text.Trim() != txtvConfirmPass.Text.Trim())
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert into Users table with 'Voter' role
                    string query1 = "INSERT INTO Users (Email, Password, Role) VALUES (@Email, @Password, 'Voter')";
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@Email", txtvEmail.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Password", txtvPassword.Text.Trim()); // Store plain password (for simplicity in this example)
                        cmd1.ExecuteNonQuery();
                    }

                    // Insert into Voters table
                    string query2 = "INSERT INTO Voters (Name, StudentID, ContactNo, Email, Address) " +
                                    "VALUES (@Name, @StudentID, @ContactNo, @Email, @Address)";
                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@Name", txtvName.Text.Trim());
                        cmd2.Parameters.AddWithValue("@StudentID", txtvStudentID.Text.Trim());
                        cmd2.Parameters.AddWithValue("@ContactNo", txtvContactNo.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Email", txtvEmail.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Address", txtvAddress.Text.Trim());
                        cmd2.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("Voter registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload voters after successful registration
                LoadVoters();

                // Clear input fields
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
         
        private void ClearFields()
        {
            txtvName.Clear();
            txtvStudentID.Clear();
            txtvContactNo.Clear();
            txtvEmail.Clear();
            txtvAddress.Clear();
            txtvPassword.Clear();
            txtvConfirmPass.Clear();
        }
        private void LoadVoters()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // If you're using the Users table to store the basic voter information:
                    string query = "SELECT VoterID, Name, StudentID, ContactNo, Email, Address, Password FROM Voters";


                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to DataGridView
                    datagridVoters.DataSource = dt;
                    datagridVoters.Refresh(); // Ensure DataGridView is refreshed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading voters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

