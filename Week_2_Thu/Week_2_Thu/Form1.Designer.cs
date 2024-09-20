namespace Week_2_Thu
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
            this.mcaDate = new System.Windows.Forms.MonthCalendar();
            this.cboDateprog = new System.Windows.Forms.ComboBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mcaDate
            // 
            this.mcaDate.Location = new System.Drawing.Point(8, 9);
            this.mcaDate.Name = "mcaDate";
            this.mcaDate.TabIndex = 0;
            // 
            // cboDateprog
            // 
            this.cboDateprog.FormattingEnabled = true;
            this.cboDateprog.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboDateprog.Location = new System.Drawing.Point(334, 56);
            this.cboDateprog.Name = "cboDateprog";
            this.cboDateprog.Size = new System.Drawing.Size(200, 24);
            this.cboDateprog.TabIndex = 2;
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(334, 86);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(200, 24);
            this.cbo2.TabIndex = 3;
            this.cbo2.SelectedIndexChanged += new System.EventHandler(this.cbo2_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(334, 9);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 471);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.cboDateprog);
            this.Controls.Add(this.mcaDate);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIirtan\'s Themed Months";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcaDate;
        private System.Windows.Forms.ComboBox cboDateprog;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

