namespace AutomatedVotingSystem1.Resources.Admin
{
    partial class Voters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtvName = new System.Windows.Forms.TextBox();
            this.txtvStudentID = new System.Windows.Forms.TextBox();
            this.txtvContactNo = new System.Windows.Forms.TextBox();
            this.txtvEmail = new System.Windows.Forms.TextBox();
            this.txtvAddress = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.datagridVoters = new System.Windows.Forms.DataGridView();
            this.voterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automatedVotingSystemDataSet7 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet7();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automatedVotingSystemDataSet6 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet6();
            this.panel1 = new System.Windows.Forms.Panel();
            this.votersTableAdapter = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet6TableAdapters.VotersTableAdapter();
            this.votersTableAdapter1 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet7TableAdapters.VotersTableAdapter();
            this.txtvPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtvConfirmPass = new System.Windows.Forms.TextBox();
            this.automatedVotingSystemDataSet8 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet8();
            this.votersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter2 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet8TableAdapters.VotersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVoters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(455, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Voters";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(591, 197);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 31);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtvName
            // 
            this.txtvName.BackColor = System.Drawing.Color.White;
            this.txtvName.Location = new System.Drawing.Point(161, 30);
            this.txtvName.Name = "txtvName";
            this.txtvName.Size = new System.Drawing.Size(180, 20);
            this.txtvName.TabIndex = 7;
            // 
            // txtvStudentID
            // 
            this.txtvStudentID.BackColor = System.Drawing.Color.White;
            this.txtvStudentID.Location = new System.Drawing.Point(161, 64);
            this.txtvStudentID.Name = "txtvStudentID";
            this.txtvStudentID.Size = new System.Drawing.Size(180, 20);
            this.txtvStudentID.TabIndex = 8;
            // 
            // txtvContactNo
            // 
            this.txtvContactNo.BackColor = System.Drawing.Color.White;
            this.txtvContactNo.Location = new System.Drawing.Point(161, 98);
            this.txtvContactNo.Name = "txtvContactNo";
            this.txtvContactNo.Size = new System.Drawing.Size(180, 20);
            this.txtvContactNo.TabIndex = 9;
            // 
            // txtvEmail
            // 
            this.txtvEmail.BackColor = System.Drawing.Color.White;
            this.txtvEmail.Location = new System.Drawing.Point(504, 30);
            this.txtvEmail.Name = "txtvEmail";
            this.txtvEmail.Size = new System.Drawing.Size(180, 20);
            this.txtvEmail.TabIndex = 10;
            // 
            // txtvAddress
            // 
            this.txtvAddress.BackColor = System.Drawing.Color.White;
            this.txtvAddress.Location = new System.Drawing.Point(161, 133);
            this.txtvAddress.Name = "txtvAddress";
            this.txtvAddress.Size = new System.Drawing.Size(180, 20);
            this.txtvAddress.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(685, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // datagridVoters
            // 
            this.datagridVoters.AutoGenerateColumns = false;
            this.datagridVoters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.datagridVoters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVoters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voterIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.datagridVoters.DataSource = this.votersBindingSource2;
            this.datagridVoters.Location = new System.Drawing.Point(107, 294);
            this.datagridVoters.Name = "datagridVoters";
            this.datagridVoters.Size = new System.Drawing.Size(640, 256);
            this.datagridVoters.TabIndex = 13;
            // 
            // voterIDDataGridViewTextBoxColumn
            // 
            this.voterIDDataGridViewTextBoxColumn.DataPropertyName = "VoterID";
            this.voterIDDataGridViewTextBoxColumn.HeaderText = "VoterID";
            this.voterIDDataGridViewTextBoxColumn.Name = "voterIDDataGridViewTextBoxColumn";
            this.voterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // votersBindingSource1
            // 
            this.votersBindingSource1.DataMember = "Voters";
            this.votersBindingSource1.DataSource = this.automatedVotingSystemDataSet7;
            // 
            // automatedVotingSystemDataSet7
            // 
            this.automatedVotingSystemDataSet7.DataSetName = "AutomatedVotingSystemDataSet7";
            this.automatedVotingSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "Voters";
            this.votersBindingSource.DataSource = this.automatedVotingSystemDataSet6;
            // 
            // automatedVotingSystemDataSet6
            // 
            this.automatedVotingSystemDataSet6.DataSetName = "AutomatedVotingSystemDataSet6";
            this.automatedVotingSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.lbl12);
            this.panel1.Controls.Add(this.txtvConfirmPass);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtvPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtvAddress);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtvContactNo);
            this.panel1.Controls.Add(this.txtvEmail);
            this.panel1.Controls.Add(this.txtvStudentID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtvName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(48, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 240);
            this.panel1.TabIndex = 14;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // votersTableAdapter1
            // 
            this.votersTableAdapter1.ClearBeforeFill = true;
            // 
            // txtvPassword
            // 
            this.txtvPassword.BackColor = System.Drawing.Color.White;
            this.txtvPassword.Location = new System.Drawing.Point(504, 66);
            this.txtvPassword.Name = "txtvPassword";
            this.txtvPassword.Size = new System.Drawing.Size(180, 20);
            this.txtvPassword.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(429, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Password:";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.White;
            this.lbl12.Location = new System.Drawing.Point(377, 101);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(121, 17);
            this.lbl12.TabIndex = 16;
            this.lbl12.Text = "Confirm Password:";
            // 
            // txtvConfirmPass
            // 
            this.txtvConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtvConfirmPass.Location = new System.Drawing.Point(504, 99);
            this.txtvConfirmPass.Name = "txtvConfirmPass";
            this.txtvConfirmPass.Size = new System.Drawing.Size(180, 20);
            this.txtvConfirmPass.TabIndex = 15;
            // 
            // automatedVotingSystemDataSet8
            // 
            this.automatedVotingSystemDataSet8.DataSetName = "AutomatedVotingSystemDataSet8";
            this.automatedVotingSystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource2
            // 
            this.votersBindingSource2.DataMember = "Voters";
            this.votersBindingSource2.DataSource = this.automatedVotingSystemDataSet8;
            // 
            // votersTableAdapter2
            // 
            this.votersTableAdapter2.ClearBeforeFill = true;
            // 
            // Voters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.datagridVoters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Voters";
            this.Size = new System.Drawing.Size(937, 573);
            this.Load += new System.EventHandler(this.Voters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridVoters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtvName;
        private System.Windows.Forms.TextBox txtvStudentID;
        private System.Windows.Forms.TextBox txtvContactNo;
        private System.Windows.Forms.TextBox txtvEmail;
        private System.Windows.Forms.TextBox txtvAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView datagridVoters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private AutomatedVotingSystemDataSet6 automatedVotingSystemDataSet6;
        private AutomatedVotingSystemDataSet6TableAdapters.VotersTableAdapter votersTableAdapter;
        private System.Windows.Forms.BindingSource votersBindingSource1;
        private AutomatedVotingSystemDataSet7 automatedVotingSystemDataSet7;
        private AutomatedVotingSystemDataSet7TableAdapters.VotersTableAdapter votersTableAdapter1;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox txtvConfirmPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtvPassword;
        private System.Windows.Forms.BindingSource votersBindingSource2;
        private AutomatedVotingSystemDataSet8 automatedVotingSystemDataSet8;
        private AutomatedVotingSystemDataSet8TableAdapters.VotersTableAdapter votersTableAdapter2;
    }
}
