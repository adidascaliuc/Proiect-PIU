using Modele;
using NivelAcces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TargDeMasiniForm
{
    public partial class OptiuniInfo : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();

        public OptiuniInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        //private void btnCautare_Click(object sender, EventArgs e)
        //{
        //    lBoxAfisare.Items.Clear();

        //    List<Masina> masini = adminMasini.GetMasini(out int nrMasini);
        //    Boolean gasit = false;

        //    foreach (Masina m in masini)
        //    {
        //        if (m != null)
        //        {
        //            if (m.NumeFirma == txtFirma.Text && m.Model == txtModel.Text)
        //            {
        //                lBoxAfisare.Items.Add(m.ConversieLaSir());
        //                gasit = true;
        //            }
        //        }
        //    }
        //    if (gasit == false)
        //    {
        //        lBoxAfisare.Items.Add("Nu exista o astfel de masina!");
        //    }
        //}
                  
        private void pctModifica_Click(object sender, EventArgs e)
        {

            OptiuneAfiseazaForm optAfisare = new OptiuneAfiseazaForm();
            optAfisare.Show();
            this.Hide();
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
          
            OptiuneAfiseazaForm optAfiseaza = new OptiuneAfiseazaForm();
            optAfiseaza.Show();
            this.Hide();
        }

        //private void pctCauta_Click(object sender, EventArgs e)
        //{
        //    OptiuneCautaForm cautaForm = new OptiuneCautaForm();
        //    cautaForm.Show();
        //    this.Hide();
        //    lBoxAfisare.Items.Clear();

        //    List<Masina> masini = adminMasini.GetMasini(out int nrMasini);
        //    Boolean gasit = false;

        //    foreach (Masina m in masini)
        //    {
        //        if (m != null)
        //        {
        //            if (m.NumeFirma == txtFirma.Text && m.Model == txtModel.Text)
        //            {
        //                lBoxAfisare.Items.Add(m.ConversieLaSir());
        //                gasit = true;
        //            }
        //        }
        //    }
        //    if (gasit == false)
        //    {
        //        MessageBox.Show("Nu exista o astfel de masina","Cautare", MessageBoxButtons.OK);
        //    }
        //}

        //private void pctAdauga_Click(object sender, EventArgs e)
        //{
        //    int culoare = ValidareCuloare();
        //    int optiuni = ValidareOptiuni();

        //    int validare = ValidareMasina();

        //    if (validare == 0)
        //    {
        //        Masina m = new Masina(txtFirma.Text, txtModel.Text, Convert.ToInt32(cBoxAnFabricatie.Text), culoare, optiuni, Convert.ToDouble(txtPret.Text));
        //        adminMasini.AddMasina(m);
        //        lblInfo.Text = "Masina a fost adaugata cu succes!";
        //    }
        //    else
        //    {
        //        CodEroareMasina(validare);
        //    }
        //}

        private void pctAdauga_Click_1(object sender, EventArgs e)
        {
            OptiuneAdaugareForm adaugaForm = new OptiuneAdaugareForm();
            adaugaForm.Show();
            this.Hide();
        }

        private void pctAfiseaza_Click_1(object sender, EventArgs e)
        {
            OptiuneAfiseazaForm afiseazaForm = new OptiuneAfiseazaForm();
            afiseazaForm.Show();
            this.Hide();
        }

        private void pctCauta_Click(object sender, EventArgs e)
        {
            OptiuneCautaForm optiuneCauta = new OptiuneCautaForm();
            optiuneCauta.Show();
            this.Hide();
        }

        private void pctModifica_Click_1(object sender, EventArgs e)
        {
            OptiuneAfiseazaForm afiseazaForm = new OptiuneAfiseazaForm();
            afiseazaForm.Show();
            this.Hide();
        }
    }

}