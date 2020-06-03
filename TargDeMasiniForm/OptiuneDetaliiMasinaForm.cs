//Nume: Dascaliuc Adi       Grupa: 3123b
using LiveCharts;
using LiveCharts.Wpf;
using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NivelAcces;

namespace TargDeMasiniForm
{
    public partial class OptiuneDetaliiMasinaForm : Form
    {
        public OptiuneDetaliiMasinaForm(Masina masina)
        {
            IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
            List<Masina> msn = adminMasini.GetMasiniIndex(masina.IdMasina - 1);
            Masina m = msn.Last();
            InitializeComponent();

            lblFirma.Text = "Firma: " + m.NumeFirma;
            lblModel.Text = "Model: " + m.Model;
            lblPretCurent.Text = "Pret: " + m.Pret + "$";
            pictureMasina.ImageLocation = m.ImageLocation;
            foreach (string proprietar in m.istoricProprietari)
            {
                lblProprietar.Text += "Nume Proprietar: " + proprietar + "\n";
                flowLayoutAfisare.Controls.Add(lblProprietar);
            }

            
                chartPreturi.Series = new SeriesCollection
           {
               new LineSeries
               {
                   Values = m.istoricPreturi
               }
           };
            

            radioGraficPret.Checked = true;
        }

        private void radioIstoricProprietari_CheckedChanged(object sender, EventArgs e)
        {
            lblTitlu.Text = "Istoric Proprietari";
            flowLayoutAfisare.Show();
            chartPreturi.Hide();
        }

        private void radioGraficPret_CheckedChanged(object sender, EventArgs e)
        {
            lblTitlu.Text = "Grafic Preturi";
            //flowLayoutAfisare.Hide();
            chartPreturi.Show();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
