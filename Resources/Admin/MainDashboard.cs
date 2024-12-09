using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Admin
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            election1.Visible = false;
            candidates1.Visible = false;
            voters1.Visible = false;
            electionResult1.Visible = false;
            
            
        }

        private void btnElection_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            election1.Visible = true;
            candidates1.Visible = false;
            voters1.Visible = false;
            electionResult1.Visible = false;


        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            election1.Visible = false;
            candidates1.Visible = true;
            voters1.Visible = false;
            electionResult1.Visible = false;

        }

        private void btnVoters_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            election1.Visible = false;
            candidates1.Visible = false;
            voters1.Visible = true;
            electionResult1.Visible = false;

        }

        private void btnElectResult_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            election1.Visible = false;
            candidates1.Visible = false;
            voters1.Visible = false;
            electionResult1.Visible = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmResult == DialogResult.Yes)
            {
                this.Hide();


                LogIn login = new LogIn();
                login.ShowDialog();

      
            }
        }
    }
}
