/* *****************************
* Title:   In Class Activity 3
* Author:  Kirtan Patel
* Date:    November 22, 2024
* Purpose: Sportleagues Team Info Application
* ***************************** */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Class_3
{
    /// <summary>
    /// main class
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Initializes a new instance
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        private Dictionary<int, Panel> teamPanels;
        #region Form Load Event

        /// <summary>
        /// Form Load Event that loads data into datagridview and combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleaguesDataSet11.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.sportleaguesDataSet11.DataTable1);
            // TODO: This line of code loads data into the 'sportleaguesDataSet1.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet1.teams);
        }
        #endregion

        #region ComboBox Event Handler
        /// <summary>
        /// Handles the Combobox Index change event each time a team is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeams.SelectedIndex != -1)
            {
                try
                {
                    int teamvalue = int.Parse(cmbTeams.SelectedValue.ToString());
                    this.dataTable1TableAdapter.fillByTeam(this.sportleaguesDataSet11.DataTable1, teamvalue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        #endregion
    }   
}