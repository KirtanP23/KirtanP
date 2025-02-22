﻿namespace Assignment_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbxCharList = new System.Windows.Forms.ListBox();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCharacterDetails = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(424, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Character Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxCharList
            // 
            this.lbxCharList.FormattingEnabled = true;
            this.lbxCharList.ItemHeight = 16;
            this.lbxCharList.Location = new System.Drawing.Point(12, 130);
            this.lbxCharList.Name = "lbxCharList";
            this.lbxCharList.Size = new System.Drawing.Size(236, 324);
            this.lbxCharList.TabIndex = 4;
            this.toolTip1.SetToolTip(this.lbxCharList, "List of Created Characters");
            this.lbxCharList.SelectedIndexChanged += new System.EventHandler(this.lbxCharList_SelectedIndexChanged);
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.BackColor = System.Drawing.Color.Crimson;
            this.btnCreateCharacter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCharacter.Location = new System.Drawing.Point(212, 494);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(176, 63);
            this.btnCreateCharacter.TabIndex = 1;
            this.btnCreateCharacter.Text = "&Create New Character";
            this.toolTip1.SetToolTip(this.btnCreateCharacter, "Click to Create a New Character");
            this.btnCreateCharacter.UseVisualStyleBackColor = false;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.BackColor = System.Drawing.Color.Crimson;
            this.btnEditCharacter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCharacter.Location = new System.Drawing.Point(521, 494);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(176, 63);
            this.btnEditCharacter.TabIndex = 2;
            this.btnEditCharacter.Text = "&Edit Character";
            this.toolTip1.SetToolTip(this.btnEditCharacter, "Click to Edit a Character");
            this.btnEditCharacter.UseVisualStyleBackColor = false;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(806, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 63);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to Exit");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Character Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbCharacterDetails
            // 
            this.rtbCharacterDetails.Location = new System.Drawing.Point(424, 81);
            this.rtbCharacterDetails.Name = "rtbCharacterDetails";
            this.rtbCharacterDetails.ReadOnly = true;
            this.rtbCharacterDetails.Size = new System.Drawing.Size(345, 373);
            this.rtbCharacterDetails.TabIndex = 5;
            this.rtbCharacterDetails.Text = "";
            this.toolTip1.SetToolTip(this.rtbCharacterDetails, "Details of Characters");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(794, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 561);
            this.panel1.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCreateCharacter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1144, 585);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbCharacterDetails);
            this.Controls.Add(this.btnEditCharacter);
            this.Controls.Add(this.btnCreateCharacter);
            this.Controls.Add(this.lbxCharList);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Character Management";
            this.toolTip1.SetToolTip(this, "D&D CHaracter Management");
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.Button btnEditCharacter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbxCharList;
        private System.Windows.Forms.RichTextBox rtbCharacterDetails;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}