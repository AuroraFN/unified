﻿namespace AuroraLauncher
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.materialFlatButtonSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButtonLaunch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelUpdate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelOnline = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButtonInfo = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButtonPasswordView = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialFlatButtonSettings
            // 
            this.materialFlatButtonSettings.AutoSize = true;
            this.materialFlatButtonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonSettings.Depth = 0;
            this.materialFlatButtonSettings.Location = new System.Drawing.Point(451, 299);
            this.materialFlatButtonSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonSettings.Name = "materialFlatButtonSettings";
            this.materialFlatButtonSettings.Primary = false;
            this.materialFlatButtonSettings.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButtonSettings.TabIndex = 0;
            this.materialFlatButtonSettings.Text = "Settings";
            this.materialFlatButtonSettings.UseVisualStyleBackColor = true;
            this.materialFlatButtonSettings.Click += new System.EventHandler(this.materialFlatButtonSettings_Click);
            // 
            // materialRaisedButtonLaunch
            // 
            this.materialRaisedButtonLaunch.Depth = 0;
            this.materialRaisedButtonLaunch.Location = new System.Drawing.Point(12, 299);
            this.materialRaisedButtonLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonLaunch.Name = "materialRaisedButtonLaunch";
            this.materialRaisedButtonLaunch.Primary = true;
            this.materialRaisedButtonLaunch.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButtonLaunch.TabIndex = 1;
            this.materialRaisedButtonLaunch.Text = "Launch";
            this.materialRaisedButtonLaunch.UseVisualStyleBackColor = true;
            this.materialRaisedButtonLaunch.Click += new System.EventHandler(this.materialRaisedButtonLaunch_Click);
            // 
            // materialSingleLineTextFieldEmail
            // 
            this.materialSingleLineTextFieldEmail.Depth = 0;
            this.materialSingleLineTextFieldEmail.Hint = "";
            this.materialSingleLineTextFieldEmail.Location = new System.Drawing.Point(69, 79);
            this.materialSingleLineTextFieldEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldEmail.Name = "materialSingleLineTextFieldEmail";
            this.materialSingleLineTextFieldEmail.PasswordChar = '\0';
            this.materialSingleLineTextFieldEmail.SelectedText = "";
            this.materialSingleLineTextFieldEmail.SelectionLength = 0;
            this.materialSingleLineTextFieldEmail.SelectionStart = 0;
            this.materialSingleLineTextFieldEmail.Size = new System.Drawing.Size(459, 23);
            this.materialSingleLineTextFieldEmail.TabIndex = 3;
            this.materialSingleLineTextFieldEmail.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldEmail.TextChanged += new System.EventHandler(this.materialSingleLineTextFieldEmail_TextChanged);
            // 
            // materialSingleLineTextFieldPassword
            // 
            this.materialSingleLineTextFieldPassword.Depth = 0;
            this.materialSingleLineTextFieldPassword.Hint = "";
            this.materialSingleLineTextFieldPassword.Location = new System.Drawing.Point(97, 108);
            this.materialSingleLineTextFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPassword.Name = "materialSingleLineTextFieldPassword";
            this.materialSingleLineTextFieldPassword.PasswordChar = '\0';
            this.materialSingleLineTextFieldPassword.SelectedText = "";
            this.materialSingleLineTextFieldPassword.SelectionLength = 0;
            this.materialSingleLineTextFieldPassword.SelectionStart = 0;
            this.materialSingleLineTextFieldPassword.Size = new System.Drawing.Size(379, 23);
            this.materialSingleLineTextFieldPassword.TabIndex = 6;
            this.materialSingleLineTextFieldPassword.UseSystemPasswordChar = true;
            this.materialSingleLineTextFieldPassword.TextChanged += new System.EventHandler(this.materialSingleLineTextFieldPassword_TextChanged);
            // 
            // materialLabelPassword
            // 
            this.materialLabelPassword.AutoSize = true;
            this.materialLabelPassword.Depth = 0;
            this.materialLabelPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelPassword.Location = new System.Drawing.Point(12, 112);
            this.materialLabelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPassword.Name = "materialLabelPassword";
            this.materialLabelPassword.Size = new System.Drawing.Size(79, 19);
            this.materialLabelPassword.TabIndex = 5;
            this.materialLabelPassword.Text = "Password:";
            // 
            // materialLabelEmail
            // 
            this.materialLabelEmail.AutoSize = true;
            this.materialLabelEmail.Depth = 0;
            this.materialLabelEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelEmail.Location = new System.Drawing.Point(12, 83);
            this.materialLabelEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmail.Name = "materialLabelEmail";
            this.materialLabelEmail.Size = new System.Drawing.Size(51, 19);
            this.materialLabelEmail.TabIndex = 4;
            this.materialLabelEmail.Text = "Email:";
            // 
            // materialLabelUpdate
            // 
            this.materialLabelUpdate.AutoSize = true;
            this.materialLabelUpdate.Depth = 0;
            this.materialLabelUpdate.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelUpdate.Location = new System.Drawing.Point(8, 277);
            this.materialLabelUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelUpdate.Name = "materialLabelUpdate";
            this.materialLabelUpdate.Size = new System.Drawing.Size(362, 19);
            this.materialLabelUpdate.TabIndex = 7;
            this.materialLabelUpdate.Text = "You must update Aurora Launcher to launch Fortnite.";
            this.materialLabelUpdate.Visible = false;
            // 
            // materialLabelOnline
            // 
            this.materialLabelOnline.AutoSize = true;
            this.materialLabelOnline.Depth = 0;
            this.materialLabelOnline.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelOnline.Location = new System.Drawing.Point(94, 307);
            this.materialLabelOnline.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelOnline.Name = "materialLabelOnline";
            this.materialLabelOnline.Size = new System.Drawing.Size(135, 19);
            this.materialLabelOnline.TabIndex = 10;
            this.materialLabelOnline.Text = "Online: ?, Parties: ?";
            this.materialLabelOnline.Visible = false;
            // 
            // materialFlatButtonInfo
            // 
            this.materialFlatButtonInfo.AutoSize = true;
            this.materialFlatButtonInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonInfo.Depth = 0;
            this.materialFlatButtonInfo.Location = new System.Drawing.Point(400, 299);
            this.materialFlatButtonInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonInfo.Name = "materialFlatButtonInfo";
            this.materialFlatButtonInfo.Primary = false;
            this.materialFlatButtonInfo.Size = new System.Drawing.Size(43, 36);
            this.materialFlatButtonInfo.TabIndex = 11;
            this.materialFlatButtonInfo.Text = "Info";
            this.materialFlatButtonInfo.UseVisualStyleBackColor = true;
            this.materialFlatButtonInfo.Click += new System.EventHandler(this.materialFlatButtonInfo_Click);
            // 
            // materialRaisedButtonPasswordView
            // 
            this.materialRaisedButtonPasswordView.Depth = 0;
            this.materialRaisedButtonPasswordView.Location = new System.Drawing.Point(482, 108);
            this.materialRaisedButtonPasswordView.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPasswordView.Name = "materialRaisedButtonPasswordView";
            this.materialRaisedButtonPasswordView.Primary = true;
            this.materialRaisedButtonPasswordView.Size = new System.Drawing.Size(46, 23);
            this.materialRaisedButtonPasswordView.TabIndex = 12;
            this.materialRaisedButtonPasswordView.Text = "Show";
            this.materialRaisedButtonPasswordView.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPasswordView.Click += new System.EventHandler(this.materialRaisedButtonPasswordView_Click);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 350);
            this.Controls.Add(this.materialRaisedButtonPasswordView);
            this.Controls.Add(this.materialFlatButtonInfo);
            this.Controls.Add(this.materialLabelOnline);
            this.Controls.Add(this.materialLabelUpdate);
            this.Controls.Add(this.materialSingleLineTextFieldPassword);
            this.Controls.Add(this.materialLabelPassword);
            this.Controls.Add(this.materialLabelEmail);
            this.Controls.Add(this.materialSingleLineTextFieldEmail);
            this.Controls.Add(this.materialRaisedButtonLaunch);
            this.Controls.Add(this.materialFlatButtonSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gui";
            this.Sizable = false;
            this.Text = "Aurora Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonSettings;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonLaunch;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabelPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabelUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabelOnline;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonInfo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPasswordView;
    }
}