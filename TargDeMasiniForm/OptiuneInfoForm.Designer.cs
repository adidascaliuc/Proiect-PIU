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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.pctModifica = new System.Windows.Forms.PictureBox();
            this.pctCauta = new System.Windows.Forms.PictureBox();
            this.pctAdauga = new System.Windows.Forms.PictureBox();
            this.pctAfiseaza = new System.Windows.Forms.PictureBox();
            this.panelMeniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(91, 13);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(83, 31);
            this.metroTile1.TabIndex = 80;
            this.metroTile1.Text = "Info";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
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
            // OptiuneInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.metroTile1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OptiuneInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Car Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMeniu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.PictureBox pctModifica;
        private System.Windows.Forms.PictureBox pctCauta;
        private System.Windows.Forms.PictureBox pctAdauga;
        private System.Windows.Forms.PictureBox pctAfiseaza;
    }
}