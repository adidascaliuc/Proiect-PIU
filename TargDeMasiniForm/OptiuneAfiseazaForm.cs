using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modele;
using NivelAcces;

namespace TargDeMasiniForm
{
    public partial class OptiuneAfiseazaForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();
        public OptiuneAfiseazaForm()
        {
            InitializeComponent();
        }

        

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            List<Masina> masini = adminMasini.GetMasini();
            dataGridAfisare.DataSource = null;
            dataGridAfisare.DataSource = masini;
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

        private void pctAdauga_Click(object sender, EventArgs e)
        {
            OptiuneAdaugareForm adaugaForm = new OptiuneAdaugareForm();
            adaugaForm.Show();
            this.Hide();
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
            OptiuneAfiseazaForm afiseazaForm = new OptiuneAfiseazaForm();
            afiseazaForm.Show();
            this.Hide();
        }

        private void pctCauta_Click(object sender, EventArgs e)
        {
            OptiuneCautaForm cautaForm = new OptiuneCautaForm();
            cautaForm.Show();
            this.Hide();
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

        private void salveazaFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void salveazaRaport(List<Masina> masini, string NumeFisier)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Masina msn in masini)
                    {                                            
                            swFisierText.WriteLine(msn.ConversieLaSir());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        private void salveazaFisierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<Masina> masini = adminMasini.GetMasini();

            saveFile.ShowDialog();
            salveazaRaport(masini, saveFile.FileName);
        }
    }
}
