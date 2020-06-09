//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Modele;
using NivelAcces;

namespace TargDeMasiniForm
{
    
    public partial class OptiuneAfiseazaForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        IStocareDataPersoane adminPersoane = StocareFactoryPersoane.GetAdministratorStocare();
        public static OptiuneAfiseazaForm afis = new OptiuneAfiseazaForm();
        public List<string> optiuniSelectate = new List<string>();
        public OptiuneAfiseazaForm()
        {
            InitializeComponent();
            radioViewList.Checked = true;
            populateForm();
            afis = this;
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

        private void pctAdauga_Click(object sender, EventArgs e)
        {
            new OptiuneAdaugareForm().Show();
            this.Hide();
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
            new OptiuneAfiseazaForm().Show();
            this.Hide();
        }

        private void pctCauta_Click(object sender, EventArgs e)
        {
            new OptiuneCautaForm().Show();
            this.Hide();
            
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

        private void salveazaRaport(List<Masina> masini, string NumeFisier)
        {
            try
            {
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

            try
            {
                saveFile.ShowDialog();
                salveazaRaport(masini, saveFile.FileName);
            }
            catch
            {
                MessageBox.Show("S-a produs o eroare, va rugam sa reincercati!", "Selectare fisier esuata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCautareData_Click(object sender, EventArgs e)
        {
            List<Masina> masini = adminMasini.GetMasini();
            List<Masina> masiniGasite = new List<Masina>();
            bool gasit = false;
            int nrMasini = 0;

            foreach (Masina m in masini)
            {
                if ((m.DataActualizare >= dateTimePicker1.Value) && (m.DataActualizare <= dateTimePicker2.Value))
                {
                    masiniGasite.Add(m);
                    gasit = true;
                    nrMasini++;
                }
            }
            if (gasit == true)
            {
                MessageBox.Show("Au fost gasite " + nrMasini + " masini care corespund cu data cautata.", "Info Cautarte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridAfisare.DataSource = masiniGasite;

                flowLayoutAfisare.Controls.Clear();
                foreach(Masina m in masiniGasite)
                {
                    flowLayoutAfisare.Controls.Add(new ListaMasiniForm(m, (int)ModAfisare.FORMAAFISARE));
                }
            }
            else
            {
                MessageBox.Show("Nu sunt masini care sa corespunda cu data cautata!", "Info Cautare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureInfo_Click(object sender, EventArgs e)
        {
            LoginForm.infoForm.Show();
            this.Hide();
        }

        public void btnCumpara_Click(object sender, EventArgs e)
        {
            List<Persoana> persoane = adminPersoane.GetPersoane();
            try
            {
                List<Masina> masini = adminMasini.GetMasiniIndex(Convert.ToInt32(dataGridAfisare.SelectedRows[0].Cells[0].Value) - 1);
                if (masini.Last() != null)
                {

                    if (masini.Last().NumeProprietar == OptiuneInfoForm.InfoPersoana.NumeComplet)
                    {
                        MessageBox.Show("Nu puteti cumpara o masina care va apartine!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (OptiuneInfoForm.InfoPersoana.Buget < masini.Last().Pret)
                        {
                            MessageBox.Show("Nu aveti suficiente fonduri pentru a cumpara aceasta masina!", "Fonduri insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            OptiuneInfoForm.InfoPersoana.Buget -= masini.Last().Pret;
                            adminPersoane.UpdatePersoana(OptiuneInfoForm.InfoPersoana);
                            LoginForm.infoForm.lblBuget.Text = "Buget: " + OptiuneInfoForm.InfoPersoana.Buget + "$";

                            foreach (Persoana p in persoane)
                            {
                                if (p.NumeComplet == masini.Last().NumeProprietar)
                                {
                                    p.Buget += masini.Last().Pret;
                                    adminPersoane.UpdatePersoana(p);
                                }
                            }
                            masini.Last().NumeProprietar = OptiuneInfoForm.InfoPersoana.NumeComplet;
                            masini.Last().istoricProprietari.Add(masini.Last().NumeProprietar);
                            adminMasini.UpdateMasina(masini.Last());
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Selectati o masina!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                populateForm();               
            }
        }
        public void populateForm()
        {
            flowLayoutAfisare.Controls.Clear();
            List<Masina> masini = adminMasini.GetMasini();
            List<ListaMasiniForm> listaMasini = new List<ListaMasiniForm>();
            foreach (Masina m in masini)
            {
                listaMasini.Add(new ListaMasiniForm(m, (int)ModAfisare.FORMAAFISARE));
                flowLayoutAfisare.Controls.Add(listaMasini.Last());

            }

            List<Masina> masiniNou = adminMasini.GetMasini();
            dataGridAfisare.DataSource = masiniNou.Select(m => new
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

        private void radioViewTabel_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutAfisare.Hide();
            dataGridAfisare.Show();
            populateForm();
            btnBuy.Show();

        }

        private void radioViewList_CheckedChanged(object sender, EventArgs e)
        {
            dataGridAfisare.Hide();
            flowLayoutAfisare.Show();
            populateForm();
            btnBuy.Hide();
        }
    }
}
