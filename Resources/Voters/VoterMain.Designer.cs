namespace AutomatedVotingSystem1.Resources.Voters
{
    partial class VoterMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnCandidateInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voterDashboard1 = new AutomatedVotingSystem1.Resources.Voters.VoterDashboard();
            this.vote1 = new AutomatedVotingSystem1.Resources.Voters.Vote();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnVote);
            this.panel1.Controls.Add(this.btnCandidateInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 611);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(62, 432);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnVote
            // 
            this.btnVote.BackColor = System.Drawing.Color.Transparent;
            this.btnVote.Location = new System.Drawing.Point(40, 247);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(119, 35);
            this.btnVote.TabIndex = 2;
            this.btnVote.Text = "Vote ";
            this.btnVote.UseVisualStyleBackColor = false;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnCandidateInfo
            // 
            this.btnCandidateInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCandidateInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidateInfo.Location = new System.Drawing.Point(40, 183);
            this.btnCandidateInfo.Name = "btnCandidateInfo";
            this.btnCandidateInfo.Size = new System.Drawing.Size(119, 35);
            this.btnCandidateInfo.TabIndex = 1;
            this.btnCandidateInfo.Text = "Candidate Info";
            this.btnCandidateInfo.UseVisualStyleBackColor = false;
            this.btnCandidateInfo.Click += new System.EventHandler(this.btnCandidateInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomatedVotingSystem1.Properties.Resources.icons8_profile_picture_30;
            this.pictureBox1.Location = new System.Drawing.Point(78, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // voterDashboard1
            // 
            this.voterDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.voterDashboard1.Location = new System.Drawing.Point(218, -1);
            this.voterDashboard1.Name = "voterDashboard1";
            this.voterDashboard1.Size = new System.Drawing.Size(988, 612);
            this.voterDashboard1.TabIndex = 1;
            // 
            // vote1
            // 
            this.vote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.vote1.Location = new System.Drawing.Point(218, -10);
            this.vote1.Name = "vote1";
            this.vote1.Size = new System.Drawing.Size(988, 621);
            this.vote1.TabIndex = 2;
            // 
            // VoterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 610);
            this.Controls.Add(this.voterDashboard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vote1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoterMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterMain";
            this.Load += new System.EventHandler(this.VoterMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnCandidateInfo;
        private System.Windows.Forms.Button btnLogout;
        private VoterDashboard voterDashboard1;
        private Vote vote1;
    }
}