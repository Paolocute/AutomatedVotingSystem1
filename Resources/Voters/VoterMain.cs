using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Voters
{
    public partial class VoterMain : Form
    {
        public VoterMain()
        {
            InitializeComponent();
        }

        private void VoterMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCandidateInfo_Click(object sender, EventArgs e)
        {
            voterDashboard1.Visible = true;
            vote1.Visible = false;
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            voterDashboard1.Visible = false;
            vote1.Visible = true;
        }
    }
}
