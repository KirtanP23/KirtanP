/* *****************************
* Title:   Assinment_3 Splash Form File
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: Splash Screen for D&D Character Management
* ***************************** */

using System;
using System.Windows.Forms;

namespace Assignment_3
{
    /// <summary>
    /// Represents the splash screen of the application, displaying introductory information
    /// before transitioning to the main form.
    /// </summary>
    public partial class frmSplash : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSplash"/> class.
        /// </summary>
        public frmSplash()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the 'Start' button click event. Hides the splash screen and shows the main form.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Hide the Splash Screen form
            this.Hide();

            // Create and show the Main Form
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }

        /// <summary>
        /// Handles the 'About' button click event. Displays information about the application.
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Dungeons & Dragons Character Management App\n" +
                    "Developed by: Kirtan Patel\n" +
                    "Course: COSC2100\n" +
                    "Date: 20 October 2024",
                    "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
