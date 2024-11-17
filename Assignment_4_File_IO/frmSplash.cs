/* Title: frmSplash.cs file 
 * Name : Kirtan Patel (100925226)
 * Date: 17 November 2024
 * Purpose: Splash Screen File for Assignment - 4 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_File_IO
{
    public partial class frmSplash : Form
    {
        private frmMain frmM;
        public frmSplash(frmMain frm)
        {
            InitializeComponent();
            frmM = frm;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Close();
        }
    }
}
