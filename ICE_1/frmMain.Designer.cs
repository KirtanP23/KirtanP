




namespace InClass1
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnGuessTheNumber = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panGuessTheNumber = new System.Windows.Forms.Panel();
            this.nudGTNNumGuesses = new System.Windows.Forms.NumericUpDown();
            this.nudGTNRandomNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_GTN_Output = new System.Windows.Forms.Label();
            this.btn_GTN_Guess = new System.Windows.Forms.Button();
            this.gbx_GTN_Settings = new System.Windows.Forms.GroupBox();
            this.lblGTNMaximum = new System.Windows.Forms.Label();
            this.cbo_GTN_Difficulty = new System.Windows.Forms.ComboBox();
            this.lblGTNMaximumLabel = new System.Windows.Forms.Label();
            this.lbl_GTN_Difficulty = new System.Windows.Forms.Label();
            this.lblGTNMinimum = new System.Windows.Forms.Label();
            this.lblGTNMinimumLabel = new System.Windows.Forms.Label();
            this.lbl_GTN_Title = new System.Windows.Forms.Label();
            this.lblGuessedNumber = new System.Windows.Forms.Label();
            this.nudGuessedNumber = new System.Windows.Forms.NumericUpDown();
            this.panIceCream = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashBalance = new System.Windows.Forms.Label();
            this.txtCashBalance = new System.Windows.Forms.TextBox();
            this.btnFiftyDollarClick = new System.Windows.Forms.Button();
            this.btnTwentyDollarClick = new System.Windows.Forms.Button();
            this.btnTenDollarClick = new System.Windows.Forms.Button();
            this.btnDollarFiveClick = new System.Windows.Forms.Button();
            this.btnOneDollarClick = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtChangeDue = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstCurrentOrder = new System.Windows.Forms.ListBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblFlavor = new System.Windows.Forms.Label();
            this.lstIceCreamItems = new System.Windows.Forms.ListBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panMenu.SuspendLayout();
            this.panGuessTheNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNNumGuesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNRandomNumber)).BeginInit();
            this.gbx_GTN_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessedNumber)).BeginInit();
            this.panIceCream.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.Thistle;
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Controls.Add(this.btnGuessTheNumber);
            this.panMenu.Controls.Add(this.lblMenuTitle);
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(140, 685);
            this.panMenu.TabIndex = 0;
            // 
            // btnIceCream
            // 
            this.btnIceCream.Location = new System.Drawing.Point(9, 144);
            this.btnIceCream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(122, 49);
            this.btnIceCream.TabIndex = 2;
            this.btnIceCream.Text = "&Ice Cream";
            this.toolTips.SetToolTip(this.btnIceCream, "Click for Ice Cream Shop Sim");
            this.btnIceCream.UseVisualStyleBackColor = true;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // btnGuessTheNumber
            // 
            this.btnGuessTheNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuessTheNumber.Location = new System.Drawing.Point(9, 90);
            this.btnGuessTheNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuessTheNumber.Name = "btnGuessTheNumber";
            this.btnGuessTheNumber.Size = new System.Drawing.Size(122, 49);
            this.btnGuessTheNumber.TabIndex = 1;
            this.btnGuessTheNumber.Text = "&Guess The Number";
            this.toolTips.SetToolTip(this.btnGuessTheNumber, "Play Guess the Number game (alt-G)");
            this.btnGuessTheNumber.UseVisualStyleBackColor = true;
            this.btnGuessTheNumber.Click += new System.EventHandler(this.btnGuessTheNumber_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuTitle.Location = new System.Drawing.Point(6, 6);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(126, 78);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "My Little Games";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGuessTheNumber
            // 
            this.panGuessTheNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGuessTheNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panGuessTheNumber.Controls.Add(this.nudGTNNumGuesses);
            this.panGuessTheNumber.Controls.Add(this.nudGTNRandomNumber);
            this.panGuessTheNumber.Controls.Add(this.lbl_GTN_Output);
            this.panGuessTheNumber.Controls.Add(this.btn_GTN_Guess);
            this.panGuessTheNumber.Controls.Add(this.gbx_GTN_Settings);
            this.panGuessTheNumber.Controls.Add(this.lbl_GTN_Title);
            this.panGuessTheNumber.Controls.Add(this.lblGuessedNumber);
            this.panGuessTheNumber.Controls.Add(this.nudGuessedNumber);
            this.panGuessTheNumber.Location = new System.Drawing.Point(148, 6);
            this.panGuessTheNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panGuessTheNumber.Name = "panGuessTheNumber";
            this.panGuessTheNumber.Size = new System.Drawing.Size(713, 633);
            this.panGuessTheNumber.TabIndex = 1;
            // 
            // nudGTNNumGuesses
            // 
            this.nudGTNNumGuesses.Enabled = false;
            this.nudGTNNumGuesses.Location = new System.Drawing.Point(28, 285);
            this.nudGTNNumGuesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGTNNumGuesses.Name = "nudGTNNumGuesses";
            this.nudGTNNumGuesses.Size = new System.Drawing.Size(107, 22);
            this.nudGTNNumGuesses.TabIndex = 6;
            this.nudGTNNumGuesses.Visible = false;
            // 
            // nudGTNRandomNumber
            // 
            this.nudGTNRandomNumber.Location = new System.Drawing.Point(28, 259);
            this.nudGTNRandomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGTNRandomNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Name = "nudGTNRandomNumber";
            this.nudGTNRandomNumber.Size = new System.Drawing.Size(107, 22);
            this.nudGTNRandomNumber.TabIndex = 5;
            this.nudGTNRandomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Visible = false;
            // 
            // lbl_GTN_Output
            // 
            this.lbl_GTN_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GTN_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GTN_Output.Location = new System.Drawing.Point(14, 345);
            this.lbl_GTN_Output.Name = "lbl_GTN_Output";
            this.lbl_GTN_Output.Size = new System.Drawing.Size(678, 254);
            this.lbl_GTN_Output.TabIndex = 3;
            // 
            // btn_GTN_Guess
            // 
            this.btn_GTN_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GTN_Guess.Location = new System.Drawing.Point(140, 202);
            this.btn_GTN_Guess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GTN_Guess.Name = "btn_GTN_Guess";
            this.btn_GTN_Guess.Size = new System.Drawing.Size(159, 110);
            this.btn_GTN_Guess.TabIndex = 4;
            this.btn_GTN_Guess.Text = "Guess";
            this.btn_GTN_Guess.UseVisualStyleBackColor = true;
            this.btn_GTN_Guess.Click += new System.EventHandler(this.btn_GTN_Guess_Click);
            // 
            // gbx_GTN_Settings
            // 
            this.gbx_GTN_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMaximum);
            this.gbx_GTN_Settings.Controls.Add(this.cbo_GTN_Difficulty);
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMaximumLabel);
            this.gbx_GTN_Settings.Controls.Add(this.lbl_GTN_Difficulty);
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMinimum);
            this.gbx_GTN_Settings.Controls.Add(this.lblGTNMinimumLabel);
            this.gbx_GTN_Settings.Location = new System.Drawing.Point(20, 57);
            this.gbx_GTN_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_GTN_Settings.Name = "gbx_GTN_Settings";
            this.gbx_GTN_Settings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_GTN_Settings.Size = new System.Drawing.Size(678, 80);
            this.gbx_GTN_Settings.TabIndex = 3;
            this.gbx_GTN_Settings.TabStop = false;
            this.gbx_GTN_Settings.Text = "Settings";
            // 
            // lblGTNMaximum
            // 
            this.lblGTNMaximum.AutoSize = true;
            this.lblGTNMaximum.Location = new System.Drawing.Point(316, 42);
            this.lblGTNMaximum.Name = "lblGTNMaximum";
            this.lblGTNMaximum.Size = new System.Drawing.Size(21, 16);
            this.lblGTNMaximum.TabIndex = 8;
            this.lblGTNMaximum.Text = "10";
            // 
            // cbo_GTN_Difficulty
            // 
            this.cbo_GTN_Difficulty.FormattingEnabled = true;
            this.cbo_GTN_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbo_GTN_Difficulty.Location = new System.Drawing.Point(72, 24);
            this.cbo_GTN_Difficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_GTN_Difficulty.Name = "cbo_GTN_Difficulty";
            this.cbo_GTN_Difficulty.Size = new System.Drawing.Size(108, 24);
            this.cbo_GTN_Difficulty.TabIndex = 0;
            this.cbo_GTN_Difficulty.SelectedIndexChanged += new System.EventHandler(this.cbo_GTN_Difficulty_SelectedIndexChanged);
            // 
            // lblGTNMaximumLabel
            // 
            this.lblGTNMaximumLabel.AutoSize = true;
            this.lblGTNMaximumLabel.Location = new System.Drawing.Point(215, 42);
            this.lblGTNMaximumLabel.Name = "lblGTNMaximumLabel";
            this.lblGTNMaximumLabel.Size = new System.Drawing.Size(64, 16);
            this.lblGTNMaximumLabel.TabIndex = 7;
            this.lblGTNMaximumLabel.Text = "Maximum";
            // 
            // lbl_GTN_Difficulty
            // 
            this.lbl_GTN_Difficulty.AutoSize = true;
            this.lbl_GTN_Difficulty.Location = new System.Drawing.Point(5, 26);
            this.lbl_GTN_Difficulty.Name = "lbl_GTN_Difficulty";
            this.lbl_GTN_Difficulty.Size = new System.Drawing.Size(56, 16);
            this.lbl_GTN_Difficulty.TabIndex = 1;
            this.lbl_GTN_Difficulty.Text = "Difficulty";
            // 
            // lblGTNMinimum
            // 
            this.lblGTNMinimum.AutoSize = true;
            this.lblGTNMinimum.Location = new System.Drawing.Point(316, 18);
            this.lblGTNMinimum.Name = "lblGTNMinimum";
            this.lblGTNMinimum.Size = new System.Drawing.Size(14, 16);
            this.lblGTNMinimum.TabIndex = 6;
            this.lblGTNMinimum.Text = "1";
            // 
            // lblGTNMinimumLabel
            // 
            this.lblGTNMinimumLabel.AutoSize = true;
            this.lblGTNMinimumLabel.Location = new System.Drawing.Point(215, 18);
            this.lblGTNMinimumLabel.Name = "lblGTNMinimumLabel";
            this.lblGTNMinimumLabel.Size = new System.Drawing.Size(60, 16);
            this.lblGTNMinimumLabel.TabIndex = 5;
            this.lblGTNMinimumLabel.Text = "Minimum";
            // 
            // lbl_GTN_Title
            // 
            this.lbl_GTN_Title.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GTN_Title.Location = new System.Drawing.Point(12, 11);
            this.lbl_GTN_Title.Name = "lbl_GTN_Title";
            this.lbl_GTN_Title.Size = new System.Drawing.Size(281, 43);
            this.lbl_GTN_Title.TabIndex = 2;
            this.lbl_GTN_Title.Text = "Guess The Number";
            // 
            // lblGuessedNumber
            // 
            this.lblGuessedNumber.AutoSize = true;
            this.lblGuessedNumber.Location = new System.Drawing.Point(50, 162);
            this.lblGuessedNumber.Name = "lblGuessedNumber";
            this.lblGuessedNumber.Size = new System.Drawing.Size(108, 16);
            this.lblGuessedNumber.TabIndex = 1;
            this.lblGuessedNumber.Text = "Guess a Number";
            // 
            // nudGuessedNumber
            // 
            this.nudGuessedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuessedNumber.Location = new System.Drawing.Point(170, 152);
            this.nudGuessedNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGuessedNumber.Name = "nudGuessedNumber";
            this.nudGuessedNumber.Size = new System.Drawing.Size(96, 34);
            this.nudGuessedNumber.TabIndex = 0;
            // 
            // panIceCream
            // 
            this.panIceCream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panIceCream.AutoSize = true;
            this.panIceCream.BackColor = System.Drawing.Color.Silver;
            this.panIceCream.Controls.Add(this.label3);
            this.panIceCream.Controls.Add(this.label2);
            this.panIceCream.Controls.Add(this.label1);
            this.panIceCream.Controls.Add(this.lblCashBalance);
            this.panIceCream.Controls.Add(this.txtCashBalance);
            this.panIceCream.Controls.Add(this.btnFiftyDollarClick);
            this.panIceCream.Controls.Add(this.btnTwentyDollarClick);
            this.panIceCream.Controls.Add(this.btnTenDollarClick);
            this.panIceCream.Controls.Add(this.btnDollarFiveClick);
            this.panIceCream.Controls.Add(this.btnOneDollarClick);
            this.panIceCream.Controls.Add(this.lblChange);
            this.panIceCream.Controls.Add(this.lblTotal);
            this.panIceCream.Controls.Add(this.btnTotal);
            this.panIceCream.Controls.Add(this.txtChangeDue);
            this.panIceCream.Controls.Add(this.txtPayment);
            this.panIceCream.Controls.Add(this.btnRemoveFromOrder);
            this.panIceCream.Controls.Add(this.btnBuy);
            this.panIceCream.Controls.Add(this.lstCurrentOrder);
            this.panIceCream.Controls.Add(this.btnAddToOrder);
            this.panIceCream.Controls.Add(this.btnClear);
            this.panIceCream.Controls.Add(this.lblQty);
            this.panIceCream.Controls.Add(this.lblFlavor);
            this.panIceCream.Controls.Add(this.lstIceCreamItems);
            this.panIceCream.Controls.Add(this.nudQuantity);
            this.panIceCream.Location = new System.Drawing.Point(148, 6);
            this.panIceCream.Name = "panIceCream";
            this.panIceCream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panIceCream.Size = new System.Drawing.Size(713, 637);
            this.panIceCream.TabIndex = 7;
            this.toolTips.SetToolTip(this.panIceCream, "Ice Cream Shop Sim");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "TOTAL AND CHANGE DUE";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "CASH OPTIONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ICE CREAM SHOP";
            // 
            // lblCashBalance
            // 
            this.lblCashBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashBalance.Location = new System.Drawing.Point(562, 34);
            this.lblCashBalance.Name = "lblCashBalance";
            this.lblCashBalance.Size = new System.Drawing.Size(100, 23);
            this.lblCashBalance.TabIndex = 26;
            this.lblCashBalance.Text = "Cash Balance";
            // 
            // txtCashBalance
            // 
            this.txtCashBalance.Location = new System.Drawing.Point(565, 57);
            this.txtCashBalance.Multiline = true;
            this.txtCashBalance.Name = "txtCashBalance";
            this.txtCashBalance.ReadOnly = true;
            this.txtCashBalance.Size = new System.Drawing.Size(100, 22);
            this.txtCashBalance.TabIndex = 25;
            this.toolTips.SetToolTip(this.txtCashBalance, "Current Cash Balance");
            this.txtCashBalance.TextChanged += new System.EventHandler(this.txtCashBalance_TextChanged);
            // 
            // btnFiftyDollarClick
            // 
            this.btnFiftyDollarClick.BackColor = System.Drawing.Color.Red;
            this.btnFiftyDollarClick.Location = new System.Drawing.Point(554, 336);
            this.btnFiftyDollarClick.Name = "btnFiftyDollarClick";
            this.btnFiftyDollarClick.Size = new System.Drawing.Size(75, 37);
            this.btnFiftyDollarClick.TabIndex = 11;
            this.btnFiftyDollarClick.Text = "$&50";
            this.toolTips.SetToolTip(this.btnFiftyDollarClick, "Click for Fifty Dollar");
            this.btnFiftyDollarClick.UseVisualStyleBackColor = false;
            this.btnFiftyDollarClick.Click += new System.EventHandler(this.btnFiftyDollarClick_Click);
            // 
            // btnTwentyDollarClick
            // 
            this.btnTwentyDollarClick.BackColor = System.Drawing.Color.Green;
            this.btnTwentyDollarClick.Location = new System.Drawing.Point(408, 336);
            this.btnTwentyDollarClick.Name = "btnTwentyDollarClick";
            this.btnTwentyDollarClick.Size = new System.Drawing.Size(75, 37);
            this.btnTwentyDollarClick.TabIndex = 10;
            this.btnTwentyDollarClick.Text = "$&20";
            this.toolTips.SetToolTip(this.btnTwentyDollarClick, "Click for Twenty Dollar");
            this.btnTwentyDollarClick.UseVisualStyleBackColor = false;
            this.btnTwentyDollarClick.Click += new System.EventHandler(this.btnTwentyDollarClick_Click);
            // 
            // btnTenDollarClick
            // 
            this.btnTenDollarClick.BackColor = System.Drawing.Color.Violet;
            this.btnTenDollarClick.Location = new System.Drawing.Point(275, 336);
            this.btnTenDollarClick.Name = "btnTenDollarClick";
            this.btnTenDollarClick.Size = new System.Drawing.Size(75, 37);
            this.btnTenDollarClick.TabIndex = 9;
            this.btnTenDollarClick.Text = "$&10";
            this.toolTips.SetToolTip(this.btnTenDollarClick, "Click for Ten Dollar");
            this.btnTenDollarClick.UseVisualStyleBackColor = false;
            this.btnTenDollarClick.Click += new System.EventHandler(this.btnTenDollarClick_Click);
            // 
            // btnDollarFiveClick
            // 
            this.btnDollarFiveClick.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDollarFiveClick.Location = new System.Drawing.Point(153, 336);
            this.btnDollarFiveClick.Name = "btnDollarFiveClick";
            this.btnDollarFiveClick.Size = new System.Drawing.Size(75, 37);
            this.btnDollarFiveClick.TabIndex = 8;
            this.btnDollarFiveClick.Text = "$&5";
            this.toolTips.SetToolTip(this.btnDollarFiveClick, "Click for Five Dollar");
            this.btnDollarFiveClick.UseVisualStyleBackColor = false;
            this.btnDollarFiveClick.Click += new System.EventHandler(this.btnDollarFiveClick_Click);
            // 
            // btnOneDollarClick
            // 
            this.btnOneDollarClick.BackColor = System.Drawing.Color.SandyBrown;
            this.btnOneDollarClick.Location = new System.Drawing.Point(27, 336);
            this.btnOneDollarClick.Name = "btnOneDollarClick";
            this.btnOneDollarClick.Size = new System.Drawing.Size(75, 37);
            this.btnOneDollarClick.TabIndex = 7;
            this.btnOneDollarClick.Text = "$&1";
            this.toolTips.SetToolTip(this.btnOneDollarClick, "Click for One Dollar");
            this.btnOneDollarClick.UseVisualStyleBackColor = false;
            this.btnOneDollarClick.Click += new System.EventHandler(this.btnOneDollarClick_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(24, 511);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(102, 20);
            this.lblChange.TabIndex = 16;
            this.lblChange.Text = "Change Due";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(50, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(389, 247);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "&Total";
            this.toolTips.SetToolTip(this.btnTotal, "Click to get the Total");
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtChangeDue
            // 
            this.txtChangeDue.Location = new System.Drawing.Point(140, 491);
            this.txtChangeDue.Multiline = true;
            this.txtChangeDue.Name = "txtChangeDue";
            this.txtChangeDue.ReadOnly = true;
            this.txtChangeDue.Size = new System.Drawing.Size(125, 67);
            this.txtChangeDue.TabIndex = 13;
            this.toolTips.SetToolTip(this.txtChangeDue, "Due Changes");
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(170, 432);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(43, 22);
            this.txtPayment.TabIndex = 12;
            this.toolTips.SetToolTip(this.txtPayment, "Total Amount");
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(389, 167);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromOrder.TabIndex = 4;
            this.btnRemoveFromOrder.Text = "&Remove";
            this.toolTips.SetToolTip(this.btnRemoveFromOrder, "Click to Remove from Order");
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            this.btnRemoveFromOrder.Click += new System.EventHandler(this.btnRemoveFromOrder_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(554, 164);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "&Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstCurrentOrder
            // 
            this.lstCurrentOrder.FormattingEnabled = true;
            this.lstCurrentOrder.ItemHeight = 16;
            this.lstCurrentOrder.Location = new System.Drawing.Point(20, 138);
            this.lstCurrentOrder.Name = "lstCurrentOrder";
            this.lstCurrentOrder.Size = new System.Drawing.Size(341, 132);
            this.lstCurrentOrder.TabIndex = 7;
            this.toolTips.SetToolTip(this.lstCurrentOrder, "Your ORder Details");
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(389, 138);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(112, 23);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = " &Add to Order";
            this.toolTips.SetToolTip(this.btnAddToOrder, "Click to Add to Order");
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.toolTips.SetToolTip(this.btnClear, "Click to Clear from Order");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(25, 84);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(55, 16);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Quantity";
            // 
            // lblFlavor
            // 
            this.lblFlavor.AutoSize = true;
            this.lblFlavor.Location = new System.Drawing.Point(16, 41);
            this.lblFlavor.Name = "lblFlavor";
            this.lblFlavor.Size = new System.Drawing.Size(86, 16);
            this.lblFlavor.TabIndex = 2;
            this.lblFlavor.Text = "Select Flavor";
            // 
            // lstIceCreamItems
            // 
            this.lstIceCreamItems.FormattingEnabled = true;
            this.lstIceCreamItems.ItemHeight = 16;
            this.lstIceCreamItems.Items.AddRange(new object[] {
            "Chocolate - $2.00",
            "Mint Chocolate - $3.00",
            "Vanila - $2.50",
            "Cookie Cream - $3.50",
            "Strawberry - $2.00"});
            this.lstIceCreamItems.Location = new System.Drawing.Point(108, 41);
            this.lstIceCreamItems.Name = "lstIceCreamItems";
            this.lstIceCreamItems.ScrollAlwaysVisible = true;
            this.lstIceCreamItems.Size = new System.Drawing.Size(232, 20);
            this.lstIceCreamItems.TabIndex = 1;
            this.toolTips.SetToolTip(this.lstIceCreamItems, "Select Flavor for Ice Cream");
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(108, 81);
            this.nudQuantity.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 22);
            this.nudQuantity.TabIndex = 2;
            this.toolTips.SetToolTip(this.nudQuantity, "Select Quantity");
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(791, 651);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.toolTips.SetToolTip(this.btnExit, "Click to Exit Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 685);
            this.Controls.Add(this.panIceCream);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panGuessTheNumber);
            this.Controls.Add(this.panMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Little Games";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panGuessTheNumber.ResumeLayout(false);
            this.panGuessTheNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNNumGuesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNRandomNumber)).EndInit();
            this.gbx_GTN_Settings.ResumeLayout(false);
            this.gbx_GTN_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessedNumber)).EndInit();
            this.panIceCream.ResumeLayout(false);
            this.panIceCream.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnGuessTheNumber;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Panel panGuessTheNumber;
        private System.Windows.Forms.Label lbl_GTN_Title;
        private System.Windows.Forms.Label lblGuessedNumber;
        private System.Windows.Forms.NumericUpDown nudGuessedNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbx_GTN_Settings;
        private System.Windows.Forms.ComboBox cbo_GTN_Difficulty;
        private System.Windows.Forms.Label lbl_GTN_Difficulty;
        private System.Windows.Forms.Label lbl_GTN_Output;
        private System.Windows.Forms.Button btn_GTN_Guess;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label lblGTNMaximum;
        private System.Windows.Forms.Label lblGTNMaximumLabel;
        private System.Windows.Forms.Label lblGTNMinimum;
        private System.Windows.Forms.Label lblGTNMinimumLabel;
        private System.Windows.Forms.NumericUpDown nudGTNRandomNumber;
        private System.Windows.Forms.NumericUpDown nudGTNNumGuesses;
        private System.Windows.Forms.Panel panIceCream;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblFlavor;
        private System.Windows.Forms.ListBox lstIceCreamItems;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.ListBox lstCurrentOrder;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnRemoveFromOrder;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtChangeDue;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOneDollarClick;
        private System.Windows.Forms.Button btnDollarFiveClick;
        private System.Windows.Forms.Button btnTenDollarClick;
        private System.Windows.Forms.Button btnFiftyDollarClick;
        private System.Windows.Forms.Button btnTwentyDollarClick;
        private System.Windows.Forms.TextBox txtCashBalance;
        private System.Windows.Forms.Label lblCashBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

