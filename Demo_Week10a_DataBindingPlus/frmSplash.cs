using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Week10a_DataBindingPlus
{
    public partial class frmSplash : Form
    {

        private frmStudent frmS;
        public frmSplash(frmStudent frm)
        {
            InitializeComponent();
            frmS = frm;           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmS.Show();
            this.Close();
        }
    }
}
