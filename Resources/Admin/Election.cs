using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Admin
{
    public partial class Electionwww : UserControl
    {

        private string connectionString = "Data Source=WIN-7D2IAMHC3IG;Initial Catalog=AutomatedVotingSystem;Integrated Security=True;";
        public Electionwww()
        {
            InitializeComponent();
            LoadPositions();
            LoadElections();

        }

        private void LoadPositions()
        {
            cbgPosition.Items.Add("President");
            cbgPosition.Items.Add("Vice President");
            cbgPosition.Items.Add("Secretary");
            cbgPosition.Items.Add("Treasurer");
            cbgPosition.Items.Add("Auditor");
            cbgPosition.Items.Add("P.R.O");
        }
        private void Election_Load(object sender, EventArgs e)
        {


        }

        private void btngGenerate_Click(object sender, EventArgs e)
        {
            string title = txtgTitle.Text.Trim();
            string position = cbgPosition.Text;
            DateTime startDateTime = dateTimePicker2.Value;
            DateTime endDateTime = dateTimePicker1.Value;


            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDateTime >= endDateTime)
            {
                MessageBox.Show("Start date-time must be earlier than end date-time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Elections (Title, Position, StartDateTime, EndDateTime) VALUES (@Title, @Position, @StartDateTime, @EndDateTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@StartDateTime", startDateTime);
                cmd.Parameters.AddWithValue("@EndDateTime", endDateTime);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Election generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadElections();
        }


        private void btngClear_Click(object sender, EventArgs e)
        {
            txtgTitle.Clear();
            cbgPosition.SelectedIndex = -1;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
        }
        public void LoadElections()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ElectionID, Title, Position, StartDateTime, EndDateTime FROM Elections"; // Ensure column names match your database
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            dtgGenerateElect.DataSource = dt;
        }
    }
}
