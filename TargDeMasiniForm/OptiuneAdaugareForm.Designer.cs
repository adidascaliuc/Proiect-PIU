namespace TargDeMasiniForm
{
    partial class OptiuneAdaugareForm
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
            this.pictureDeconectare = new System.Windows.Forms.PictureBox();
            this.txtFirma = new MetroFramework.Controls.MetroTextBox();
            this.txtModel = new MetroFramework.Controls.MetroTextBox();
            this.cBoxAnFabricatie = new MetroFramework.Controls.MetroComboBox();
            this.txtPret = new MetroFramework.Controls.MetroTextBox();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.lblFirma = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.lblAnFabricatie = new MetroFramework.Controls.MetroLabel();
            this.lblCuloare = new MetroFramework.Controls.MetroLabel();
            this.lblOptiuni = new MetroFramework.Controls.MetroLabel();
            this.lblPret = new MetroFramework.Controls.MetroLabel();
            this.radioAlb = new MetroFramework.Controls.MetroRadioButton();
            this.radioNegru = new MetroFramework.Controls.MetroRadioButton();
            this.radioRosu = new MetroFramework.Controls.MetroRadioButton();
            this.radioAlbastru = new MetroFramework.Controls.MetroRadioButton();
            this.radioVerde = new MetroFramework.Controls.MetroRadioButton();
            this.radioArgintiu = new MetroFramework.Controls.MetroRadioButton();
            this.cBoxAerConditionat = new MetroFramework.Controls.MetroCheckBox();
            this.cBoxOptiuniVolan = new MetroFramework.Controls.MetroCheckBox();
            this.cBoxScaunePiele = new MetroFramework.Controls.MetroCheckBox();
            this.cBoxGeamuriElectrice = new MetroFramework.Controls.MetroCheckBox();
            this.cBoxNavigatie = new MetroFramework.Controls.MetroCheckBox();
            this.cBoxCutieAutomata = new MetroFramework.Controls.MetroCheckBox();
            this.lblDeconectare = new MetroFramework.Controls.MetroLabel();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.pctModifica = new System.Windows.Forms.PictureBox();
            this.pctCauta = new System.Windows.Forms.PictureBox();
            this.pctAdauga = new System.Windows.Forms.PictureBox();
            this.pctAfiseaza = new System.Windows.Forms.PictureBox();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeconectare)).BeginInit();
            this.panelMeniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDeconectare
            // 
            this.pictureDeconectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDeconectare.Image = global::TargDeMasiniForm.Properties.Resources.logOutPng;
            this.pictureDeconectare.Location = new System.Drawing.Point(880, 6);
            this.pictureDeconectare.Name = "pictureDeconectare";
            this.pictureDeconectare.Size = new System.Drawing.Size(23, 21);
            this.pictureDeconectare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDeconectare.TabIndex = 69;
            this.pictureDeconectare.TabStop = false;
            this.pictureDeconectare.Click += new System.EventHandler(this.pictureDeconectare_Click_1);
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(197, 8);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(167, 23);
            this.txtFirma.TabIndex = 75;
            this.txtFirma.Enter += new System.EventHandler(this.txtFirma_Enter);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(197, 38);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(167, 23);
            this.txtModel.TabIndex = 76;
            this.txtModel.Enter += new System.EventHandler(this.txtModel_Enter);
            // 
            // cBoxAnFabricatie
            // 
            this.cBoxAnFabricatie.FormattingEnabled = true;
            this.cBoxAnFabricatie.ItemHeight = 23;
            this.cBoxAnFabricatie.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cBoxAnFabricatie.Location = new System.Drawing.Point(197, 68);
            this.cBoxAnFabricatie.Name = "cBoxAnFabricatie";
            this.cBoxAnFabricatie.Size = new System.Drawing.Size(167, 29);
            this.cBoxAnFabricatie.TabIndex = 77;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(197, 329);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(167, 23);
            this.txtPret.TabIndex = 78;
            this.txtPret.Enter += new System.EventHandler(this.txtPret_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(235, 363);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 36);
            this.btnReset.TabIndex = 79;
            this.btnReset.Text = "Reset";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(92, 12);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(46, 19);
            this.lblFirma.TabIndex = 80;
            this.lblFirma.Text = "Firma:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(92, 42);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 19);
            this.lblModel.TabIndex = 81;
            this.lblModel.Text = "Model:";
            // 
            // lblAnFabricatie
            // 
            this.lblAnFabricatie.AutoSize = true;
            this.lblAnFabricatie.Location = new System.Drawing.Point(92, 78);
            this.lblAnFabricatie.Name = "lblAnFabricatie";
            this.lblAnFabricatie.Size = new System.Drawing.Size(88, 19);
            this.lblAnFabricatie.TabIndex = 82;
            this.lblAnFabricatie.Text = "An Fabricatie:";
            // 
            // lblCuloare
            // 
            this.lblCuloare.AutoSize = true;
            this.lblCuloare.Location = new System.Drawing.Point(92, 119);
            this.lblCuloare.Name = "lblCuloare";
            this.lblCuloare.Size = new System.Drawing.Size(58, 19);
            this.lblCuloare.TabIndex = 83;
            this.lblCuloare.Text = "Culoare:";
            // 
            // lblOptiuni
            // 
            this.lblOptiuni.AutoSize = true;
            this.lblOptiuni.Location = new System.Drawing.Point(92, 226);
            this.lblOptiuni.Name = "lblOptiuni";
            this.lblOptiuni.Size = new System.Drawing.Size(55, 19);
            this.lblOptiuni.TabIndex = 84;
            this.lblOptiuni.Text = "Optiuni:";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(92, 329);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(36, 19);
            this.lblPret.TabIndex = 85;
            this.lblPret.Text = "Pret:";
            // 
            // radioAlb
            // 
            this.radioAlb.AutoSize = true;
            this.radioAlb.Location = new System.Drawing.Point(197, 123);
            this.radioAlb.Name = "radioAlb";
            this.radioAlb.Size = new System.Drawing.Size(41, 15);
            this.radioAlb.TabIndex = 86;
            this.radioAlb.TabStop = true;
            this.radioAlb.Text = "Alb";
            this.radioAlb.UseVisualStyleBackColor = true;
            // 
            // radioNegru
            // 
            this.radioNegru.AutoSize = true;
            this.radioNegru.Location = new System.Drawing.Point(197, 146);
            this.radioNegru.Name = "radioNegru";
            this.radioNegru.Size = new System.Drawing.Size(56, 15);
            this.radioNegru.TabIndex = 87;
            this.radioNegru.TabStop = true;
            this.radioNegru.Text = "Negru";
            this.radioNegru.UseVisualStyleBackColor = true;
            // 
            // radioRosu
            // 
            this.radioRosu.AutoSize = true;
            this.radioRosu.Location = new System.Drawing.Point(197, 171);
            this.radioRosu.Name = "radioRosu";
            this.radioRosu.Size = new System.Drawing.Size(49, 15);
            this.radioRosu.TabIndex = 88;
            this.radioRosu.TabStop = true;
            this.radioRosu.Text = "Rosu";
            this.radioRosu.UseVisualStyleBackColor = true;
            // 
            // radioAlbastru
            // 
            this.radioAlbastru.AutoSize = true;
            this.radioAlbastru.Location = new System.Drawing.Point(360, 123);
            this.radioAlbastru.Name = "radioAlbastru";
            this.radioAlbastru.Size = new System.Drawing.Size(67, 15);
            this.radioAlbastru.TabIndex = 89;
            this.radioAlbastru.TabStop = true;
            this.radioAlbastru.Text = "Albastru";
            this.radioAlbastru.UseVisualStyleBackColor = true;
            // 
            // radioVerde
            // 
            this.radioVerde.AutoSize = true;
            this.radioVerde.Location = new System.Drawing.Point(360, 148);
            this.radioVerde.Name = "radioVerde";
            this.radioVerde.Size = new System.Drawing.Size(52, 15);
            this.radioVerde.TabIndex = 90;
            this.radioVerde.TabStop = true;
            this.radioVerde.Text = "Verde";
            this.radioVerde.UseVisualStyleBackColor = true;
            // 
            // radioArgintiu
            // 
            this.radioArgintiu.AutoSize = true;
            this.radioArgintiu.Location = new System.Drawing.Point(360, 171);
            this.radioArgintiu.Name = "radioArgintiu";
            this.radioArgintiu.Size = new System.Drawing.Size(66, 15);
            this.radioArgintiu.TabIndex = 91;
            this.radioArgintiu.TabStop = true;
            this.radioArgintiu.Text = "Argintiu";
            this.radioArgintiu.UseVisualStyleBackColor = true;
            // 
            // cBoxAerConditionat
            // 
            this.cBoxAerConditionat.AutoSize = true;
            this.cBoxAerConditionat.Location = new System.Drawing.Point(195, 226);
            this.cBoxAerConditionat.Name = "cBoxAerConditionat";
            this.cBoxAerConditionat.Size = new System.Drawing.Size(107, 15);
            this.cBoxAerConditionat.TabIndex = 92;
            this.cBoxAerConditionat.Text = "Aer Conditionat";
            this.cBoxAerConditionat.UseVisualStyleBackColor = true;
            // 
            // cBoxOptiuniVolan
            // 
            this.cBoxOptiuniVolan.AutoSize = true;
            this.cBoxOptiuniVolan.Location = new System.Drawing.Point(195, 247);
            this.cBoxOptiuniVolan.Name = "cBoxOptiuniVolan";
            this.cBoxOptiuniVolan.Size = new System.Drawing.Size(95, 15);
            this.cBoxOptiuniVolan.TabIndex = 93;
            this.cBoxOptiuniVolan.Text = "Optiuni Volan";
            this.cBoxOptiuniVolan.UseVisualStyleBackColor = true;
            // 
            // cBoxScaunePiele
            // 
            this.cBoxScaunePiele.AutoSize = true;
            this.cBoxScaunePiele.Location = new System.Drawing.Point(195, 268);
            this.cBoxScaunePiele.Name = "cBoxScaunePiele";
            this.cBoxScaunePiele.Size = new System.Drawing.Size(89, 15);
            this.cBoxScaunePiele.TabIndex = 94;
            this.cBoxScaunePiele.Text = "Scaune Piele";
            this.cBoxScaunePiele.UseVisualStyleBackColor = true;
            // 
            // cBoxGeamuriElectrice
            // 
            this.cBoxGeamuriElectrice.AutoSize = true;
            this.cBoxGeamuriElectrice.Location = new System.Drawing.Point(360, 226);
            this.cBoxGeamuriElectrice.Name = "cBoxGeamuriElectrice";
            this.cBoxGeamuriElectrice.Size = new System.Drawing.Size(115, 15);
            this.cBoxGeamuriElectrice.TabIndex = 95;
            this.cBoxGeamuriElectrice.Text = "Geamuri Electrice";
            this.cBoxGeamuriElectrice.UseVisualStyleBackColor = true;
            // 
            // cBoxNavigatie
            // 
            this.cBoxNavigatie.AutoSize = true;
            this.cBoxNavigatie.Location = new System.Drawing.Point(360, 247);
            this.cBoxNavigatie.Name = "cBoxNavigatie";
            this.cBoxNavigatie.Size = new System.Drawing.Size(73, 15);
            this.cBoxNavigatie.TabIndex = 96;
            this.cBoxNavigatie.Text = "Navigatie";
            this.cBoxNavigatie.UseVisualStyleBackColor = true;
            // 
            // cBoxCutieAutomata
            // 
            this.cBoxCutieAutomata.AutoSize = true;
            this.cBoxCutieAutomata.Location = new System.Drawing.Point(360, 268);
            this.cBoxCutieAutomata.Name = "cBoxCutieAutomata";
            this.cBoxCutieAutomata.Size = new System.Drawing.Size(107, 15);
            this.cBoxCutieAutomata.TabIndex = 97;
            this.cBoxCutieAutomata.Text = "Cutie Automata";
            this.cBoxCutieAutomata.UseVisualStyleBackColor = true;
            // 
            // lblDeconectare
            // 
            this.lblDeconectare.AutoSize = true;
            this.lblDeconectare.Location = new System.Drawing.Point(783, 8);
            this.lblDeconectare.Name = "lblDeconectare";
            this.lblDeconectare.Size = new System.Drawing.Size(82, 19);
            this.lblDeconectare.TabIndex = 98;
            this.lblDeconectare.Text = "Deconectare";
            this.lblDeconectare.Click += new System.EventHandler(this.lblDeconectare_Click);
            // 
            // panelMeniu
            // 
            this.panelMeniu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMeniu.Controls.Add(this.pictureInfo);
            this.panelMeniu.Controls.Add(this.pctModifica);
            this.panelMeniu.Controls.Add(this.pctCauta);
            this.panelMeniu.Controls.Add(this.pctAdauga);
            this.panelMeniu.Controls.Add(this.pctAfiseaza);
            this.panelMeniu.Location = new System.Drawing.Point(0, -6);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(75, 424);
            this.panelMeniu.TabIndex = 99;
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::TargDeMasiniForm.Properties.Resources.infoPng;
            this.pictureInfo.Location = new System.Drawing.Point(5, 353);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(55, 43);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 4;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctModifica
            // 
            this.pctModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctModifica.Image = global::TargDeMasiniForm.Properties.Resources.editPng;
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
            this.pctCauta.Image = global::TargDeMasiniForm.Properties.Resources.searchPng;
            this.pctCauta.Location = new System.Drawing.Point(3, 183);
            this.pctCauta.Name = "pctCauta";
            this.pctCauta.Size = new System.Drawing.Size(55, 45);
            this.pctCauta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCauta.TabIndex = 2;
            this.pctCauta.TabStop = false;
            this.pctCauta.Click += new System.EventHandler(this.pctCauta_Click);
            // 
            // pctAdauga
            // 
            this.pctAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAdauga.Image = global::TargDeMasiniForm.Properties.Resources.addPng;
            this.pctAdauga.Location = new System.Drawing.Point(12, 19);
            this.pctAdauga.Name = "pctAdauga";
            this.pctAdauga.Size = new System.Drawing.Size(46, 43);
            this.pctAdauga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdauga.TabIndex = 1;
            this.pctAdauga.TabStop = false;
            this.pctAdauga.Click += new System.EventHandler(this.pctAdauga_Click);
            // 
            // pctAfiseaza
            // 
            this.pctAfiseaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAfiseaza.Image = global::TargDeMasiniForm.Properties.Resources.listPng;
            this.pctAfiseaza.Location = new System.Drawing.Point(12, 96);
            this.pctAfiseaza.Name = "pctAfiseaza";
            this.pctAfiseaza.Size = new System.Drawing.Size(46, 48);
            this.pctAfiseaza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAfiseaza.TabIndex = 0;
            this.pctAfiseaza.TabStop = false;
            this.pctAfiseaza.Click += new System.EventHandler(this.pctAfiseaza_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(0, 0);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 100;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(0, 0);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.TabIndex = 102;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(0, 0);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 101;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(0, 0);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 103;
            // 
            // OptiuneAdaugareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblDeconectare);
            this.Controls.Add(this.cBoxCutieAutomata);
            this.Controls.Add(this.cBoxNavigatie);
            this.Controls.Add(this.cBoxGeamuriElectrice);
            this.Controls.Add(this.cBoxScaunePiele);
            this.Controls.Add(this.cBoxOptiuniVolan);
            this.Controls.Add(this.cBoxAerConditionat);
            this.Controls.Add(this.radioArgintiu);
            this.Controls.Add(this.radioVerde);
            this.Controls.Add(this.radioAlbastru);
            this.Controls.Add(this.radioRosu);
            this.Controls.Add(this.radioNegru);
            this.Controls.Add(this.radioAlb);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblOptiuni);
            this.Controls.Add(this.lblCuloare);
            this.Controls.Add(this.lblAnFabricatie);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.cBoxAnFabricatie);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.pictureDeconectare);
            this.Name = "OptiuneAdaugareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeconectare)).EndInit();
            this.panelMeniu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureDeconectare;
        private MetroFramework.Controls.MetroTextBox txtFirma;
        private MetroFramework.Controls.MetroTextBox txtModel;
        private MetroFramework.Controls.MetroComboBox cBoxAnFabricatie;
        private MetroFramework.Controls.MetroTextBox txtPret;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroLabel lblFirma;
        private MetroFramework.Controls.MetroLabel lblModel;
        private MetroFramework.Controls.MetroLabel lblAnFabricatie;
        private MetroFramework.Controls.MetroLabel lblCuloare;
        private MetroFramework.Controls.MetroLabel lblOptiuni;
        private MetroFramework.Controls.MetroLabel lblPret;
        private MetroFramework.Controls.MetroRadioButton radioAlb;
        private MetroFramework.Controls.MetroRadioButton radioNegru;
        private MetroFramework.Controls.MetroRadioButton radioRosu;
        private MetroFramework.Controls.MetroRadioButton radioAlbastru;
        private MetroFramework.Controls.MetroRadioButton radioVerde;
        private MetroFramework.Controls.MetroRadioButton radioArgintiu;
        private MetroFramework.Controls.MetroCheckBox cBoxAerConditionat;
        private MetroFramework.Controls.MetroCheckBox cBoxOptiuniVolan;
        private MetroFramework.Controls.MetroCheckBox cBoxScaunePiele;
        private MetroFramework.Controls.MetroCheckBox cBoxGeamuriElectrice;
        private MetroFramework.Controls.MetroCheckBox cBoxNavigatie;
        private MetroFramework.Controls.MetroCheckBox cBoxCutieAutomata;
        private MetroFramework.Controls.MetroLabel lblDeconectare;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.PictureBox pictureInfo;
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