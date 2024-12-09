/*
 * Name : Kirtan Patel
 * Title : Login Form Editor
 * Purpose : Login Form file for assignment - 5
 * Date : 08 December 2024
 */

using Assignment_5.DBAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_5.DBAL.User;

namespace Assignment_5
{
    public partial class frmLogin : Form
    {
        #region Constructor

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Click Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Handle Login button click
            string email = txtEmail.Text;
            string passKeyInput = txtPassKey.Text;

            try
            {
                
                User loggedInUser = User.ValidateLogin(email, passKeyInput);

                if (!int.TryParse(txtPassKey.Text.Trim(), out int passKey) || txtPassKey.Text.Length != 4)
                {
                    MessageBox.Show("Please enter a valid 4-digit passkey.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User user = User.GetUser(email, passKey);

                if (user != null)
                {
                   
                    Session.CurrentUserID = user.UserID;

                    MessageBox.Show($"Welcome, {User.Session.CurrentUserName}!", "Login Successful");       //ChatGPT

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or passkey.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            frmRegister regFrm = new frmRegister();
            regFrm.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        #endregion
    }
}
