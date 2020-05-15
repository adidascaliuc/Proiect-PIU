using System;

namespace TargDeMasiniForm
{
    partial class OptiuniInfo
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
            this.pctModifica = new System.Windows.Forms.PictureBox();
            this.pctCauta = new System.Windows.Forms.PictureBox();
            this.pctAdauga = new System.Windows.Forms.PictureBox();
            this.pctAfiseaza = new System.Windows.Forms.PictureBox();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.panelMeniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeniu
            // 
            this.panelMeniu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMeniu.Controls.Add(this.pctModifica);
            this.panelMeniu.Controls.Add(this.pctCauta);
            this.panelMeniu.Controls.Add(this.pctAdauga);
            this.panelMeniu.Controls.Add(this.pctAfiseaza);
            this.panelMeniu.Location = new System.Drawing.Point(0, -6);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(75, 424);
            this.panelMeniu.TabIndex = 75;
            // 
            // pctModifica
            // 
            this.pctModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctModifica.Image = global::TargDeMasiniForm.Properties.Resources.editPng;
            this.pctModifica.Location = new System.Drawing.Point(12, 356);
            this.pctModifica.Name = "pctModifica";
            this.pctModifica.Size = new System.Drawing.Size(46, 43);
            this.pctModifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctModifica.TabIndex = 3;
            this.pctModifica.TabStop = false;
            this.pctModifica.Click += new System.EventHandler(this.pctModifica_Click_1);
            // 
            // pctCauta
            // 
            this.pctCauta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCauta.Image = global::TargDeMasiniForm.Properties.Resources.searchPng;
            this.pctCauta.Location = new System.Drawing.Point(2, 233);
            this.pctCauta.Name = "pctCauta";
            this.pctCauta.Size = new System.Drawing.Size(60, 52);
            this.pctCauta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCauta.TabIndex = 2;
            this.pctCauta.TabStop = false;
            this.pctCauta.Click += new System.EventHandler(this.pctCauta_Click);
            // 
            // pctAdauga
            // 
            this.pctAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAdauga.Image = global::TargDeMasiniForm.Properties.Resources.addPng;
            this.pctAdauga.Location = new System.Drawing.Point(12, 44);
            this.pctAdauga.Name = "pctAdauga";
            this.pctAdauga.Size = new System.Drawing.Size(46, 43);
            this.pctAdauga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdauga.TabIndex = 1;
            this.pctAdauga.TabStop = false;
            this.pctAdauga.Click += new System.EventHandler(this.pctAdauga_Click_1);
            // 
            // pctAfiseaza
            // 
            this.pctAfiseaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAfiseaza.Image = global::TargDeMasiniForm.Properties.Resources.listPng;
            this.pctAfiseaza.Location = new System.Drawing.Point(12, 136);
            this.pctAfiseaza.Name = "pctAfiseaza";
            this.pctAfiseaza.Size = new System.Drawing.Size(46, 43);
            this.pctAfiseaza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAfiseaza.TabIndex = 0;
            this.pctAfiseaza.TabStop = false;
            this.pctAfiseaza.Click += new System.EventHandler(this.pctAfiseaza_Click_1);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(0, 0);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 76;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(0, 0);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.TabIndex = 78;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(0, 0);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 77;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(0, 0);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 79;
            // 
            // OptiuniInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TargDeMasiniForm.Properties.Resources.backgroundPrimaPagina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OptiuniInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Car Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMeniu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.PictureBox pctModifica;
        private System.Windows.Forms.PictureBox pctCauta;
        private System.Windows.Forms.PictureBox pctAdauga;
        private System.Windows.Forms.PictureBox pctAfiseaza;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnAdauga;
    }
}