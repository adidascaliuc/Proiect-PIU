namespace TargDeMasiniForm
{
    partial class OptiuneDetaliiMasinaForm
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
            this.pictureMasina = new System.Windows.Forms.PictureBox();
            this.lblFirma = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.lblPretCurent = new MetroFramework.Controls.MetroLabel();
            this.lblTitlu = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutAfisare = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProprietar = new MetroFramework.Controls.MetroLabel();
            this.radioIstoricProprietari = new MetroFramework.Controls.MetroRadioButton();
            this.radioGraficPret = new MetroFramework.Controls.MetroRadioButton();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.chartPreturi = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMasina)).BeginInit();
            this.flowLayoutAfisare.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureMasina
            // 
            this.pictureMasina.Image = global::TargDeMasiniForm.Properties.Resources.presetCarPng1;
            this.pictureMasina.Location = new System.Drawing.Point(12, 12);
            this.pictureMasina.Name = "pictureMasina";
            this.pictureMasina.Size = new System.Drawing.Size(373, 237);
            this.pictureMasina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMasina.TabIndex = 1;
            this.pictureMasina.TabStop = false;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.CustomBackground = true;
            this.lblFirma.Location = new System.Drawing.Point(13, 256);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(50, 19);
            this.lblFirma.TabIndex = 2;
            this.lblFirma.Text = "Firma: ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.CustomBackground = true;
            this.lblModel.Location = new System.Drawing.Point(11, 299);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 19);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model: ";
            // 
            // lblPretCurent
            // 
            this.lblPretCurent.AutoSize = true;
            this.lblPretCurent.CustomBackground = true;
            this.lblPretCurent.Location = new System.Drawing.Point(13, 338);
            this.lblPretCurent.Name = "lblPretCurent";
            this.lblPretCurent.Size = new System.Drawing.Size(83, 19);
            this.lblPretCurent.TabIndex = 4;
            this.lblPretCurent.Text = "Pret Curent: ";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.CustomBackground = true;
            this.lblTitlu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitlu.Location = new System.Drawing.Point(712, 12);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(130, 25);
            this.lblTitlu.TabIndex = 5;
            this.lblTitlu.Text = "Variatia pretului";
            // 
            // flowLayoutAfisare
            // 
            this.flowLayoutAfisare.Controls.Add(this.chartPreturi);
            this.flowLayoutAfisare.Controls.Add(this.lblProprietar);
            this.flowLayoutAfisare.Location = new System.Drawing.Point(511, 40);
            this.flowLayoutAfisare.Name = "flowLayoutAfisare";
            this.flowLayoutAfisare.Size = new System.Drawing.Size(511, 365);
            this.flowLayoutAfisare.TabIndex = 6;
            // 
            // lblProprietar
            // 
            this.lblProprietar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProprietar.AutoSize = true;
            this.lblProprietar.CustomBackground = true;
            this.lblProprietar.Location = new System.Drawing.Point(3, 362);
            this.lblProprietar.Name = "lblProprietar";
            this.lblProprietar.Size = new System.Drawing.Size(0, 0);
            this.lblProprietar.TabIndex = 0;
            // 
            // radioIstoricProprietari
            // 
            this.radioIstoricProprietari.AutoSize = true;
            this.radioIstoricProprietari.CustomBackground = true;
            this.radioIstoricProprietari.Location = new System.Drawing.Point(392, 58);
            this.radioIstoricProprietari.Name = "radioIstoricProprietari";
            this.radioIstoricProprietari.Size = new System.Drawing.Size(113, 15);
            this.radioIstoricProprietari.TabIndex = 7;
            this.radioIstoricProprietari.TabStop = true;
            this.radioIstoricProprietari.Text = "Istoric Proprietari";
            this.radioIstoricProprietari.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioIstoricProprietari.UseVisualStyleBackColor = true;
            this.radioIstoricProprietari.CheckedChanged += new System.EventHandler(this.radioIstoricProprietari_CheckedChanged);
            // 
            // radioGraficPret
            // 
            this.radioGraficPret.AutoSize = true;
            this.radioGraficPret.CustomBackground = true;
            this.radioGraficPret.Location = new System.Drawing.Point(391, 93);
            this.radioGraficPret.Name = "radioGraficPret";
            this.radioGraficPret.Size = new System.Drawing.Size(78, 15);
            this.radioGraficPret.TabIndex = 8;
            this.radioGraficPret.TabStop = true;
            this.radioGraficPret.Text = "Grafic Pret";
            this.radioGraficPret.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioGraficPret.UseVisualStyleBackColor = true;
            this.radioGraficPret.CheckedChanged += new System.EventHandler(this.radioGraficPret_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(430, 376);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chartPreturi
            // 
            this.chartPreturi.Location = new System.Drawing.Point(3, 3);
            this.chartPreturi.Name = "chartPreturi";
            this.chartPreturi.Size = new System.Drawing.Size(502, 356);
            this.chartPreturi.TabIndex = 1;
            this.chartPreturi.Text = "cartesianChart1";
            // 
            // OptiuneDetaliiMasinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 411);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.radioGraficPret);
            this.Controls.Add(this.radioIstoricProprietari);
            this.Controls.Add(this.flowLayoutAfisare);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblPretCurent);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.pictureMasina);
            this.Name = "OptiuneDetaliiMasinaForm";
            this.Text = "OptiuneDetaliiMasinaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMasina)).EndInit();
            this.flowLayoutAfisare.ResumeLayout(false);
            this.flowLayoutAfisare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureMasina;
        private MetroFramework.Controls.MetroLabel lblFirma;
        private MetroFramework.Controls.MetroLabel lblModel;
        private MetroFramework.Controls.MetroLabel lblPretCurent;
        private MetroFramework.Controls.MetroLabel lblTitlu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAfisare;
        private MetroFramework.Controls.MetroRadioButton radioIstoricProprietari;
        private MetroFramework.Controls.MetroRadioButton radioGraficPret;
        private MetroFramework.Controls.MetroLabel lblProprietar;
        private MetroFramework.Controls.MetroButton btnOk;
        private LiveCharts.WinForms.CartesianChart chartPreturi;
    }
}