using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedVotingSystem1.Resources.Voters
{
    public partial class VoterDashboard : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (  
            int nLeft,
             int nTop,
             int nRigt,
             int nBottom,
             int nWidthEllipse,
             int nHeightEllipse 
          );
        public VoterDashboard()
        {
            InitializeComponent();
        }

        private void VoterDashboard_Load(object sender, EventArgs e)
        {
            btnPresident.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPresident.Width, btnPresident.Height, 30, 30));
            btnVicePres.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVicePres.Width, btnVicePres.Height, 30, 30));
            btnSecretary.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSecretary.Width, btnSecretary.Height, 30, 30));
            btnTreasurer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTreasurer.Width, btnTreasurer.Height, 30, 30));
            btnAuditor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAuditor.Width, btnAuditor.Height, 30, 30));
            btnPRO. Region =  Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPRO.Width, btnPRO.Height, 30, 30));

        }
    }
}
