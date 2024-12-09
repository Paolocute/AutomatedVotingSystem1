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
using System.Data.SqlClient;
using AutomatedVotingSystem1.Resources.Admin;
using AutomatedVotingSystem1.Resources.Voters;

namespace AutomatedVotingSystem1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter the username or email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter the password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check user credentials and role
                    string query = "SELECT Role FROM Users WHERE (Email = @Username OR Username = @Username) AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        object roleObj = cmd.ExecuteScalar();

                        if (roleObj != null)
                        {
                            string role = roleObj.ToString();

                            if (role == "Admin")
                            {
                                MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainDashboard mainDash = new MainDashboard();
                                mainDash.Show();
                                this.Hide();
                            }
                            else if (role == "Voter")
                            {
                                MessageBox.Show("Voter Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Fetch additional voter details
                                string query2 = "SELECT Name, StudentID, ContactNo, Email, Address FROM Voters WHERE Email = @Email";
                                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                                {
                                    cmd2.Parameters.AddWithValue("@Email", txtUsername.Text.Trim());
                                    SqlDataReader reader = cmd2.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        // Load voter data into the application
                                        string voterName = reader["Name"].ToString();
                                        // Process other voter information as needed
                                    }
                                }

                                VoterMain voterMain = new VoterMain();
                                voterMain.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}