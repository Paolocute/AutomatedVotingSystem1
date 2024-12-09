namespace AutomatedVotingSystem1.Resources.Admin
{
    partial class ElectionResult
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
            this.cmbPositionResult = new System.Windows.Forms.ComboBox();
            this.datagridResult = new System.Windows.Forms.DataGridView();
            this.candidateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaVoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electionResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automatedVotingSystemDataSet11 = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet11();
            this.label2 = new System.Windows.Forms.Label();
            this.election_ResultTableAdapter = new AutomatedVotingSystem1.AutomatedVotingSystemDataSet11TableAdapters.Election_ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // cmbPositionResult
            // 
            this.cmbPositionResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionResult.FormattingEnabled = true;
            this.cmbPositionResult.Location = new System.Drawing.Point(85, 129);
            this.cmbPositionResult.Name = "cmbPositionResult";
            this.cmbPositionResult.Size = new System.Drawing.Size(161, 25);
            this.cmbPositionResult.TabIndex = 1;
            // 
            // datagridResult
            // 
            this.datagridResult.AutoGenerateColumns = false;
            this.datagridResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.datagridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totaVoteDataGridViewTextBoxColumn});
            this.datagridResult.DataSource = this.electionResultBindingSource;
            this.datagridResult.Location = new System.Drawing.Point(355, 78);
            this.datagridResult.Name = "datagridResult";
            this.datagridResult.Size = new System.Drawing.Size(546, 485);
            this.datagridResult.TabIndex = 2;
            // 
            // candidateIDDataGridViewTextBoxColumn
            // 
            this.candidateIDDataGridViewTextBoxColumn.DataPropertyName = "CandidateID";
            this.candidateIDDataGridViewTextBoxColumn.HeaderText = "CandidateID";
            this.candidateIDDataGridViewTextBoxColumn.Name = "candidateIDDataGridViewTextBoxColumn";
            this.candidateIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // totaVoteDataGridViewTextBoxColumn
            // 
            this.totaVoteDataGridViewTextBoxColumn.DataPropertyName = "Tota_Vote";
            this.totaVoteDataGridViewTextBoxColumn.HeaderText = "Tota_Vote";
            this.totaVoteDataGridViewTextBoxColumn.Name = "totaVoteDataGridViewTextBoxColumn";
            // 
            // electionResultBindingSource
            // 
            this.electionResultBindingSource.DataMember = "Election_Result";
            this.electionResultBindingSource.DataSource = this.automatedVotingSystemDataSet11;
            // 
            // automatedVotingSystemDataSet11
            // 
            this.automatedVotingSystemDataSet11.DataSetName = "AutomatedVotingSystemDataSet11";
            this.automatedVotingSystemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Election Result";
            // 
            // election_ResultTableAdapter
            // 
            this.election_ResultTableAdapter.ClearBeforeFill = true;
            // 
            // ElectionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridResult);
            this.Controls.Add(this.cmbPositionResult);
            this.Controls.Add(this.label1);
            this.Name = "ElectionResult";
            this.Size = new System.Drawing.Size(936, 595);
            this.Load += new System.EventHandler(this.ElectionResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automatedVotingSystemDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPositionResult;
        private System.Windows.Forms.DataGridView datagridResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaVoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource electionResultBindingSource;
        private AutomatedVotingSystemDataSet11 automatedVotingSystemDataSet11;
        private AutomatedVotingSystemDataSet11TableAdapters.Election_ResultTableAdapter election_ResultTableAdapter;
    }
}
