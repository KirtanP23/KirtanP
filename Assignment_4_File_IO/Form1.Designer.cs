namespace Assignment_4_File_IO
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tbpMovement = new System.Windows.Forms.TabPage();
            this.cbxInvertAxisOn = new System.Windows.Forms.CheckBox();
            this.cbxAutoJumpOn = new System.Windows.Forms.CheckBox();
            this.lblInvertyAxis = new System.Windows.Forms.Label();
            this.lblControllerSensitivity = new System.Windows.Forms.Label();
            this.tkbControllerSensi = new System.Windows.Forms.TrackBar();
            this.lblControllerSensi = new System.Windows.Forms.Label();
            this.lblMouseSensitivity = new System.Windows.Forms.Label();
            this.tkbSensitivity = new System.Windows.Forms.TrackBar();
            this.lblMouseSensi = new System.Windows.Forms.Label();
            this.lblAutoJump = new System.Windows.Forms.Label();
            this.lblInputDevice = new System.Windows.Forms.Label();
            this.cmbInputDevice = new System.Windows.Forms.ComboBox();
            this.tbpVideo = new System.Windows.Forms.TabPage();
            this.cbxUpscalingOn = new System.Windows.Forms.CheckBox();
            this.lblUpscaling = new System.Windows.Forms.Label();
            this.cbxRayTracingOn = new System.Windows.Forms.CheckBox();
            this.lblRayTracing = new System.Windows.Forms.Label();
            this.lblFieldofView = new System.Windows.Forms.Label();
            this.nudFieldofView = new System.Windows.Forms.NumericUpDown();
            this.nudRenderDistance = new System.Windows.Forms.NumericUpDown();
            this.lblRenderDistance = new System.Windows.Forms.Label();
            this.cbxFullScreenOn = new System.Windows.Forms.CheckBox();
            this.lblFullScreen = new System.Windows.Forms.Label();
            this.lblVSync = new System.Windows.Forms.Label();
            this.cbxVsyncOn = new System.Windows.Forms.CheckBox();
            this.cbxFancyGraphicsOn = new System.Windows.Forms.CheckBox();
            this.lblFancyGraphics = new System.Windows.Forms.Label();
            this.lblTrackBght = new System.Windows.Forms.Label();
            this.tkbBrightness = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.tbpAudio = new System.Windows.Forms.TabPage();
            this.lblSound = new System.Windows.Forms.Label();
            this.tkbSoundVolume = new System.Windows.Forms.TrackBar();
            this.lblSoundVolume = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tkbMusicVolume = new System.Windows.Forms.TrackBar();
            this.lblMusicVolume = new System.Windows.Forms.Label();
            this.tbpInterface = new System.Windows.Forms.TabPage();
            this.cmbCameraPerspective = new System.Windows.Forms.ComboBox();
            this.lblCameraPerspective = new System.Windows.Forms.Label();
            this.cbxCoordinatesOn = new System.Windows.Forms.CheckBox();
            this.lblShowCoordinates = new System.Windows.Forms.Label();
            this.lblTransparencyHUD = new System.Windows.Forms.Label();
            this.tkbHudTransparency = new System.Windows.Forms.TrackBar();
            this.lblHUDTransparency = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.cmbProfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.tbcSettings.SuspendLayout();
            this.tbpMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbControllerSensi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSensitivity)).BeginInit();
            this.tbpVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldofView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).BeginInit();
            this.tbpAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSoundVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMusicVolume)).BeginInit();
            this.tbpInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbHudTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tbpMovement);
            this.tbcSettings.Controls.Add(this.tbpVideo);
            this.tbcSettings.Controls.Add(this.tbpAudio);
            this.tbcSettings.Controls.Add(this.tbpInterface);
            this.tbcSettings.Location = new System.Drawing.Point(4, 75);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(1062, 481);
            this.tbcSettings.TabIndex = 0;
            // 
            // tbpMovement
            // 
            this.tbpMovement.Controls.Add(this.cbxInvertAxisOn);
            this.tbpMovement.Controls.Add(this.cbxAutoJumpOn);
            this.tbpMovement.Controls.Add(this.lblInvertyAxis);
            this.tbpMovement.Controls.Add(this.lblControllerSensitivity);
            this.tbpMovement.Controls.Add(this.tkbControllerSensi);
            this.tbpMovement.Controls.Add(this.lblControllerSensi);
            this.tbpMovement.Controls.Add(this.lblMouseSensitivity);
            this.tbpMovement.Controls.Add(this.tkbSensitivity);
            this.tbpMovement.Controls.Add(this.lblMouseSensi);
            this.tbpMovement.Controls.Add(this.lblAutoJump);
            this.tbpMovement.Controls.Add(this.lblInputDevice);
            this.tbpMovement.Controls.Add(this.cmbInputDevice);
            this.tbpMovement.Location = new System.Drawing.Point(4, 25);
            this.tbpMovement.Name = "tbpMovement";
            this.tbpMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMovement.Size = new System.Drawing.Size(1054, 452);
            this.tbpMovement.TabIndex = 1;
            this.tbpMovement.Text = "Movement";
            this.toolTip1.SetToolTip(this.tbpMovement, "Movement Menu");
            this.tbpMovement.UseVisualStyleBackColor = true;
            // 
            // cbxInvertAxisOn
            // 
            this.cbxInvertAxisOn.AutoSize = true;
            this.cbxInvertAxisOn.Location = new System.Drawing.Point(171, 240);
            this.cbxInvertAxisOn.Name = "cbxInvertAxisOn";
            this.cbxInvertAxisOn.Size = new System.Drawing.Size(46, 20);
            this.cbxInvertAxisOn.TabIndex = 14;
            this.cbxInvertAxisOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxInvertAxisOn, "Select to invert Y-Axis");
            this.cbxInvertAxisOn.UseVisualStyleBackColor = true;
            // 
            // cbxAutoJumpOn
            // 
            this.cbxAutoJumpOn.AutoSize = true;
            this.cbxAutoJumpOn.Checked = true;
            this.cbxAutoJumpOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoJumpOn.Location = new System.Drawing.Point(171, 76);
            this.cbxAutoJumpOn.Name = "cbxAutoJumpOn";
            this.cbxAutoJumpOn.Size = new System.Drawing.Size(46, 20);
            this.cbxAutoJumpOn.TabIndex = 12;
            this.cbxAutoJumpOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxAutoJumpOn, "Select if Autom Jump is On or Off");
            this.cbxAutoJumpOn.UseVisualStyleBackColor = true;
            // 
            // lblInvertyAxis
            // 
            this.lblInvertyAxis.AutoSize = true;
            this.lblInvertyAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertyAxis.Location = new System.Drawing.Point(20, 238);
            this.lblInvertyAxis.Name = "lblInvertyAxis";
            this.lblInvertyAxis.Size = new System.Drawing.Size(116, 20);
            this.lblInvertyAxis.TabIndex = 11;
            this.lblInvertyAxis.Text = "Invert Y-Axis";
            // 
            // lblControllerSensitivity
            // 
            this.lblControllerSensitivity.AutoSize = true;
            this.lblControllerSensitivity.Location = new System.Drawing.Point(342, 182);
            this.lblControllerSensitivity.Name = "lblControllerSensitivity";
            this.lblControllerSensitivity.Size = new System.Drawing.Size(21, 16);
            this.lblControllerSensitivity.TabIndex = 10;
            this.lblControllerSensitivity.Text = "50";
            // 
            // tkbControllerSensi
            // 
            this.tkbControllerSensi.AutoSize = false;
            this.tkbControllerSensi.BackColor = System.Drawing.Color.Silver;
            this.tkbControllerSensi.Location = new System.Drawing.Point(218, 178);
            this.tkbControllerSensi.Maximum = 70;
            this.tkbControllerSensi.Minimum = 30;
            this.tkbControllerSensi.Name = "tkbControllerSensi";
            this.tkbControllerSensi.Size = new System.Drawing.Size(104, 25);
            this.tkbControllerSensi.TabIndex = 9;
            this.tkbControllerSensi.TickFrequency = 5;
            this.toolTip1.SetToolTip(this.tkbControllerSensi, "Select Sensitivity for Controller");
            this.tkbControllerSensi.Value = 50;
            this.tkbControllerSensi.Scroll += new System.EventHandler(this.tkbControllerSensi_Scroll);
            // 
            // lblControllerSensi
            // 
            this.lblControllerSensi.AutoSize = true;
            this.lblControllerSensi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControllerSensi.Location = new System.Drawing.Point(6, 178);
            this.lblControllerSensi.Name = "lblControllerSensi";
            this.lblControllerSensi.Size = new System.Drawing.Size(187, 20);
            this.lblControllerSensi.TabIndex = 8;
            this.lblControllerSensi.Text = "Controller Senitivity :";
            // 
            // lblMouseSensitivity
            // 
            this.lblMouseSensitivity.AutoSize = true;
            this.lblMouseSensitivity.Location = new System.Drawing.Point(314, 128);
            this.lblMouseSensitivity.Name = "lblMouseSensitivity";
            this.lblMouseSensitivity.Size = new System.Drawing.Size(21, 16);
            this.lblMouseSensitivity.TabIndex = 7;
            this.lblMouseSensitivity.Text = "50";
            // 
            // tkbSensitivity
            // 
            this.tkbSensitivity.AutoSize = false;
            this.tkbSensitivity.BackColor = System.Drawing.Color.Silver;
            this.tkbSensitivity.Location = new System.Drawing.Point(191, 124);
            this.tkbSensitivity.Maximum = 70;
            this.tkbSensitivity.Minimum = 30;
            this.tkbSensitivity.Name = "tkbSensitivity";
            this.tkbSensitivity.Size = new System.Drawing.Size(104, 25);
            this.tkbSensitivity.TabIndex = 6;
            this.tkbSensitivity.TickFrequency = 5;
            this.toolTip1.SetToolTip(this.tkbSensitivity, "Select Sensitivity for Mouse");
            this.tkbSensitivity.Value = 50;
            this.tkbSensitivity.Scroll += new System.EventHandler(this.tkbSensitivity_Scroll);
            // 
            // lblMouseSensi
            // 
            this.lblMouseSensi.AutoSize = true;
            this.lblMouseSensi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseSensi.Location = new System.Drawing.Point(6, 124);
            this.lblMouseSensi.Name = "lblMouseSensi";
            this.lblMouseSensi.Size = new System.Drawing.Size(159, 20);
            this.lblMouseSensi.TabIndex = 5;
            this.lblMouseSensi.Text = "Mouse Senitivity :";
            // 
            // lblAutoJump
            // 
            this.lblAutoJump.AutoSize = true;
            this.lblAutoJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoJump.Location = new System.Drawing.Point(31, 74);
            this.lblAutoJump.Name = "lblAutoJump";
            this.lblAutoJump.Size = new System.Drawing.Size(110, 20);
            this.lblAutoJump.TabIndex = 2;
            this.lblAutoJump.Text = "Auto Jump :";
            // 
            // lblInputDevice
            // 
            this.lblInputDevice.AutoSize = true;
            this.lblInputDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDevice.Location = new System.Drawing.Point(20, 24);
            this.lblInputDevice.Name = "lblInputDevice";
            this.lblInputDevice.Size = new System.Drawing.Size(126, 20);
            this.lblInputDevice.TabIndex = 1;
            this.lblInputDevice.Text = "Input Device :";
            // 
            // cmbInputDevice
            // 
            this.cmbInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInputDevice.FormattingEnabled = true;
            this.cmbInputDevice.Location = new System.Drawing.Point(191, 20);
            this.cmbInputDevice.Name = "cmbInputDevice";
            this.cmbInputDevice.Size = new System.Drawing.Size(121, 24);
            this.cmbInputDevice.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbInputDevice, "Choose Inout Device Type");
            // 
            // tbpVideo
            // 
            this.tbpVideo.Controls.Add(this.cbxUpscalingOn);
            this.tbpVideo.Controls.Add(this.lblUpscaling);
            this.tbpVideo.Controls.Add(this.cbxRayTracingOn);
            this.tbpVideo.Controls.Add(this.lblRayTracing);
            this.tbpVideo.Controls.Add(this.lblFieldofView);
            this.tbpVideo.Controls.Add(this.nudFieldofView);
            this.tbpVideo.Controls.Add(this.nudRenderDistance);
            this.tbpVideo.Controls.Add(this.lblRenderDistance);
            this.tbpVideo.Controls.Add(this.cbxFullScreenOn);
            this.tbpVideo.Controls.Add(this.lblFullScreen);
            this.tbpVideo.Controls.Add(this.lblVSync);
            this.tbpVideo.Controls.Add(this.cbxVsyncOn);
            this.tbpVideo.Controls.Add(this.cbxFancyGraphicsOn);
            this.tbpVideo.Controls.Add(this.lblFancyGraphics);
            this.tbpVideo.Controls.Add(this.lblTrackBght);
            this.tbpVideo.Controls.Add(this.tkbBrightness);
            this.tbpVideo.Controls.Add(this.lblBrightness);
            this.tbpVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpVideo.Location = new System.Drawing.Point(4, 25);
            this.tbpVideo.Name = "tbpVideo";
            this.tbpVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVideo.Size = new System.Drawing.Size(1054, 452);
            this.tbpVideo.TabIndex = 2;
            this.tbpVideo.Text = "Video";
            this.toolTip1.SetToolTip(this.tbpVideo, "Video Menu");
            this.tbpVideo.UseVisualStyleBackColor = true;
            // 
            // cbxUpscalingOn
            // 
            this.cbxUpscalingOn.AutoSize = true;
            this.cbxUpscalingOn.Enabled = false;
            this.cbxUpscalingOn.Location = new System.Drawing.Point(120, 448);
            this.cbxUpscalingOn.Name = "cbxUpscalingOn";
            this.cbxUpscalingOn.Size = new System.Drawing.Size(55, 24);
            this.cbxUpscalingOn.TabIndex = 20;
            this.cbxUpscalingOn.Text = "On";
            this.cbxUpscalingOn.UseVisualStyleBackColor = true;
            // 
            // lblUpscaling
            // 
            this.lblUpscaling.AutoSize = true;
            this.lblUpscaling.Location = new System.Drawing.Point(40, 448);
            this.lblUpscaling.Name = "lblUpscaling";
            this.lblUpscaling.Size = new System.Drawing.Size(104, 20);
            this.lblUpscaling.TabIndex = 19;
            this.lblUpscaling.Text = "Upscaling :";
            // 
            // cbxRayTracingOn
            // 
            this.cbxRayTracingOn.AutoSize = true;
            this.cbxRayTracingOn.Location = new System.Drawing.Point(179, 395);
            this.cbxRayTracingOn.Name = "cbxRayTracingOn";
            this.cbxRayTracingOn.Size = new System.Drawing.Size(55, 24);
            this.cbxRayTracingOn.TabIndex = 17;
            this.cbxRayTracingOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxRayTracingOn, "Select to turn Ray Tracing");
            this.cbxRayTracingOn.UseVisualStyleBackColor = true;
            this.cbxRayTracingOn.CheckedChanged += new System.EventHandler(this.cbxRayTracingOn_CheckedChanged);
            // 
            // lblRayTracing
            // 
            this.lblRayTracing.AutoSize = true;
            this.lblRayTracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRayTracing.Location = new System.Drawing.Point(35, 395);
            this.lblRayTracing.Name = "lblRayTracing";
            this.lblRayTracing.Size = new System.Drawing.Size(122, 20);
            this.lblRayTracing.TabIndex = 16;
            this.lblRayTracing.Text = "Ray Tracing :";
            // 
            // lblFieldofView
            // 
            this.lblFieldofView.AutoSize = true;
            this.lblFieldofView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldofView.Location = new System.Drawing.Point(37, 334);
            this.lblFieldofView.Name = "lblFieldofView";
            this.lblFieldofView.Size = new System.Drawing.Size(130, 20);
            this.lblFieldofView.TabIndex = 15;
            this.lblFieldofView.Text = "Field of View :";
            // 
            // nudFieldofView
            // 
            this.nudFieldofView.Location = new System.Drawing.Point(209, 332);
            this.nudFieldofView.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudFieldofView.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFieldofView.Name = "nudFieldofView";
            this.nudFieldofView.Size = new System.Drawing.Size(90, 27);
            this.nudFieldofView.TabIndex = 14;
            this.toolTip1.SetToolTip(this.nudFieldofView, "Select Field of View");
            this.nudFieldofView.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // nudRenderDistance
            // 
            this.nudRenderDistance.Location = new System.Drawing.Point(209, 272);
            this.nudRenderDistance.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudRenderDistance.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRenderDistance.Name = "nudRenderDistance";
            this.nudRenderDistance.Size = new System.Drawing.Size(90, 27);
            this.nudRenderDistance.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nudRenderDistance, "Select Render Distance");
            this.nudRenderDistance.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblRenderDistance
            // 
            this.lblRenderDistance.AutoSize = true;
            this.lblRenderDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderDistance.Location = new System.Drawing.Point(18, 272);
            this.lblRenderDistance.Name = "lblRenderDistance";
            this.lblRenderDistance.Size = new System.Drawing.Size(162, 20);
            this.lblRenderDistance.TabIndex = 12;
            this.lblRenderDistance.Text = "Render Distance :";
            // 
            // cbxFullScreenOn
            // 
            this.cbxFullScreenOn.AutoSize = true;
            this.cbxFullScreenOn.Location = new System.Drawing.Point(159, 209);
            this.cbxFullScreenOn.Name = "cbxFullScreenOn";
            this.cbxFullScreenOn.Size = new System.Drawing.Size(55, 24);
            this.cbxFullScreenOn.TabIndex = 10;
            this.cbxFullScreenOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxFullScreenOn, "Select to toggle Fullscreen Mode");
            this.cbxFullScreenOn.UseVisualStyleBackColor = true;
            // 
            // lblFullScreen
            // 
            this.lblFullScreen.AutoSize = true;
            this.lblFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullScreen.Location = new System.Drawing.Point(18, 209);
            this.lblFullScreen.Name = "lblFullScreen";
            this.lblFullScreen.Size = new System.Drawing.Size(109, 20);
            this.lblFullScreen.TabIndex = 9;
            this.lblFullScreen.Text = "Fullscreen :";
            // 
            // lblVSync
            // 
            this.lblVSync.AutoSize = true;
            this.lblVSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVSync.Location = new System.Drawing.Point(18, 155);
            this.lblVSync.Name = "lblVSync";
            this.lblVSync.Size = new System.Drawing.Size(93, 20);
            this.lblVSync.TabIndex = 8;
            this.lblVSync.Text = "V - Sync :";
            // 
            // cbxVsyncOn
            // 
            this.cbxVsyncOn.AutoSize = true;
            this.cbxVsyncOn.Checked = true;
            this.cbxVsyncOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxVsyncOn.Location = new System.Drawing.Point(133, 155);
            this.cbxVsyncOn.Name = "cbxVsyncOn";
            this.cbxVsyncOn.Size = new System.Drawing.Size(55, 24);
            this.cbxVsyncOn.TabIndex = 6;
            this.cbxVsyncOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxVsyncOn, "Select to turn V-Sync");
            this.cbxVsyncOn.UseVisualStyleBackColor = true;
            // 
            // cbxFancyGraphicsOn
            // 
            this.cbxFancyGraphicsOn.AutoSize = true;
            this.cbxFancyGraphicsOn.Checked = true;
            this.cbxFancyGraphicsOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFancyGraphicsOn.Location = new System.Drawing.Point(191, 90);
            this.cbxFancyGraphicsOn.Name = "cbxFancyGraphicsOn";
            this.cbxFancyGraphicsOn.Size = new System.Drawing.Size(55, 24);
            this.cbxFancyGraphicsOn.TabIndex = 4;
            this.cbxFancyGraphicsOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxFancyGraphicsOn, "Select to turn Fancy Graphics");
            this.cbxFancyGraphicsOn.UseVisualStyleBackColor = true;
            // 
            // lblFancyGraphics
            // 
            this.lblFancyGraphics.AutoSize = true;
            this.lblFancyGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFancyGraphics.Location = new System.Drawing.Point(18, 90);
            this.lblFancyGraphics.Name = "lblFancyGraphics";
            this.lblFancyGraphics.Size = new System.Drawing.Size(153, 20);
            this.lblFancyGraphics.TabIndex = 3;
            this.lblFancyGraphics.Text = "Fancy Graphics :";
            // 
            // lblTrackBght
            // 
            this.lblTrackBght.AutoSize = true;
            this.lblTrackBght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackBght.Location = new System.Drawing.Point(272, 24);
            this.lblTrackBght.Name = "lblTrackBght";
            this.lblTrackBght.Size = new System.Drawing.Size(27, 20);
            this.lblTrackBght.TabIndex = 2;
            this.lblTrackBght.Text = "50";
            // 
            // tkbBrightness
            // 
            this.tkbBrightness.AutoSize = false;
            this.tkbBrightness.BackColor = System.Drawing.Color.Silver;
            this.tkbBrightness.Location = new System.Drawing.Point(162, 19);
            this.tkbBrightness.Maximum = 100;
            this.tkbBrightness.Name = "tkbBrightness";
            this.tkbBrightness.Size = new System.Drawing.Size(104, 25);
            this.tkbBrightness.TabIndex = 1;
            this.tkbBrightness.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.tkbBrightness, "Select Brightness");
            this.tkbBrightness.Value = 50;
            this.tkbBrightness.Scroll += new System.EventHandler(this.tkbBrightness_Scroll);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.Location = new System.Drawing.Point(18, 24);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(112, 20);
            this.lblBrightness.TabIndex = 0;
            this.lblBrightness.Text = "Brightness :";
            // 
            // tbpAudio
            // 
            this.tbpAudio.Controls.Add(this.lblSound);
            this.tbpAudio.Controls.Add(this.tkbSoundVolume);
            this.tbpAudio.Controls.Add(this.lblSoundVolume);
            this.tbpAudio.Controls.Add(this.lblVolume);
            this.tbpAudio.Controls.Add(this.tkbMusicVolume);
            this.tbpAudio.Controls.Add(this.lblMusicVolume);
            this.tbpAudio.Location = new System.Drawing.Point(4, 25);
            this.tbpAudio.Name = "tbpAudio";
            this.tbpAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAudio.Size = new System.Drawing.Size(1054, 452);
            this.tbpAudio.TabIndex = 3;
            this.tbpAudio.Text = "Audio";
            this.toolTip1.SetToolTip(this.tbpAudio, "Audio Menu");
            this.tbpAudio.UseVisualStyleBackColor = true;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(291, 115);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(28, 16);
            this.lblSound.TabIndex = 5;
            this.lblSound.Text = "100";
            // 
            // tkbSoundVolume
            // 
            this.tkbSoundVolume.AutoSize = false;
            this.tkbSoundVolume.BackColor = System.Drawing.Color.Silver;
            this.tkbSoundVolume.Location = new System.Drawing.Point(181, 111);
            this.tkbSoundVolume.Maximum = 100;
            this.tkbSoundVolume.Name = "tkbSoundVolume";
            this.tkbSoundVolume.Size = new System.Drawing.Size(104, 25);
            this.tkbSoundVolume.TabIndex = 4;
            this.tkbSoundVolume.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.tkbSoundVolume, "Select Sound Volume");
            this.tkbSoundVolume.Value = 100;
            this.tkbSoundVolume.Scroll += new System.EventHandler(this.tkbSoundVolume_Scroll);
            // 
            // lblSoundVolume
            // 
            this.lblSoundVolume.AutoSize = true;
            this.lblSoundVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundVolume.Location = new System.Drawing.Point(15, 111);
            this.lblSoundVolume.Name = "lblSoundVolume";
            this.lblSoundVolume.Size = new System.Drawing.Size(141, 20);
            this.lblSoundVolume.TabIndex = 3;
            this.lblSoundVolume.Text = "Sound Volume :";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(291, 32);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(28, 16);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "100";
            // 
            // tkbMusicVolume
            // 
            this.tkbMusicVolume.AutoSize = false;
            this.tkbMusicVolume.BackColor = System.Drawing.Color.Silver;
            this.tkbMusicVolume.Location = new System.Drawing.Point(181, 29);
            this.tkbMusicVolume.Maximum = 100;
            this.tkbMusicVolume.Name = "tkbMusicVolume";
            this.tkbMusicVolume.Size = new System.Drawing.Size(104, 25);
            this.tkbMusicVolume.TabIndex = 1;
            this.tkbMusicVolume.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.tkbMusicVolume, "Select Music Volume");
            this.tkbMusicVolume.Value = 100;
            this.tkbMusicVolume.Scroll += new System.EventHandler(this.tkbMusicVolume_Scroll);
            // 
            // lblMusicVolume
            // 
            this.lblMusicVolume.AutoSize = true;
            this.lblMusicVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicVolume.Location = new System.Drawing.Point(15, 29);
            this.lblMusicVolume.Name = "lblMusicVolume";
            this.lblMusicVolume.Size = new System.Drawing.Size(139, 20);
            this.lblMusicVolume.TabIndex = 0;
            this.lblMusicVolume.Text = "Music Volume :";
            // 
            // tbpInterface
            // 
            this.tbpInterface.Controls.Add(this.cmbCameraPerspective);
            this.tbpInterface.Controls.Add(this.lblCameraPerspective);
            this.tbpInterface.Controls.Add(this.cbxCoordinatesOn);
            this.tbpInterface.Controls.Add(this.lblShowCoordinates);
            this.tbpInterface.Controls.Add(this.lblTransparencyHUD);
            this.tbpInterface.Controls.Add(this.tkbHudTransparency);
            this.tbpInterface.Controls.Add(this.lblHUDTransparency);
            this.tbpInterface.Location = new System.Drawing.Point(4, 25);
            this.tbpInterface.Name = "tbpInterface";
            this.tbpInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInterface.Size = new System.Drawing.Size(1054, 452);
            this.tbpInterface.TabIndex = 4;
            this.tbpInterface.Text = "Interface";
            this.toolTip1.SetToolTip(this.tbpInterface, "Interface Menu");
            this.tbpInterface.UseVisualStyleBackColor = true;
            // 
            // cmbCameraPerspective
            // 
            this.cmbCameraPerspective.FormattingEnabled = true;
            this.cmbCameraPerspective.Location = new System.Drawing.Point(253, 170);
            this.cmbCameraPerspective.Name = "cmbCameraPerspective";
            this.cmbCameraPerspective.Size = new System.Drawing.Size(170, 24);
            this.cmbCameraPerspective.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmbCameraPerspective, "Choose from the Perspectives");
            // 
            // lblCameraPerspective
            // 
            this.lblCameraPerspective.AutoSize = true;
            this.lblCameraPerspective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraPerspective.Location = new System.Drawing.Point(24, 170);
            this.lblCameraPerspective.Name = "lblCameraPerspective";
            this.lblCameraPerspective.Size = new System.Drawing.Size(191, 20);
            this.lblCameraPerspective.TabIndex = 5;
            this.lblCameraPerspective.Text = "Camera Perspective :";
            // 
            // cbxCoordinatesOn
            // 
            this.cbxCoordinatesOn.AutoSize = true;
            this.cbxCoordinatesOn.Location = new System.Drawing.Point(236, 107);
            this.cbxCoordinatesOn.Name = "cbxCoordinatesOn";
            this.cbxCoordinatesOn.Size = new System.Drawing.Size(46, 20);
            this.cbxCoordinatesOn.TabIndex = 4;
            this.cbxCoordinatesOn.Text = "On";
            this.toolTip1.SetToolTip(this.cbxCoordinatesOn, "Select to show Coordinates");
            this.cbxCoordinatesOn.UseVisualStyleBackColor = true;
            // 
            // lblShowCoordinates
            // 
            this.lblShowCoordinates.AutoSize = true;
            this.lblShowCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCoordinates.Location = new System.Drawing.Point(38, 105);
            this.lblShowCoordinates.Name = "lblShowCoordinates";
            this.lblShowCoordinates.Size = new System.Drawing.Size(173, 20);
            this.lblShowCoordinates.TabIndex = 3;
            this.lblShowCoordinates.Text = "Show Coordinates :";
            // 
            // lblTransparencyHUD
            // 
            this.lblTransparencyHUD.AutoSize = true;
            this.lblTransparencyHUD.Location = new System.Drawing.Point(363, 33);
            this.lblTransparencyHUD.Name = "lblTransparencyHUD";
            this.lblTransparencyHUD.Size = new System.Drawing.Size(28, 16);
            this.lblTransparencyHUD.TabIndex = 2;
            this.lblTransparencyHUD.Text = "100";
            // 
            // tkbHudTransparency
            // 
            this.tkbHudTransparency.AutoSize = false;
            this.tkbHudTransparency.BackColor = System.Drawing.Color.Silver;
            this.tkbHudTransparency.Location = new System.Drawing.Point(253, 28);
            this.tkbHudTransparency.Maximum = 100;
            this.tkbHudTransparency.Minimum = 25;
            this.tkbHudTransparency.Name = "tkbHudTransparency";
            this.tkbHudTransparency.Size = new System.Drawing.Size(104, 25);
            this.tkbHudTransparency.TabIndex = 1;
            this.tkbHudTransparency.TickFrequency = 5;
            this.toolTip1.SetToolTip(this.tkbHudTransparency, "Select HUDD Transparency");
            this.tkbHudTransparency.Value = 100;
            this.tkbHudTransparency.Scroll += new System.EventHandler(this.tkbHudTransparency_Scroll);
            // 
            // lblHUDTransparency
            // 
            this.lblHUDTransparency.AutoSize = true;
            this.lblHUDTransparency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHUDTransparency.Location = new System.Drawing.Point(30, 33);
            this.lblHUDTransparency.Name = "lblHUDTransparency";
            this.lblHUDTransparency.Size = new System.Drawing.Size(182, 20);
            this.lblHUDTransparency.TabIndex = 0;
            this.lblHUDTransparency.Text = "HUD Transparency :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(74, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Click to Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(199, 30);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(172, 22);
            this.txtProfileName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtProfileName, "Enter Profile Name");
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(42, 31);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(120, 20);
            this.lblProfileName.TabIndex = 3;
            this.lblProfileName.Text = "Enter Name :";
            // 
            // cmbProfiles
            // 
            this.cmbProfiles.FormattingEnabled = true;
            this.cmbProfiles.Location = new System.Drawing.Point(915, 31);
            this.cmbProfiles.Name = "cmbProfiles";
            this.cmbProfiles.Size = new System.Drawing.Size(121, 24);
            this.cmbProfiles.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cmbProfiles, "Profiles Created");
            this.cmbProfiles.SelectedIndexChanged += new System.EventHandler(this.cmbProfiles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Created Profiles :";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(751, 558);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDefault.Location = new System.Drawing.Point(414, 558);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(168, 34);
            this.btnSetDefault.TabIndex = 8;
            this.btnSetDefault.Text = "Set As Default";
            this.toolTip1.SetToolTip(this.btnSetDefault, "Click to set this profile as Default");
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1071, 598);
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProfiles);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbcSettings);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Settings Editor";
            this.toolTip1.SetToolTip(this, "Mincraft Setting Editor");
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbcSettings.ResumeLayout(false);
            this.tbpMovement.ResumeLayout(false);
            this.tbpMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbControllerSensi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSensitivity)).EndInit();
            this.tbpVideo.ResumeLayout(false);
            this.tbpVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldofView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).EndInit();
            this.tbpAudio.ResumeLayout(false);
            this.tbpAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSoundVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMusicVolume)).EndInit();
            this.tbpInterface.ResumeLayout(false);
            this.tbpInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbHudTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tbpMovement;
        private System.Windows.Forms.TabPage tbpVideo;
        private System.Windows.Forms.TabPage tbpAudio;
        private System.Windows.Forms.TabPage tbpInterface;
        private System.Windows.Forms.ComboBox cmbInputDevice;
        private System.Windows.Forms.Label lblAutoJump;
        private System.Windows.Forms.Label lblInputDevice;
        private System.Windows.Forms.Label lblMouseSensi;
        private System.Windows.Forms.TrackBar tkbSensitivity;
        private System.Windows.Forms.Label lblMouseSensitivity;
        private System.Windows.Forms.Label lblControllerSensitivity;
        private System.Windows.Forms.TrackBar tkbControllerSensi;
        private System.Windows.Forms.Label lblControllerSensi;
        private System.Windows.Forms.Label lblInvertyAxis;
        private System.Windows.Forms.CheckBox cbxInvertAxisOn;
        private System.Windows.Forms.CheckBox cbxAutoJumpOn;
        private System.Windows.Forms.Label lblTrackBght;
        private System.Windows.Forms.TrackBar tkbBrightness;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.CheckBox cbxVsyncOn;
        private System.Windows.Forms.CheckBox cbxFancyGraphicsOn;
        private System.Windows.Forms.Label lblFancyGraphics;
        private System.Windows.Forms.NumericUpDown nudFieldofView;
        private System.Windows.Forms.NumericUpDown nudRenderDistance;
        private System.Windows.Forms.Label lblRenderDistance;
        private System.Windows.Forms.CheckBox cbxFullScreenOn;
        private System.Windows.Forms.Label lblFullScreen;
        private System.Windows.Forms.Label lblVSync;
        private System.Windows.Forms.Label lblRayTracing;
        private System.Windows.Forms.Label lblFieldofView;
        private System.Windows.Forms.CheckBox cbxUpscalingOn;
        private System.Windows.Forms.Label lblUpscaling;
        private System.Windows.Forms.CheckBox cbxRayTracingOn;
        private System.Windows.Forms.TrackBar tkbMusicVolume;
        private System.Windows.Forms.Label lblMusicVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.TrackBar tkbSoundVolume;
        private System.Windows.Forms.Label lblSoundVolume;
        private System.Windows.Forms.Label lblTransparencyHUD;
        private System.Windows.Forms.TrackBar tkbHudTransparency;
        private System.Windows.Forms.Label lblHUDTransparency;
        private System.Windows.Forms.CheckBox cbxCoordinatesOn;
        private System.Windows.Forms.Label lblShowCoordinates;
        private System.Windows.Forms.ComboBox cmbCameraPerspective;
        private System.Windows.Forms.Label lblCameraPerspective;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.ComboBox cmbProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSetDefault;
    }
}

