using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modele;
using NivelAcces;

namespace TargDeMasiniForm
{
    public partial class OptiuneCautaForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();
        public OptiuneCautaForm()
        {
            InitializeComponent();
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
            OptiuniInfo optForm = new OptiuniInfo();
            optForm.Show();
            this.Hide();
        }

        private void pctAdauga_Click(object sender, EventArgs e)
        {
            OptiuneAdaugareForm adaugaForm = new OptiuneAdaugareForm();
            adaugaForm.Show();
            this.Hide();
        }

        private void pctCauta_Click(object sender, EventArgs e)
        {

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
        }

        private void pctModifica_Click(object sender, EventArgs e)
        {
            try
            {
                List<Masina> masini = adminMasini.GetMasiniIndex(Convert.ToInt32(dataGridAfisare.SelectedRows[0].Cells[0].Value) - 1);
                if (masini != null)
                {
                    Masina m = masini.Last();
                    OptiuneModificaForm modForm = new OptiuneModificaForm(m, 0);
                    modForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Selectati o masina pentru modificare!!!", "Eroare", MessageBoxButtons.OK);
            }
        }

        private void lblDeconectare_Click(object sender, EventArgs e)
        {
            PaginaStartForm startForm = new PaginaStartForm();
            startForm.Show();
            this.Hide();
        }

        private void pictureDeconectare_Click(object sender, EventArgs e)
        {
            PaginaStartForm startForm = new PaginaStartForm();
            startForm.Show();
            this.Hide();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            bool ok = false;
            dataGridAfisare.DataSource = null;
            List<Masina> masini = adminMasini.GetMasini();
            List<Masina> masiniGasite = new List<Masina>();
            foreach(Masina m in masini)
            {
                if (m.NumeFirma == txtFirma.Text && m.Model == txtModel.Text)
                {
                    ok = true;
                    masiniGasite.Add(m);
                }
             
            }
            if(ok == false)
            {
                MessageBox.Show("Nu exista aceasta masina!!!");
            }
            else
            {
                dataGridAfisare.DataSource = masiniGasite;
            }
        }
    }
}
