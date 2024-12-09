namespace AutomatedVotingSystem1.Resources.Admin
{
    partial class MainDashboard
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
            this.btnElectResult = new System.Windows.Forms.Button();
            this.btnVoters = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnElection = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new AutomatedVotingSystem1.Resources.Admin.Dashboard();
            this.election1 = new AutomatedVotingSystem1.Resources.Admin.Electionwww();
            this.candidates1 = new AutomatedVotingSystem1.Resources.Admin.Candidates();
            this.voters1 = new AutomatedVotingSystem1.Resources.Admin.Voters();
            this.electionResult1 = new AutomatedVotingSystem1.Resources.Admin.ElectionResult();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnElectResult);
            this.panel1.Controls.Add(this.btnVoters);
            this.panel1.Controls.Add(this.btnCandidates);
            this.panel1.Controls.Add(this.btnElection);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 599);
            this.panel1.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(2)))), ((int)(((byte)(71)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(40, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 36);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnElectResult
            // 
            this.btnElectResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(54)))));
            this.btnElectResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectResult.ForeColor = System.Drawing.Color.White;
            this.btnElectResult.Location = new System.Drawing.Point(4, 377);
            this.btnElectResult.Name = "btnElectResult";
            this.btnElectResult.Size = new System.Drawing.Size(182, 45);
            this.btnElectResult.TabIndex = 7;
            this.btnElectResult.Text = "    Election Result";
            this.btnElectResult.UseVisualStyleBackColor = false;
            this.btnElectResult.Click += new System.EventHandler(this.btnElectResult_Click);
            // 
            // btnVoters
            // 
            this.btnVoters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(54)))));
            this.btnVoters.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoters.ForeColor = System.Drawing.Color.White;
            this.btnVoters.Location = new System.Drawing.Point(3, 326);
            this.btnVoters.Name = "btnVoters";
            this.btnVoters.Size = new System.Drawing.Size(183, 45);
            this.btnVoters.TabIndex = 6;
            this.btnVoters.Text = "Voters";
            this.btnVoters.UseVisualStyleBackColor = false;
            this.btnVoters.Click += new System.EventHandler(this.btnVoters_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.btnCandidates.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidates.ForeColor = System.Drawing.Color.White;
            this.btnCandidates.Location = new System.Drawing.Point(3, 275);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(183, 45);
            this.btnCandidates.TabIndex = 5;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = false;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnElection
            // 
            this.btnElection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.btnElection.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElection.ForeColor = System.Drawing.Color.White;
            this.btnElection.Location = new System.Drawing.Point(4, 224);
            this.btnElection.Name = "btnElection";
            this.btnElection.Size = new System.Drawing.Size(182, 45);
            this.btnElection.TabIndex = 4;
            this.btnElection.Text = "Election";
            this.btnElection.UseVisualStyleBackColor = false;
            this.btnElection.Click += new System.EventHandler(this.btnElection_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 173);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(183, 45);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomatedVotingSystem1.Properties.Resources.icons8_menu_30__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutomatedVotingSystem1.Properties.Resources.icons8_manager_50__1_;
            this.pictureBox2.Location = new System.Drawing.Point(59, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.dashboard1.Location = new System.Drawing.Point(188, -2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(936, 595);
            this.dashboard1.TabIndex = 4;
            // 
            // election1
            // 
            this.election1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.election1.Location = new System.Drawing.Point(188, -2);
            this.election1.Name = "election1";
            this.election1.Size = new System.Drawing.Size(936, 599);
            this.election1.TabIndex = 5;
            // 
            // candidates1
            // 
            this.candidates1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.candidates1.Location = new System.Drawing.Point(188, 0);
            this.candidates1.Name = "candidates1";
            this.candidates1.Size = new System.Drawing.Size(936, 597);
            this.candidates1.TabIndex = 6;
            // 
            // voters1
            // 
            this.voters1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.voters1.Location = new System.Drawing.Point(188, -2);
            this.voters1.Name = "voters1";
            this.voters1.Size = new System.Drawing.Size(937, 599);
            this.voters1.TabIndex = 7;
            // 
            // electionResult1
            // 
            this.electionResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.electionResult1.Location = new System.Drawing.Point(189, 0);
            this.electionResult1.Name = "electionResult1";
            this.electionResult1.Size = new System.Drawing.Size(936, 595);
            this.electionResult1.TabIndex = 8;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 595);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.election1);
            this.Controls.Add(this.candidates1);
            this.Controls.Add(this.voters1);
            this.Controls.Add(this.electionResult1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnElectResult;
        private System.Windows.Forms.Button btnVoters;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnElection;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Dashboard dashboard1;
        private Electionwww election1;
        private Candidates candidates1;
        private Voters voters1;
        private ElectionResult electionResult1;
    }
}