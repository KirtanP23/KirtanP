namespace Assignment_5
{
    partial class frmLogin
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassKey = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassKey = new System.Windows.Forms.MaskedTextBox();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblHere = new System.Windows.Forms.Label();
            this.lblTitleLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(220, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 28);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email : ";
            // 
            // lblPassKey
            // 
            this.lblPassKey.AutoSize = true;
            this.lblPassKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassKey.Location = new System.Drawing.Point(196, 264);
            this.lblPassKey.Name = "lblPassKey";
            this.lblPassKey.Size = new System.Drawing.Size(105, 28);
            this.lblPassKey.TabIndex = 1;
            this.lblPassKey.Text = "PassKey : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(307, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(223, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(386, 488);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(367, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassKey
            // 
            this.txtPassKey.Location = new System.Drawing.Point(307, 271);
            this.txtPassKey.Mask = "0000";
            this.txtPassKey.Name = "txtPassKey";
            this.txtPassKey.Size = new System.Drawing.Size(153, 22);
            this.txtPassKey.TabIndex = 2;
            this.txtPassKey.UseSystemPasswordChar = true;
            this.txtPassKey.ValidatingType = typeof(int);
            // 
            // lblDisp
            // 
            this.lblDisp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp.Location = new System.Drawing.Point(5, -5);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(756, 72);
            this.lblDisp.TabIndex = 7;
            this.lblDisp.Text = "WELCOME";
            this.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReg
            // 
            this.lblReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(75, 490);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(294, 40);
            this.lblReg.TabIndex = 8;
            this.lblReg.Text = "If you are New here, please ";
            // 
            // lblHere
            // 
            this.lblHere.AutoSize = true;
            this.lblHere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHere.Location = new System.Drawing.Point(485, 490);
            this.lblHere.Name = "lblHere";
            this.lblHere.Size = new System.Drawing.Size(54, 28);
            this.lblHere.TabIndex = 9;
            this.lblHere.Text = "here";
            // 
            // lblTitleLog
            // 
            this.lblTitleLog.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLog.Location = new System.Drawing.Point(7, 85);
            this.lblTitleLog.Name = "lblTitleLog";
            this.lblTitleLog.Size = new System.Drawing.Size(733, 62);
            this.lblTitleLog.TabIndex = 10;
            this.lblTitleLog.Text = "Please Enter your Credentials to Edit Reviews.";
            this.lblTitleLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(752, 603);
            this.Controls.Add(this.lblTitleLog);
            this.Controls.Add(this.lblHere);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.txtPassKey);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassKey);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassKey;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtPassKey;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblHere;
        private System.Windows.Forms.Label lblTitleLog;
    }
}