using System;

namespace TargDeMasiniForm
{
    partial class OptiuniForm
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
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblOptiuni = new System.Windows.Forms.Label();
            this.lblCuloare = new System.Windows.Forms.Label();
            this.lblAnFabricatie = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.radioAlb = new System.Windows.Forms.RadioButton();
            this.radioNegru = new System.Windows.Forms.RadioButton();
            this.radioRosu = new System.Windows.Forms.RadioButton();
            this.radioAlbastru = new System.Windows.Forms.RadioButton();
            this.radioVerde = new System.Windows.Forms.RadioButton();
            this.radioArgintiu = new System.Windows.Forms.RadioButton();
            this.cBoxAerConditionat = new System.Windows.Forms.CheckBox();
            this.cBoxOptiuniVolan = new System.Windows.Forms.CheckBox();
            this.cBoxGeamuriElectrice = new System.Windows.Forms.CheckBox();
            this.cBoxScaunePiele = new System.Windows.Forms.CheckBox();
            this.cBoxNavigatie = new System.Windows.Forms.CheckBox();
            this.cBoxCutieAutomata = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.cBoxAnFabricatie = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNrMasini = new System.Windows.Forms.Button();
            this.lblNrMasini = new System.Windows.Forms.Label();
            this.lBoxAfisare = new System.Windows.Forms.ListBox();
            this.lblDeconectare = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctAfiseaza = new System.Windows.Forms.PictureBox();
            this.pctAdauga = new System.Windows.Forms.PictureBox();
            this.pctCauta = new System.Windows.Forms.PictureBox();
            this.pctModifica = new System.Windows.Forms.PictureBox();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).BeginInit();
            this.panelMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblFirma.Location = new System.Drawing.Point(91, 11);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(49, 13);
            this.lblFirma.TabIndex = 0;
            this.lblFirma.Text = "Firma:";
            // 
            // lblOptiuni
            // 
            this.lblOptiuni.AutoSize = true;
            this.lblOptiuni.BackColor = System.Drawing.Color.Transparent;
            this.lblOptiuni.Location = new System.Drawing.Point(89, 228);
            this.lblOptiuni.Name = "lblOptiuni";
            this.lblOptiuni.Size = new System.Drawing.Size(57, 13);
            this.lblOptiuni.TabIndex = 1;
            this.lblOptiuni.Text = "Optiuni:";
            // 
            // lblCuloare
            // 
            this.lblCuloare.AutoSize = true;
            this.lblCuloare.BackColor = System.Drawing.Color.Transparent;
            this.lblCuloare.Location = new System.Drawing.Point(89, 121);
            this.lblCuloare.Name = "lblCuloare";
            this.lblCuloare.Size = new System.Drawing.Size(61, 13);
            this.lblCuloare.TabIndex = 2;
            this.lblCuloare.Text = "Culoare:";
            // 
            // lblAnFabricatie
            // 
            this.lblAnFabricatie.AutoSize = true;
            this.lblAnFabricatie.BackColor = System.Drawing.Color.Transparent;
            this.lblAnFabricatie.Location = new System.Drawing.Point(91, 63);
            this.lblAnFabricatie.Name = "lblAnFabricatie";
            this.lblAnFabricatie.Size = new System.Drawing.Size(98, 13);
            this.lblAnFabricatie.TabIndex = 3;
            this.lblAnFabricatie.Text = "An Fabricatie:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Location = new System.Drawing.Point(91, 37);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.BackColor = System.Drawing.Color.Transparent;
            this.lblPret.Location = new System.Drawing.Point(91, 329);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(38, 13);
            this.lblPret.TabIndex = 5;
            this.lblPret.Text = "Pret:";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(197, 329);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(167, 21);
            this.txtPret.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(197, 37);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(167, 21);
            this.txtModel.TabIndex = 11;
            // 
            // radioAlb
            // 
            this.radioAlb.AutoSize = true;
            this.radioAlb.BackColor = System.Drawing.Color.Transparent;
            this.radioAlb.Location = new System.Drawing.Point(197, 121);
            this.radioAlb.Name = "radioAlb";
            this.radioAlb.Size = new System.Drawing.Size(46, 17);
            this.radioAlb.TabIndex = 12;
            this.radioAlb.TabStop = true;
            this.radioAlb.Text = "Alb";
            this.radioAlb.UseVisualStyleBackColor = false;
            // 
            // radioNegru
            // 
            this.radioNegru.AutoSize = true;
            this.radioNegru.BackColor = System.Drawing.Color.Transparent;
            this.radioNegru.Location = new System.Drawing.Point(197, 146);
            this.radioNegru.Name = "radioNegru";
            this.radioNegru.Size = new System.Drawing.Size(64, 17);
            this.radioNegru.TabIndex = 13;
            this.radioNegru.TabStop = true;
            this.radioNegru.Text = "Negru";
            this.radioNegru.UseVisualStyleBackColor = false;
            // 
            // radioRosu
            // 
            this.radioRosu.AutoSize = true;
            this.radioRosu.BackColor = System.Drawing.Color.Transparent;
            this.radioRosu.Location = new System.Drawing.Point(197, 169);
            this.radioRosu.Name = "radioRosu";
            this.radioRosu.Size = new System.Drawing.Size(56, 17);
            this.radioRosu.TabIndex = 14;
            this.radioRosu.TabStop = true;
            this.radioRosu.Text = "Rosu";
            this.radioRosu.UseVisualStyleBackColor = false;
            // 
            // radioAlbastru
            // 
            this.radioAlbastru.AutoSize = true;
            this.radioAlbastru.BackColor = System.Drawing.Color.Transparent;
            this.radioAlbastru.Location = new System.Drawing.Point(360, 123);
            this.radioAlbastru.Name = "radioAlbastru";
            this.radioAlbastru.Size = new System.Drawing.Size(80, 17);
            this.radioAlbastru.TabIndex = 15;
            this.radioAlbastru.TabStop = true;
            this.radioAlbastru.Text = "Albastru";
            this.radioAlbastru.UseVisualStyleBackColor = false;
            // 
            // radioVerde
            // 
            this.radioVerde.AutoSize = true;
            this.radioVerde.BackColor = System.Drawing.Color.Transparent;
            this.radioVerde.Location = new System.Drawing.Point(360, 146);
            this.radioVerde.Name = "radioVerde";
            this.radioVerde.Size = new System.Drawing.Size(63, 17);
            this.radioVerde.TabIndex = 16;
            this.radioVerde.TabStop = true;
            this.radioVerde.Text = "Verde";
            this.radioVerde.UseVisualStyleBackColor = false;
            // 
            // radioArgintiu
            // 
            this.radioArgintiu.AutoSize = true;
            this.radioArgintiu.BackColor = System.Drawing.Color.Transparent;
            this.radioArgintiu.Location = new System.Drawing.Point(360, 169);
            this.radioArgintiu.Name = "radioArgintiu";
            this.radioArgintiu.Size = new System.Drawing.Size(77, 17);
            this.radioArgintiu.TabIndex = 17;
            this.radioArgintiu.TabStop = true;
            this.radioArgintiu.Text = "Argintiu";
            this.radioArgintiu.UseVisualStyleBackColor = false;
            // 
            // cBoxAerConditionat
            // 
            this.cBoxAerConditionat.AutoSize = true;
            this.cBoxAerConditionat.BackColor = System.Drawing.Color.Transparent;
            this.cBoxAerConditionat.Location = new System.Drawing.Point(197, 228);
            this.cBoxAerConditionat.Name = "cBoxAerConditionat";
            this.cBoxAerConditionat.Size = new System.Drawing.Size(127, 17);
            this.cBoxAerConditionat.TabIndex = 18;
            this.cBoxAerConditionat.Text = "Aer Conditionat";
            this.cBoxAerConditionat.UseVisualStyleBackColor = false;
            // 
            // cBoxOptiuniVolan
            // 
            this.cBoxOptiuniVolan.AutoSize = true;
            this.cBoxOptiuniVolan.BackColor = System.Drawing.Color.Transparent;
            this.cBoxOptiuniVolan.Location = new System.Drawing.Point(197, 251);
            this.cBoxOptiuniVolan.Name = "cBoxOptiuniVolan";
            this.cBoxOptiuniVolan.Size = new System.Drawing.Size(112, 17);
            this.cBoxOptiuniVolan.TabIndex = 19;
            this.cBoxOptiuniVolan.Text = "Optiuni Volan";
            this.cBoxOptiuniVolan.UseVisualStyleBackColor = false;
            // 
            // cBoxGeamuriElectrice
            // 
            this.cBoxGeamuriElectrice.AutoSize = true;
            this.cBoxGeamuriElectrice.BackColor = System.Drawing.Color.Transparent;
            this.cBoxGeamuriElectrice.Location = new System.Drawing.Point(360, 228);
            this.cBoxGeamuriElectrice.Name = "cBoxGeamuriElectrice";
            this.cBoxGeamuriElectrice.Size = new System.Drawing.Size(142, 17);
            this.cBoxGeamuriElectrice.TabIndex = 20;
            this.cBoxGeamuriElectrice.Text = "Geamuri Electrice";
            this.cBoxGeamuriElectrice.UseVisualStyleBackColor = false;
            // 
            // cBoxScaunePiele
            // 
            this.cBoxScaunePiele.AutoSize = true;
            this.cBoxScaunePiele.BackColor = System.Drawing.Color.Transparent;
            this.cBoxScaunePiele.Location = new System.Drawing.Point(197, 274);
            this.cBoxScaunePiele.Name = "cBoxScaunePiele";
            this.cBoxScaunePiele.Size = new System.Drawing.Size(109, 17);
            this.cBoxScaunePiele.TabIndex = 21;
            this.cBoxScaunePiele.Text = "Scaune Piele";
            this.cBoxScaunePiele.UseVisualStyleBackColor = false;
            // 
            // cBoxNavigatie
            // 
            this.cBoxNavigatie.AutoSize = true;
            this.cBoxNavigatie.BackColor = System.Drawing.Color.Transparent;
            this.cBoxNavigatie.Location = new System.Drawing.Point(360, 251);
            this.cBoxNavigatie.Name = "cBoxNavigatie";
            this.cBoxNavigatie.Size = new System.Drawing.Size(88, 17);
            this.cBoxNavigatie.TabIndex = 22;
            this.cBoxNavigatie.Text = "Navigatie";
            this.cBoxNavigatie.UseVisualStyleBackColor = false;
            // 
            // cBoxCutieAutomata
            // 
            this.cBoxCutieAutomata.AutoSize = true;
            this.cBoxCutieAutomata.BackColor = System.Drawing.Color.Transparent;
            this.cBoxCutieAutomata.Location = new System.Drawing.Point(360, 274);
            this.cBoxCutieAutomata.Name = "cBoxCutieAutomata";
            this.cBoxCutieAutomata.Size = new System.Drawing.Size(126, 17);
            this.cBoxCutieAutomata.TabIndex = 23;
            this.cBoxCutieAutomata.Text = "Cutie Automata";
            this.cBoxCutieAutomata.UseVisualStyleBackColor = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(125, 353);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 29;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(197, 11);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(167, 21);
            this.txtFirma.TabIndex = 6;
            // 
            // cBoxAnFabricatie
            // 
            this.cBoxAnFabricatie.FormattingEnabled = true;
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
            this.cBoxAnFabricatie.Location = new System.Drawing.Point(197, 63);
            this.cBoxAnFabricatie.Name = "cBoxAnFabricatie";
            this.cBoxAnFabricatie.Size = new System.Drawing.Size(167, 21);
            this.cBoxAnFabricatie.TabIndex = 30;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(94, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 36);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseClick);
            // 
            // btnNrMasini
            // 
            this.btnNrMasini.Location = new System.Drawing.Point(360, 369);
            this.btnNrMasini.Name = "btnNrMasini";
            this.btnNrMasini.Size = new System.Drawing.Size(99, 36);
            this.btnNrMasini.TabIndex = 33;
            this.btnNrMasini.Text = "Serie Masina";
            this.btnNrMasini.UseVisualStyleBackColor = true;
            this.btnNrMasini.Click += new System.EventHandler(this.btnNrMasini_Click);
            // 
            // lblNrMasini
            // 
            this.lblNrMasini.AutoSize = true;
            this.lblNrMasini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNrMasini.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNrMasini.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrMasini.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblNrMasini.Location = new System.Drawing.Point(530, 4);
            this.lblNrMasini.Name = "lblNrMasini";
            this.lblNrMasini.Size = new System.Drawing.Size(2, 23);
            this.lblNrMasini.TabIndex = 34;
            // 
            // lBoxAfisare
            // 
            this.lBoxAfisare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lBoxAfisare.FormattingEnabled = true;
            this.lBoxAfisare.Location = new System.Drawing.Point(530, 51);
            this.lBoxAfisare.Name = "lBoxAfisare";
            this.lBoxAfisare.Size = new System.Drawing.Size(373, 355);
            this.lBoxAfisare.TabIndex = 31;
            this.lBoxAfisare.SelectedIndexChanged += new System.EventHandler(this.lBoxAfisare_SelectedIndexChanged);
            // 
            // lblDeconectare
            // 
            this.lblDeconectare.AutoSize = true;
            this.lblDeconectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeconectare.Location = new System.Drawing.Point(785, 8);
            this.lblDeconectare.Name = "lblDeconectare";
            this.lblDeconectare.Size = new System.Drawing.Size(89, 13);
            this.lblDeconectare.TabIndex = 35;
            this.lblDeconectare.Text = "Deconectare";
            this.lblDeconectare.Click += new System.EventHandler(this.lblDeconectare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TargDeMasiniForm.Properties.Resources.logOutPng;
            this.pictureBox1.Location = new System.Drawing.Point(880, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.pctAfiseaza.Click += new System.EventHandler(this.pctAfiseaza_Click);
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
            this.pctAdauga.Click += new System.EventHandler(this.pctAdauga_Click);
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
            this.pctModifica.Click += new System.EventHandler(this.pctModifica_Click);
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
            this.panelMeniu.TabIndex = 37;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(0, 0);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 39;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(0, 0);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.TabIndex = 39;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(0, 0);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 38;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(0, 0);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 40;
            // 
            // OptiuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TargDeMasiniForm.Properties.Resources.bkgOptiuni1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDeconectare);
            this.Controls.Add(this.lblNrMasini);
            this.Controls.Add(this.btnNrMasini);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lBoxAfisare);
            this.Controls.Add(this.cBoxAnFabricatie);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cBoxCutieAutomata);
            this.Controls.Add(this.cBoxNavigatie);
            this.Controls.Add(this.cBoxScaunePiele);
            this.Controls.Add(this.cBoxGeamuriElectrice);
            this.Controls.Add(this.cBoxOptiuniVolan);
            this.Controls.Add(this.cBoxAerConditionat);
            this.Controls.Add(this.radioArgintiu);
            this.Controls.Add(this.radioVerde);
            this.Controls.Add(this.radioAlbastru);
            this.Controls.Add(this.radioRosu);
            this.Controls.Add(this.radioNegru);
            this.Controls.Add(this.radioAlb);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblAnFabricatie);
            this.Controls.Add(this.lblCuloare);
            this.Controls.Add(this.lblOptiuni);
            this.Controls.Add(this.lblFirma);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OptiuniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Car Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).EndInit();
            this.panelMeniu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblOptiuni;
        private System.Windows.Forms.Label lblCuloare;
        private System.Windows.Forms.Label lblAnFabricatie;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.RadioButton radioAlb;
        private System.Windows.Forms.RadioButton radioNegru;
        private System.Windows.Forms.RadioButton radioRosu;
        private System.Windows.Forms.RadioButton radioAlbastru;
        private System.Windows.Forms.RadioButton radioVerde;
        private System.Windows.Forms.RadioButton radioArgintiu;
        private System.Windows.Forms.CheckBox cBoxAerConditionat;
        private System.Windows.Forms.CheckBox cBoxOptiuniVolan;
        private System.Windows.Forms.CheckBox cBoxGeamuriElectrice;
        private System.Windows.Forms.CheckBox cBoxScaunePiele;
        private System.Windows.Forms.CheckBox cBoxNavigatie;
        private System.Windows.Forms.CheckBox cBoxCutieAutomata;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.ComboBox cBoxAnFabricatie;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNrMasini;
        private System.Windows.Forms.Label lblNrMasini;
        private System.Windows.Forms.ListBox lBoxAfisare;
        private System.Windows.Forms.Label lblDeconectare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctAfiseaza;
        private System.Windows.Forms.PictureBox pctAdauga;
        private System.Windows.Forms.PictureBox pctCauta;
        private System.Windows.Forms.PictureBox pctModifica;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdauga;
    }
}