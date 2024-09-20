using System;
using System.Windows.Forms;

namespace Week_2_Thu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateControls();
        }

        private void PopulateControls()
        {
            PopulateMonths();

        }

        private void PopulateMonths()
        {
            String[] months = 
                { "Jan", "Feb", "Mar", "Apr", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            foreach (string month in months)
            {
                cboDateprog > CacheVirtualItemsEventArgs.Add(month);
            }
            }
        }
    }
}
