/* Title: frmMain file 
 * Name : Kirtan Patel (100925226)
 * Date: 17 November 2024
 * Purpose: Main Form File for Assignment - 4 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_4_File_IO
{
    public partial class frmMain : Form
    {
        #region Fields

        private PlayerProfile profileToEdit;

        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash frm = new frmSplash(this);
            frm.ShowDialog();

            // Set up combo boxes with enum values
            cmbInputDevice.DataSource = Enum.GetValues(typeof(InputDevice));
            cmbCameraPerspective.DataSource = Enum.GetValues(typeof(CameraPerspective));

            // Load profiles into the profiles combo box
            LoadProfilesToComboBox();


            var profiles = Utilities.LoadProfiles();
            var defaultProfile = profiles.FirstOrDefault(p => p.IsDefault); //Chatgpt

            if (defaultProfile != null)
            {
                cmbProfiles.SelectedItem = defaultProfile.ProfileName;
                PopulateSettingsFromProfile(defaultProfile);
               
            }
        }

        #endregion

        #region TrackBar Scroll Events

        private void tkbSensitivity_Scroll(object sender, EventArgs e)
        {
            lblMouseSensitivity.Text = tkbSensitivity.Value.ToString();
        }

        private void tkbControllerSensi_Scroll(object sender, EventArgs e)
        {
            lblControllerSensitivity.Text = tkbControllerSensi.Value.ToString();
        }

        private void tkbBrightness_Scroll(object sender, EventArgs e)
        {
            lblTrackBght.Text = tkbBrightness.Value.ToString();
        }

        private void tkbMusicVolume_Scroll(object sender, EventArgs e)
        {
            lblVolume.Text = tkbMusicVolume.Value.ToString();
        }

        private void tkbSoundVolume_Scroll(object sender, EventArgs e)
        {
            lblSound.Text = tkbSoundVolume.Value.ToString();
        }

        private void tkbHudTransparency_Scroll(object sender, EventArgs e)
        {
            lblTransparencyHUD.Text = tkbHudTransparency.Value.ToString();
        }

        #endregion

        #region Checkbox Events

        private void cbxRayTracingOn_CheckedChanged(object sender, EventArgs e)
        {
            cbxUpscalingOn.Enabled = cbxRayTracingOn.Checked;
            cbxUpscalingOn.Checked = cbxRayTracingOn.Checked;
        }

        #endregion

        #region Profile Management

        private void LoadProfilesToComboBox()
        {
            try
            {
                var profiles = Utilities.LoadProfiles();
                cmbProfiles.Items.Clear();

                foreach (var profile in profiles)
                {
                    cmbProfiles.Items.Add(profile.ProfileName);
                }

                if (cmbProfiles.Items.Count > 0)
                {
                    cmbProfiles.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading profiles");
            }
        }

        private void PopulateSettingsFromProfile(PlayerProfile profile)
        {
            txtProfileName.Text = profile.ProfileName;
            cmbInputDevice.SelectedItem = profile.InputDevice;
            cbxAutoJumpOn.Checked = profile.AutoJump;
            tkbSensitivity.Value = profile.MouseSensitivity;
            lblMouseSensitivity.Text = profile.MouseSensitivity.ToString();
            tkbControllerSensi.Value = profile.ControllerSensitivity;
            lblControllerSensitivity.Text = profile.ControllerSensitivity.ToString();
            cbxInvertAxisOn.Checked = profile.InvertYAxis;
            tkbBrightness.Value = profile.Brightness;
            lblTrackBght.Text = profile.Brightness.ToString();
            cbxFancyGraphicsOn.Checked = profile.FancyGraphics;
            cbxVsyncOn.Checked = profile.VSync;
            cbxFullScreenOn.Checked = profile.Fullscreen;
            nudRenderDistance.Value = profile.RenderDistance;
            nudFieldofView.Value = profile.FieldOfView;
            cbxRayTracingOn.Checked = profile.RayTracing;
            cbxUpscalingOn.Checked = profile.Upscaling;
            tkbMusicVolume.Value = profile.MusicVolume;
            lblVolume.Text = profile.MusicVolume.ToString();
            tkbSoundVolume.Value = profile.SoundVolume;
            lblSound.Text = profile.SoundVolume.ToString();
            tkbHudTransparency.Value = profile.HUDTransparency;
            lblTransparencyHUD.Text = profile.HUDTransparency.ToString();
            cbxCoordinatesOn.Checked = profile.ShowCoordinates;
            cmbCameraPerspective.SelectedItem = profile.CameraPerspective;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var profile = new PlayerProfile(txtProfileName.Text)
            {
                InputDevice = (InputDevice)cmbInputDevice.SelectedItem,
                AutoJump = cbxAutoJumpOn.Checked,
                MouseSensitivity = tkbSensitivity.Value,
                ControllerSensitivity = tkbControllerSensi.Value,
                InvertYAxis = cbxInvertAxisOn.Checked,
                Brightness = tkbBrightness.Value,
                FancyGraphics = cbxFancyGraphicsOn.Checked,
                VSync = cbxVsyncOn.Checked,
                Fullscreen = cbxFullScreenOn.Checked,
                RenderDistance = (int)nudRenderDistance.Value,
                FieldOfView = (int)nudFieldofView.Value,
                RayTracing = cbxRayTracingOn.Checked,
                Upscaling = cbxUpscalingOn.Checked,
                MusicVolume = tkbMusicVolume.Value,
                SoundVolume = tkbSoundVolume.Value,
                HUDTransparency = tkbHudTransparency.Value,
                ShowCoordinates = cbxCoordinatesOn.Checked,
                CameraPerspective = (CameraPerspective)cmbCameraPerspective.SelectedItem
            };

            try
            {
                Utilities.SaveProfile(profile);
                LoadProfilesToComboBox();
                cmbProfiles.SelectedItem = profile.ProfileName;
                MessageBox.Show("Profile saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfiles.SelectedIndex != -1)
            {
                try
                {
                    var profiles = Utilities.LoadProfiles();
                    var selectedProfile = profiles.FirstOrDefault(p => p.ProfileName == cmbProfiles.SelectedItem.ToString());

                    if (selectedProfile != null)
                    {
                        PopulateSettingsFromProfile(selectedProfile);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a profile to load.", "Warning");
            }
        }

        #endregion

        #region Button Event Handlers

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            if (cmbProfiles.SelectedIndex != -1)
            {
                string selectedProfileName = cmbProfiles.SelectedItem.ToString();
                var profiles = Utilities.LoadProfiles();

                var selectedProfile = profiles.FirstOrDefault(p => p.ProfileName == selectedProfileName);
                if (selectedProfile != null)
                {
                    selectedProfile.IsDefault = true;
                    Utilities.SaveAllProfiles(profiles);
                    MessageBox.Show($"Profile '{selectedProfileName}' has been set as the default profile.", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a profile to set as default.", "Warning");
            }
        }
        #endregion
    }
}
