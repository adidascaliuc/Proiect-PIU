//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
            new OptiuneAfiseazaForm().Show();
            this.Hide();
        }

        private void pctAdauga_Click(object sender, EventArgs e)
        {
            new OptiuneAdaugareForm().Show();
            this.Hide();
        }



        private void pctModifica_Click(object sender, EventArgs e)
        {
            try
            {
                List<Masina> masini = adminMasini.GetMasiniIndex(Convert.ToInt32(dataGridAfisare.SelectedRows[0].Cells[0].Value) - 1);
                if (masini != null)
                {
                    Masina m = masini.Last();
                    if (OptiuneInfoForm.InfoPersoana.NumeComplet == m.NumeProprietar)
                    {
                        OptiuneModificaForm modForm = new OptiuneModificaForm(m);
                        modForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Doar proprietarul masinii are voie sa aduca modificari la aceasta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selectati o masina pentru modificare!!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDeconectare_Click(object sender, EventArgs e)
        {
            new PaginaStartForm().Show();
            this.Hide();
        }

        private void pictureDeconectare_Click(object sender, EventArgs e)
        {
            new PaginaStartForm().Show();
            this.Hide();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {

            bool ok = false;
            int nrMasini = 0;
            dataGridAfisare.DataSource = null;
            List<Masina> masini = adminMasini.GetMasini();
            List<Masina> masiniGasite = new List<Masina>();
            if (ValidareControale() == 0)
            {
                foreach (Masina m in masini)
                {
                    if (m.NumeFirma == comboFirma.Text && m.Model == comboModel.Text)
                    {
                        ok = true;
                        masiniGasite.Add(m);
                        nrMasini++;
                    }
                    if (m.NumeFirma == comboFirma.Text && comboModel.Text == string.Empty)
                    {
                        ok = true;
                        masiniGasite.Add(m);
                        nrMasini++;
                    }

                }

                if (ok == false)
                {
                    MessageBox.Show("Nu exista masini cu datele dumneavoastra de cautare!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Au fost gasite " + nrMasini + " masini!", "Info Cautare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridAfisare.DataSource = masiniGasite.Select(m => new
                    {
                        m.IdMasina,
                        m.NumeFirma,
                        m.Model,
                        m.AnFabricatie,
                        m.CULOARE,
                        m.OPTIUNI,
                        m.Pret,
                        m.DataActualizare,
                        m.NumeProprietar
                    }).ToList();


                }
            }
            else
            {
                MessageBox.Show("Completati campurile marcate cu rosu!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int ValidareControale()
        {
            if (comboFirma.Text == "")
            {
                lblFirma.BackColor = Color.Red;
            }
            if (comboModel.Text == "" && lblFirma.BackColor == Color.Red)
            {
                lblModel.BackColor = Color.Red;
            }

            if (comboFirma.Text == "" || comboModel.Text == "" && lblFirma.BackColor == Color.Red)
            {
                return 1;
            }
            return 0;
        }

        private void pictureInfo_Click(object sender, EventArgs e)
        {
            LoginForm.infoForm.Show();
            this.Hide();
        }

        private void comboFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFirma.BackColor = SystemColors.ButtonFace;
            lblModel.BackColor = SystemColors.ButtonFace;

            if (comboFirma.Text == "Audi")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("A4");
                comboModel.Items.Add("A5");
                comboModel.Items.Add("A6");
                comboModel.Items.Add("Q5");
                comboModel.Items.Add("Q7");
            }
            if (comboFirma.Text == "BMW")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Seria 5");
                comboModel.Items.Add("Seria 7");
                comboModel.Items.Add("X5");
                comboModel.Items.Add("6");
                comboModel.Items.Add("i8");
            }
            if (comboFirma.Text == "Ford")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Mustang");
                comboModel.Items.Add("Fiesta");
                comboModel.Items.Add("Tourneo Courier");
                comboModel.Items.Add("Ecosport");
                comboModel.Items.Add("Kuga");
            }
            if (comboFirma.Text == "Honda")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Civic Sedan");
                comboModel.Items.Add("Civic 5D");
                comboModel.Items.Add("Jazz");
                comboModel.Items.Add("Honda E");
                comboModel.Items.Add("CR-V HYBRID");
            }
            if (comboFirma.Text == "Hyundai")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("i10");
                comboModel.Items.Add("i30 Fastback");
                comboModel.Items.Add("Elantra");
                comboModel.Items.Add("KONA");
                comboModel.Items.Add("Santa Fe");
            }
            if (comboFirma.Text == "Lexus")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("RX");
                comboModel.Items.Add("NX");
                comboModel.Items.Add("LS");
                comboModel.Items.Add("CT");
                comboModel.Items.Add("IS");
            }
            if (comboFirma.Text == "Mercedes")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("S Class");
                comboModel.Items.Add("E Class");
                comboModel.Items.Add("CLA");
                comboModel.Items.Add("GLE Coupe");
                comboModel.Items.Add("GLE SUV");
            }
            if (comboFirma.Text == "Porche")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Cayman");
                comboModel.Items.Add("Boxter");
                comboModel.Items.Add("Panamera");
                comboModel.Items.Add("Carrera");
                comboModel.Items.Add("Cayenne");
            }
            if (comboFirma.Text == "Toyota")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Aygo");
                comboModel.Items.Add("Corola");
                comboModel.Items.Add("Proace Verso");
                comboModel.Items.Add("Prius");
                comboModel.Items.Add("C-HR facelift");
            }
            if (comboFirma.Text == "Volkswagen")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Polo");
                comboModel.Items.Add("Golf 5");
                comboModel.Items.Add("Golf 7");
                comboModel.Items.Add("T-Cross");
                comboModel.Items.Add("Tiguan");
            }
        }

    }
}

