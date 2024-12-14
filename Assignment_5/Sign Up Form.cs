/*
 * Name : Kirtan Patel
 * Title : Sign Up Form File
 * Purpose : Sign Up Form file for assignment - 5
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

namespace Assignment_5
{
    public partial class frmRegister : Form
    {
        #region Constructor

        public frmRegister()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Click Events

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPasskey.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPasskey.Text.Trim(), out int passKey) || passKey < 1000 || passKey > 9999)
            {
                MessageBox.Show("PassKey must be a 4-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User(0, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), passKey);
            newUser.InsertUser();

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            frmMain mFrm = new frmMain();
            mFrm.ShowDialog();
        }

        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPasskey.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPasskey.Text.Trim(), out int passKey) || passKey < 1000 || passKey > 9999)
            {
                MessageBox.Show("PassKey must be a 4-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User(0, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), passKey);
            newUser.InsertUser();

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
