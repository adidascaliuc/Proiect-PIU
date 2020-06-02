using System;

namespace TargDeMasiniForm
{
    partial class OptiuneInfoForm
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
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.pctModifica = new System.Windows.Forms.PictureBox();
            this.pctCauta = new System.Windows.Forms.PictureBox();
            this.pctAdauga = new System.Windows.Forms.PictureBox();
            this.pctAfiseaza = new System.Windows.Forms.PictureBox();
            this.lblDeconectare = new MetroFramework.Controls.MetroLabel();
            this.pictureDeconectare = new System.Windows.Forms.PictureBox();
            this.btnAdaugaBuget = new MetroFramework.Controls.MetroButton();
            this.lblBuget = new MetroFramework.Controls.MetroLabel();
            this.pictureUserPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPrenume = new MetroFramework.Controls.MetroLabel();
            this.lblNume = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnResetPassword = new MetroFramework.Controls.MetroButton();
            this.panelMeniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeconectare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeniu
            // 
            this.panelMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelMeniu.Controls.Add(this.pictureInfo);
            this.panelMeniu.Controls.Add(this.pctModifica);
            this.panelMeniu.Controls.Add(this.pctCauta);
            this.panelMeniu.Controls.Add(this.pctAdauga);
            this.panelMeniu.Controls.Add(this.pctAfiseaza);
            this.panelMeniu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeniu.Location = new System.Drawing.Point(0, 0);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(75, 411);
            this.panelMeniu.TabIndex = 100;
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::TargDeMasiniForm.Properties.Resources.infoPng1;
            this.pictureInfo.Location = new System.Drawing.Point(5, 353);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(55, 43);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 4;
            this.pictureInfo.TabStop = false;
            // 
            // pctModifica
            // 
            this.pctModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctModifica.Image = global::TargDeMasiniForm.Properties.Resources.editPng1;
            this.pctModifica.Location = new System.Drawing.Point(12, 278);
            this.pctModifica.Name = "pctModifica";
            this.pctModifica.Size = new System.Drawing.Size(46, 39);
            this.pctModifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctModifica.TabIndex = 3;
            this.pctModifica.TabStop = false;
            this.pctModifica.Click += new System.EventHandler(this.pctModifica_Click);
            // 
            // pctCauta
            // 
            this.pctCauta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCauta.Image = global::TargDeMasiniForm.Properties.Resources.searchPng1;
            this.pctCauta.Location = new System.Drawing.Point(12, 183);
            this.pctCauta.Name = "pctCauta";
            this.pctCauta.Size = new System.Drawing.Size(46, 45);
            this.pctCauta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCauta.TabIndex = 2;
            this.pctCauta.TabStop = false;
            this.pctCauta.Click += new System.EventHandler(this.pctCauta_Click);
            // 
            // pctAdauga
            // 
            this.pctAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAdauga.Image = global::TargDeMasiniForm.Properties.Resources.addPng1;
            this.pctAdauga.Location = new System.Drawing.Point(14, 18);
            this.pctAdauga.Name = "pctAdauga";
            this.pctAdauga.Size = new System.Drawing.Size(44, 43);
            this.pctAdauga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdauga.TabIndex = 1;
            this.pctAdauga.TabStop = false;
            this.pctAdauga.Click += new System.EventHandler(this.pctAdauga_Click_1);
            // 
            // pctAfiseaza
            // 
            this.pctAfiseaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAfiseaza.Image = global::TargDeMasiniForm.Properties.Resources.listPng1;
            this.pctAfiseaza.Location = new System.Drawing.Point(12, 96);
            this.pctAfiseaza.Name = "pctAfiseaza";
            this.pctAfiseaza.Size = new System.Drawing.Size(46, 42);
            this.pctAfiseaza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAfiseaza.TabIndex = 0;
            this.pctAfiseaza.TabStop = false;
            this.pctAfiseaza.Click += new System.EventHandler(this.pctAfiseaza_Click);
            // 
            // lblDeconectare
            // 
            this.lblDeconectare.AutoSize = true;
            this.lblDeconectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lblDeconectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeconectare.CustomBackground = true;
            this.lblDeconectare.CustomForeColor = true;
            this.lblDeconectare.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeconectare.Location = new System.Drawing.Point(777, 6);
            this.lblDeconectare.Name = "lblDeconectare";
            this.lblDeconectare.Size = new System.Drawing.Size(82, 19);
            this.lblDeconectare.TabIndex = 155;
            this.lblDeconectare.Text = "Deconectare";
            this.lblDeconectare.Click += new System.EventHandler(this.lblDeconectare_Click);
            // 
            // pictureDeconectare
            // 
            this.pictureDeconectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDeconectare.Image = global::TargDeMasiniForm.Properties.Resources.logoutPng1;
            this.pictureDeconectare.Location = new System.Drawing.Point(874, 4);
            this.pictureDeconectare.Name = "pictureDeconectare";
            this.pictureDeconectare.Size = new System.Drawing.Size(23, 21);
            this.pictureDeconectare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDeconectare.TabIndex = 154;
            this.pictureDeconectare.TabStop = false;
            this.pictureDeconectare.Click += new System.EventHandler(this.pictureDeconectare_Click);
            // 
            // btnAdaugaBuget
            // 
            this.btnAdaugaBuget.Location = new System.Drawing.Point(85, 267);
            this.btnAdaugaBuget.Name = "btnAdaugaBuget";
            this.btnAdaugaBuget.Size = new System.Drawing.Size(98, 41);
            this.btnAdaugaBuget.TabIndex = 152;
            this.btnAdaugaBuget.Text = "Adauga Fonduri";
            this.btnAdaugaBuget.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdaugaBuget.Click += new System.EventHandler(this.btnAdaugaBuget_Click);
            // 
            // lblBuget
            // 
            this.lblBuget.AutoSize = true;
            this.lblBuget.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBuget.Location = new System.Drawing.Point(85, 216);
            this.lblBuget.Name = "lblBuget";
            this.lblBuget.Size = new System.Drawing.Size(70, 25);
            this.lblBuget.TabIndex = 151;
            this.lblBuget.Text = " Buget: ";
            // 
            // pictureUserPhoto
            // 
            this.pictureUserPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUserPhoto.Image = global::TargDeMasiniForm.Properties.Resources.usernamePng;
            this.pictureUserPhoto.Location = new System.Drawing.Point(464, 42);
            this.pictureUserPhoto.Name = "pictureUserPhoto";
            this.pictureUserPhoto.Size = new System.Drawing.Size(169, 152);
            this.pictureUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUserPhoto.TabIndex = 150;
            this.pictureUserPhoto.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(512, 200);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(74, 32);
            this.btnAddPhoto.TabIndex = 149;
            this.btnAddPhoto.Text = "Adauga";
            this.btnAddPhoto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(512, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 148;
            this.metroLabel1.Text = "User photo";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsername.Location = new System.Drawing.Point(85, 169);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 25);
            this.lblUsername.TabIndex = 147;
            this.lblUsername.Text = "Username: ";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrenume.Location = new System.Drawing.Point(85, 122);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(90, 25);
            this.lblPrenume.TabIndex = 146;
            this.lblPrenume.Text = "Prenume: ";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNume.Location = new System.Drawing.Point(85, 79);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(68, 25);
            this.lblNume.TabIndex = 145;
            this.lblNume.Text = "Nume: ";
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(85, 11);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(83, 28);
            this.metroTile1.TabIndex = 144;
            this.metroTile1.Text = "Info";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(85, 330);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(98, 41);
            this.btnResetPassword.TabIndex = 156;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // OptiuneInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.lblDeconectare);
            this.Controls.Add(this.pictureDeconectare);
            this.Controls.Add(this.btnAdaugaBuget);
            this.Controls.Add(this.lblBuget);
            this.Controls.Add(this.pictureUserPhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.panelMeniu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OptiuneInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Car Shop";
            this.panelMeniu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeconectare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.PictureBox pctModifica;
        private System.Windows.Forms.PictureBox pctCauta;
        private System.Windows.Forms.PictureBox pctAdauga;
        private System.Windows.Forms.PictureBox pctAfiseaza;
        private MetroFramework.Controls.MetroLabel lblDeconectare;
        private System.Windows.Forms.PictureBox pictureDeconectare;
        private MetroFramework.Controls.MetroButton btnAdaugaBuget;
        private System.Windows.Forms.PictureBox pictureUserPhoto;
        private MetroFramework.Controls.MetroButton btnAddPhoto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPrenume;
        public MetroFramework.Controls.MetroLabel lblNume;
        private MetroFramework.Controls.MetroTile metroTile1;
        public MetroFramework.Controls.MetroLabel lblBuget;
        private MetroFramework.Controls.MetroButton btnResetPassword;
    }
}