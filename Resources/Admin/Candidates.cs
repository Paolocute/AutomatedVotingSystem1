using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Admin
{
    public partial class Candidates : UserControl
    {
        private string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";

        public static Action<object, EventArgs> CandidateRegistered { get; internal set; }

        public Candidates()
        {
            InitializeComponent();
            LoadPositions();
            LoadCandidates();
        }

        private void LoadPositions()
        {
            // Add positions to ComboBox
            cbcPosition.Items.Add("President");
            cbcPosition.Items.Add("Vice President");
            cbcPosition.Items.Add("Secretary");
            cbcPosition.Items.Add("Treasurer");
            cbcPosition.Items.Add("Auditor");
            cbcPosition.Items.Add("P.R.O");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string studentID = txtcStudentID.Text.Trim();
            string name = txtcName.Text.Trim();
            string position = cbcPosition.SelectedItem?.ToString();
            string contactNumber = txtcContactNo.Text.Trim();
            string email = txtcEmail.Text.Trim();
            string address = txtcAddress.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please fill out all required fields (Student ID, Name, Position).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert candidate into the database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Candidate (StudentID, Name, Position, ContactNo, Email, Address)
                             VALUES (@StudentID, @Name, @Position, @ContactNo, @Email, @Address)";

                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Position", position);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);

                        // Execute query
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Candidate registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCandidates(); // Refresh DataGridView
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
            txtcStudentID.Clear();
            txtcName.Clear();
            cbcPosition.SelectedIndex = -1;
            txtcContactNo.Clear();
            txtcEmail.Clear();
            txtcAddress.Clear();
        }

        public void LoadCandidates()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Candidate"; // Query to fetch all candidates
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCandidates.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading candidates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCandidates.SelectedRows[0];
                string studentID = selectedRow.Cells["StudentID"].Value?.ToString();

                if (!string.IsNullOrEmpty(studentID))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this candidate?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                string query = "DELETE FROM Candidate WHERE CandidateID = @CandidateID";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Candidate deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCandidates(); // Refresh DataGridView
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while deleting candidate: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a candidate to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
