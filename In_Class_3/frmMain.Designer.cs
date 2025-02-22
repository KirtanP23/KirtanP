﻿namespace In_Class_3
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSet11 = new In_Class_3.SportleaguesDataSet1();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSet1 = new In_Class_3.SportleaguesDataSet1();
            this.teamsTableAdapter = new In_Class_3.SportleaguesDataSet1TableAdapters.teamsTableAdapter();
            this.dataTable1TableAdapter = new In_Class_3.SportleaguesDataSet1TableAdapters.DataTable1TableAdapter();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.jerseynumberDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn});
            this.dgvPlayers.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayers.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPlayers.Location = new System.Drawing.Point(282, 116);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.Size = new System.Drawing.Size(535, 420);
            this.dgvPlayers.TabIndex = 1;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "ID";
            this.regnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            this.regnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.regnumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // jerseynumberDataGridViewTextBoxColumn
            // 
            this.jerseynumberDataGridViewTextBoxColumn.DataPropertyName = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.HeaderText = "Shirt Number";
            this.jerseynumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jerseynumberDataGridViewTextBoxColumn.Name = "jerseynumberDataGridViewTextBoxColumn";
            this.jerseynumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.jerseynumberDataGridViewTextBoxColumn.Width = 65;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "Is Active";
            this.isactiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isactiveDataGridViewTextBoxColumn.Width = 65;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.sportleaguesDataSet11;
            // 
            // sportleaguesDataSet11
            // 
            this.sportleaguesDataSet11.DataSetName = "SportleaguesDataSet1";
            this.sportleaguesDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTeams
            // 
            this.cmbTeams.DataSource = this.teamsBindingSource;
            this.cmbTeams.DisplayMember = "teamname";
            this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(467, 64);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(292, 28);
            this.cmbTeams.TabIndex = 2;
            this.cmbTeams.ValueMember = "teamid";
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.sportleaguesDataSet1;
            // 
            // sportleaguesDataSet1
            // 
            this.sportleaguesDataSet1.DataSetName = "SportleaguesDataSet1";
            this.sportleaguesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamName.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.White;
            this.lblTeamName.Location = new System.Drawing.Point(316, 68);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(139, 21);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "Team Name : ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(2, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1060, 52);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Sportleagues Team Information Table";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::In_Class_3.Properties.Resources.field;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 550);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.dgvPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportLeagues Team info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPlayers;
        private SportleaguesDataSet1 sportleaguesDataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private SportleaguesDataSet1TableAdapters.teamsTableAdapter teamsTableAdapter;
        private SportleaguesDataSet1 sportleaguesDataSet11;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private SportleaguesDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label lblTitle;
    }
}

