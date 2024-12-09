namespace AutomatedVotingSystem1.Resources.Admin
{
    partial class Electionwww
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
            this.dtgGenerateElect = new System.Windows.Forms.DataGridView();
            this.generateElectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automatedVotingSystemDataSet = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet();
            this.btngGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btngClear = new System.Windows.Forms.Button();
            this.cbgPosition = new System.Windows.Forms.ComboBox();
            this.txtgTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateElectionTableAdapter = new AutomatedVotingSystem1.AutomatedVotingSystemDataSetTableAdapters.GenerateElectionTableAdapter();
            this.electionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionsTableAdapter = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet3TableAdapters.ElectionsTableAdapter();
            this.automatedVotingSystemDataSet4 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet4();
            this.electionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electionsTableAdapter1 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet4TableAdapters.ElectionsTableAdapter();
            this.electionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGenerateElect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateElectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGenerateElect
            // 
            this.dtgGenerateElect.AutoGenerateColumns = false;
            this.dtgGenerateElect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.dtgGenerateElect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGenerateElect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.electionIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn});
            this.dtgGenerateElect.DataSource = this.generateElectionBindingSource;
            this.dtgGenerateElect.Location = new System.Drawing.Point(136, 268);
            this.dtgGenerateElect.Name = "dtgGenerateElect";
            this.dtgGenerateElect.Size = new System.Drawing.Size(544, 264);
            this.dtgGenerateElect.TabIndex = 0;
            // 
            // generateElectionBindingSource
            // 
            this.generateElectionBindingSource.DataMember = "GenerateElection";
            this.generateElectionBindingSource.DataSource = this.automatedVotingSystemDataSet;
            // 
            // automatedVotingSystemDataSet
            // 
            this.automatedVotingSystemDataSet.DataSetName = "AutomatedVotingSystemDataSet";
            this.automatedVotingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btngGenerate
            // 
            this.btngGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btngGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngGenerate.ForeColor = System.Drawing.Color.Black;
            this.btngGenerate.Location = new System.Drawing.Point(607, 198);
            this.btngGenerate.Name = "btngGenerate";
            this.btngGenerate.Size = new System.Drawing.Size(88, 31);
            this.btngGenerate.TabIndex = 4;
            this.btngGenerate.Text = "Generate";
            this.btngGenerate.UseVisualStyleBackColor = false;
            this.btngGenerate.Click += new System.EventHandler(this.btngGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "End Date-Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(597, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // btngClear
            // 
            this.btngClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.btngClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngClear.ForeColor = System.Drawing.Color.Black;
            this.btngClear.Location = new System.Drawing.Point(707, 198);
            this.btngClear.Name = "btngClear";
            this.btngClear.Size = new System.Drawing.Size(88, 31);
            this.btngClear.TabIndex = 38;
            this.btngClear.Text = "Clear";
            this.btngClear.UseVisualStyleBackColor = false;
            this.btngClear.Click += new System.EventHandler(this.btngClear_Click);
            // 
            // cbgPosition
            // 
            this.cbgPosition.FormattingEnabled = true;
            this.cbgPosition.Location = new System.Drawing.Point(188, 106);
            this.cbgPosition.Name = "cbgPosition";
            this.cbgPosition.Size = new System.Drawing.Size(106, 21);
            this.cbgPosition.TabIndex = 36;
            // 
            // txtgTitle
            // 
            this.txtgTitle.Location = new System.Drawing.Point(188, 72);
            this.txtgTitle.Name = "txtgTitle";
            this.txtgTitle.Size = new System.Drawing.Size(165, 20);
            this.txtgTitle.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Positions:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(454, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Start Date-Time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(86, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Election Title:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 30);
            this.label16.TabIndex = 31;
            this.label16.Text = "Generate Election";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(597, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cbgPosition);
            this.panel1.Controls.Add(this.txtgTitle);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(20, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 226);
            this.panel1.TabIndex = 42;
            // 
            // generateElectionTableAdapter
            // 
            this.generateElectionTableAdapter.ClearBeforeFill = true;
            // 
            // electionsTableAdapter
            // 
            this.electionsTableAdapter.ClearBeforeFill = true;
            // 
            // automatedVotingSystemDataSet4
            // 
            this.automatedVotingSystemDataSet4.DataSetName = "AutomatedVotingSystemDataSet4";
            this.automatedVotingSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // electionsBindingSource1
            // 
            this.electionsBindingSource1.DataMember = "Elections";
            this.electionsBindingSource1.DataSource = this.automatedVotingSystemDataSet4;
            // 
            // electionsTableAdapter1
            // 
            this.electionsTableAdapter1.ClearBeforeFill = true;
            // 
            // electionIDDataGridViewTextBoxColumn
            // 
            this.electionIDDataGridViewTextBoxColumn.DataPropertyName = "ElectionID";
            this.electionIDDataGridViewTextBoxColumn.HeaderText = "ElectionID";
            this.electionIDDataGridViewTextBoxColumn.Name = "electionIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // startDateTimeDataGridViewTextBoxColumn
            // 
            this.startDateTimeDataGridViewTextBoxColumn.DataPropertyName = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.HeaderText = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.Name = "startDateTimeDataGridViewTextBoxColumn";
            // 
            // endDateTimeDataGridViewTextBoxColumn
            // 
            this.endDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.HeaderText = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.Name = "endDateTimeDataGridViewTextBoxColumn";
            // 
            // Electionwww
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btngClear);
            this.Controls.Add(this.btngGenerate);
            this.Controls.Add(this.dtgGenerateElect);
            this.Controls.Add(this.panel1);
            this.Name = "Electionwww";
            this.Size = new System.Drawing.Size(936, 595);
            this.Load += new System.EventHandler(this.Election_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGenerateElect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateElectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGenerateElect;
        private System.Windows.Forms.Button btngGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btngClear;
        private System.Windows.Forms.ComboBox cbgPosition;
        private System.Windows.Forms.TextBox txtgTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource generateElectionBindingSource;
        private AutomatedVotingSystemDataSet automatedVotingSystemDataSet;
        private AutomatedVotingSystemDataSetTableAdapters.GenerateElectionTableAdapter generateElectionTableAdapter;
        private System.Windows.Forms.BindingSource electionsBindingSource;
        private AutomatedVotingSystemDataSet3TableAdapters.ElectionsTableAdapter electionsTableAdapter;
        private AutomatedVotingSystemDataSet4 automatedVotingSystemDataSet4;
        private System.Windows.Forms.BindingSource electionsBindingSource1;
        private AutomatedVotingSystemDataSet4TableAdapters.ElectionsTableAdapter electionsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn electionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
    }
}
