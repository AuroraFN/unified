﻿namespace AuroraLauncher
{
    partial class OldGui
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
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelFortnitePath = new System.Windows.Forms.Label();
            this.textBoxFortnitePath = new System.Windows.Forms.TextBox();
            this.linkLabelDiscord = new System.Windows.Forms.LinkLabel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialogBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(262, 79);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(60, 20);
            this.buttonLaunch.TabIndex = 0;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 15);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(77, 12);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(245, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // labelFortnitePath
            // 
            this.labelFortnitePath.AutoSize = true;
            this.labelFortnitePath.Location = new System.Drawing.Point(12, 42);
            this.labelFortnitePath.Name = "labelFortnitePath";
            this.labelFortnitePath.Size = new System.Drawing.Size(70, 13);
            this.labelFortnitePath.TabIndex = 3;
            this.labelFortnitePath.Text = "Fortnite Path:";
            // 
            // textBoxFortnitePath
            // 
            this.textBoxFortnitePath.Location = new System.Drawing.Point(88, 39);
            this.textBoxFortnitePath.Name = "textBoxFortnitePath";
            this.textBoxFortnitePath.Size = new System.Drawing.Size(203, 20);
            this.textBoxFortnitePath.TabIndex = 4;
            // 
            // linkLabelDiscord
            // 
            this.linkLabelDiscord.AutoSize = true;
            this.linkLabelDiscord.Location = new System.Drawing.Point(13, 86);
            this.linkLabelDiscord.Name = "linkLabelDiscord";
            this.linkLabelDiscord.Size = new System.Drawing.Size(86, 13);
            this.linkLabelDiscord.TabIndex = 5;
            this.linkLabelDiscord.TabStop = true;
            this.linkLabelDiscord.Text = "Join our Discord.";
            this.linkLabelDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDiscord_LinkClicked);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(297, 39);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(25, 20);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(224, 79);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(35, 20);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // OldGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.linkLabelDiscord);
            this.Controls.Add(this.textBoxFortnitePath);
            this.Controls.Add(this.labelFortnitePath);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OldGUI";
            this.Text = "Aurora Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OldGui_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelFortnitePath;
        private System.Windows.Forms.TextBox textBoxFortnitePath;
        private System.Windows.Forms.LinkLabel linkLabelDiscord;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBrowse;
        private System.Windows.Forms.Button buttonInfo;
    }
}