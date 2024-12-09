using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Voters
{
    public partial class Vote : UserControl
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void Vote_Load(object sender, EventArgs e)
        {
            LoadCandidates();
            AttachRadioButtonEvents();


        }

        private void LoadCandidates()
        {
            string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Load candidates from the database
                    string query = "SELECT Name, Position FROM Candidate";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string candidateName = reader["Name"].ToString();
                        string position = reader["Position"].ToString();

                        // Dynamically assign candidates to the radio buttons based on position
                        if (position == "President")
                        {
                            if (radioPresident1.Text == "1")
                                radioPresident1.Text = candidateName;
                            else if (radioPresident2.Text == "2")
                                radioPresident2.Text = candidateName;
                            else if (radioPresident3.Text == "3")
                                radioPresident3.Text = candidateName;
                        }
                        else if (position == "Vice President")
                        {
                            if (radioVicePresident1.Text == "4")
                                radioVicePresident1.Text = candidateName;
                            else if (radioVicePresident2.Text == "5")
                                radioVicePresident2.Text = candidateName;
                            else if (radioVicePresident3.Text == "6")
                                radioVicePresident3.Text = candidateName;
                        }
                        else if (position == "Secretary")
                        {
                            if (radioSecretary1.Text == "7")
                                radioSecretary1.Text = candidateName;
                            else if (radioSecretary2.Text == "8")
                                radioSecretary2.Text = candidateName;
                            else if (radioSecretary3.Text == "9")
                                radioSecretary3.Text = candidateName;
                        }
                        else if (position == "Treasurer")
                        {
                            if (radioTreasurer1.Text == "10")
                                radioTreasurer1.Text = candidateName;
                            else if (radioTreasurer2.Text == "11")
                                radioTreasurer2.Text = candidateName;
                            else if (radioTreasurer3.Text == "12")
                                radioTreasurer3.Text = candidateName;
                        }
                        else if (position == "Auditor")
                        {
                            if (radioAuditor1.Text == "13")
                                radioAuditor1.Text = candidateName;
                            else if (radioAuditor2.Text == "14")
                                radioAuditor2.Text = candidateName;
                            else if (radioAuditor3.Text == "15")
                                radioAuditor3.Text = candidateName;
                        }
                        else if (position == "PRO")
                        {
                            if (radioPRO1.Text == "16")
                                radioPRO1.Text = candidateName;
                            else if (radioPRO2.Text == "17")
                                radioPRO2.Text = candidateName;
                            else if (radioPRO3.Text == "18")
                                radioPRO3.Text = candidateName;
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading candidates: " + ex.Message);
                }
            }
        }

        private void AttachRadioButtonEvents()
        {
            AttachEventsToGroupBox(gpPresident, lblPress);
            AttachEventsToGroupBox(gpVicePresident, lblVicePresident);
            AttachEventsToGroupBox(gpSecretary, lblSecretary);
            AttachEventsToGroupBox(gpTreasurer, lblTreasurer);
            AttachEventsToGroupBox(gpAuditor, lblAuditor);
            AttachEventsToGroupBox(gpPRO, lblPRO);
        }

        private void AttachEventsToGroupBox(GroupBox groupBox, Label labelToUpdate)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += (sender, e) =>
                    {
                        if (radioButton.Checked)
                        {
                            labelToUpdate.Text = radioButton.Text;
                        }
                    };
                }
            }
        }

        private void btnSubmitVote_Click(object sender, EventArgs e)
        {
            string selectedPresident = lblPress.Text;
            string selectedVicePresident = lblVicePresident.Text;
            string selectedSecretary = lblSecretary.Text;
            string selectedTreasurer = lblTreasurer.Text;
            string selectedAuditor = lblAuditor.Text;
            string selectedPRO = lblPRO.Text;

            if (selectedPresident == "[Select]" || selectedVicePresident == "[Select]" ||
                selectedSecretary == "[Select]" || selectedTreasurer == "[Select]" ||
                selectedAuditor == "[Select]" || selectedPRO == "[Select]")
            {
                MessageBox.Show("Please complete all selections before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Votes (President, VicePresident, Secretary, Treasurer, Auditor, PRO) " +
                                   "VALUES (@President, @VicePresident, @Secretary, @Treasurer, @Auditor, @PRO)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@President", selectedPresident);
                        command.Parameters.AddWithValue("@VicePresident", selectedVicePresident);
                        command.Parameters.AddWithValue("@Secretary", selectedSecretary);
                        command.Parameters.AddWithValue("@Treasurer", selectedTreasurer);
                        command.Parameters.AddWithValue("@Auditor", selectedAuditor);
                        command.Parameters.AddWithValue("@PRO", selectedPRO);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vote Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("There was an issue submitting your vote.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting vote: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearVote_Click(object sender, EventArgs e)
        {
            ClearGroupBoxSelections(gpPresident );
            ClearGroupBoxSelections(gpVicePresident);
            ClearGroupBoxSelections(gpSecretary);
            ClearGroupBoxSelections(gpTreasurer);
            ClearGroupBoxSelections(gpAuditor);
            ClearGroupBoxSelections(gpPRO);

            lblPress.Text = "[Select]";
            lblVicePresident.Text = "[Select]";
            lblSecretary.Text = "[Select]";
            lblTreasurer.Text = "[Select]";
            lblAuditor.Text = "[Select]";
            lblPRO.Text = "[Select]";
        }

        private void ClearGroupBoxSelections(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void btnClearVote_Click_1(object sender, EventArgs e)
        {
                        ClearGroupBoxSelections(gpPresident );
            ClearGroupBoxSelections(gpVicePresident);
            ClearGroupBoxSelections(gpSecretary);
            ClearGroupBoxSelections(gpTreasurer);
            ClearGroupBoxSelections(gpAuditor);
            ClearGroupBoxSelections(gpPRO);

            lblPress.Text = "[Select]";
            lblVicePresident.Text = "[Select]";
            lblSecretary.Text = "[Select]";
            lblTreasurer.Text = "[Select]";
            lblAuditor.Text = "[Select]";
            lblPRO.Text = "[Select]";
        }
    }
}
