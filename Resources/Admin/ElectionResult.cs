using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Admin
{
    public partial class ElectionResult : UserControl
    {
        private string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";

        public ElectionResult()
        {
            InitializeComponent();
        }

        // This event is triggered when the UserControl is loaded
        private void ElectionResult_Load(object sender, EventArgs e)
        {
            LoadPosition(); // Load predefined and database-driven positions into the ComboBox
        }

        // Load positions into ComboBox
        private void LoadPosition()
        {
            cmbPositionResult.Items.Clear(); // Clear existing items before populating

            // Step 1: Manually add predefined positions
            cmbPositionResult.Items.Add("President");
            cmbPositionResult.Items.Add("Vice President");
            cmbPositionResult.Items.Add("Secretary");
            cmbPositionResult.Items.Add("Treasurer");
            cmbPositionResult.Items.Add("Auditor");
            cmbPositionResult.Items.Add("P.R.O");

            // Step 2: Fetch unique positions from the database
            FetchPositionsFromDatabase();

            // Select the first item by default (optional)
            if (cmbPositionResult.Items.Count > 0)
            {
                cmbPositionResult.SelectedIndex = 0; // Set default selection
            }
        }

        // Fetch unique positions from the database and add them to the ComboBox
        private void FetchPositionsFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Position FROM Candidate"; // Query to fetch unique positions
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string position = reader["Position"].ToString();
                            // Avoid adding duplicates (already manually defined positions)
                            if (!cmbPositionResult.Items.Contains(position))
                            {
                                cmbPositionResult.Items.Add(position);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading positions from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fetch and display results when a position is selected
        private void cmbPositionResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = cmbPositionResult.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPosition))
            {
                return; // No valid selection
            }

            // Fetch and display election results for the selected position
            FetchElectionResults(selectedPosition);
        }

        // Fetch and display election results for the selected position
        private void FetchElectionResults(string position)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        IDCandidate AS [CandidateID],
                                        Name AS [Candidate Name],
                                        Position,
                                        Date,
                                        Total_Vote AS [Total Votes]
                                     FROM Results 
                                     WHERE Position = @Position
                                     ORDER BY Total_Vote DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Position", position);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable resultsTable = new DataTable();
                        adapter.Fill(resultsTable);

                        // Bind the results to the DataGridView
                        datagridResult.DataSource = resultsTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching results: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
