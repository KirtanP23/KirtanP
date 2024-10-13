using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
       

        #endregion

        #region Control Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
          


            
        }

        private void btnSellDroid_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
           colorDialogMain.ShowDialog();
            lblPrimaryColour.BackColor = colorDialogMain.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            lblSecondaryColour.BackColor = colorDialogMain.Color;
        }

        private void lboxDroids_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {   
            Droid tempDroid = new Droid();
            tempDroid.Designation = this.txtDesignation.Text.Trim();
            tempDroid.Owner = this.txtOwner.Text.Trim();
            tempDroid.IsInService = this.chkInService.Checked;
            tempDroid.PrimaryColor = this.lblPrimaryColour.BackColor;
            tempDroid.SecondaryColor = this.btnSecondaryColour.BackColor;

            Droid.droids.Add(tempDroid);
            PopulateDroidList();
        }
        #endregion

        #region Custom UI Functions and Methods
        private void PopulateDroidList()
        { 
            lboxDroids.Items.Clear();
            foreach (Droid droid in Droid.droids) 
            { 
                lboxDroids.Items.Add(droid.Designation);
            }
        }
        #endregion

       
    }
}
