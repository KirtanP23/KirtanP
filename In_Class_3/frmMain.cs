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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            panRangers.Visible = false; panBosna.Visible = false; panAurora.Visible = false;
            panEagles.Visible = false; panKickers.Visible = false; panStaffords.Visible = false;
            panStrikers.Visible = false;
        }
        private Dictionary<int, Panel> teamPanels;
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
            // TODO: This line of code loads data into the 'sportleaguesDataSet11.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.sportleaguesDataSet11.DataTable1);
            // TODO: This line of code loads data into the 'sportleaguesDataSet1.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet1.teams);

            teamPanels = new Dictionary<int, Panel>
            {
                { 210, panRangers },
                { 211, panBosna },
                { 212, panAurora },
                { 214, panKickers },
                { 215, panStrikers },
                { 216, panEagles },
                { 218, panStaffords },
            };
            foreach (var panel in teamPanels.Values)
            {
                panel.Visible = false;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeams.SelectedIndex != -1)
            {
                try
                {
                    int teamvalue = int.Parse(cmbTeams.SelectedValue.ToString());
                    ShowTeamLogo(teamvalue);
                    this.dataTable1TableAdapter.fillByTeam(this.sportleaguesDataSet11.DataTable1, teamvalue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        private void ShowTeamLogo(int teamId)
        {
            // Hide all panels
            foreach (var panel in teamPanels.Values)
            {
                panel.Visible = false;
            }

            // Show the correct panel if it exists in the dictionary
            if (teamPanels.ContainsKey(teamId))
            {
                teamPanels[teamId].Visible = true;
            }
            else
            {
                MessageBox.Show("No logo available for this team.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
