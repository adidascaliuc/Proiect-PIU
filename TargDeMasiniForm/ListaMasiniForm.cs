//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Modele;
using NivelAcces;

namespace TargDeMasiniForm
{
    public partial class ListaMasiniForm : UserControl
    {       

        public static bool inForma;
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        IStocareDataPersoane adminPersoane = StocareFactoryPersoane.GetAdministratorStocare();

        Masina masina = null;
        public ListaMasiniForm(Masina m, int modForma)
        { 
            InitializeComponent();
            if(modForma == (int)ModAfisare.FORMAMYCARS)
            {
                btnCumpara.Hide();
            }
            else if(modForma == (int)ModAfisare.FORMAAFISARE)
            {
                btnCumpara.Show();
            }
            masina = m;
            lblFirma.Text = "Firma: " + m.NumeFirma;
            lblModel.Text = "Model: " + m.Model;
            lblData.Text = "Data: " + m.DataActualizare.ToString();
            lblPret.Text = "Pret: " + m.Pret.ToString() + "$";
            lblProprietar.Text = "Proprietar: " + m.NumeProprietar;
            try
            {

                pictureMasina.Image = Image.FromFile(@m.ImageLocation);
            }
            catch
            {
                pictureMasina.Image = pictureMasina.ErrorImage;
            }
            lblOptiuni.Text = "Optiuni: ";
            int optRand = 0;
            foreach (string opt in m.optiuniInt.Split(' '))
            {
                if (optRand == 2)
                {
                    lblOptiuni.Text += "\n            ";
                    optRand = 0;
                }

                if (opt == "1")
                {
                    lblOptiuni.Text += "Aer Conditionat, ";
                    optRand++;
                }
                if (opt == "2")
                {
                    lblOptiuni.Text += "Optiuni Volan, ";
                    optRand++;
                }
                if (opt == "4")
                {
                    lblOptiuni.Text += "Scaune Piele, ";
                    optRand++;
                }
                if (opt == "8")
                {
                    lblOptiuni.Text += "Geamuri Electrice, ";
                    optRand++;
                }
                if (opt == "16")
                {
                    lblOptiuni.Text += "Navigatie, ";
                    optRand++;
                }
                if (opt == "32")
                {
                    lblOptiuni.Text += "Cutie Automata, ";
                    optRand++;
                }
            }

            if(m.CULOARE.ToString() == "Alb")
            {
                pictureCuloare.BackColor = Color.White;
            }
            if (m.CULOARE.ToString() == "Albastru")
            {
                pictureCuloare.BackColor = Color.Blue;
            }
            if (m.CULOARE.ToString() == "Argintiu")
            {
                pictureCuloare.BackColor = Color.Silver;
            }
            if (m.CULOARE.ToString() == "Negru")
            {
                pictureCuloare.BackColor = Color.Black;
            }
            if (m.CULOARE.ToString() == "Rosu")
            {
                pictureCuloare.BackColor = Color.Red;
            }
            if (m.CULOARE.ToString() == "Verde")
            {
                pictureCuloare.BackColor = Color.Green;
            }
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            inForma = false;
            List<Persoana> persoane = adminPersoane.GetPersoane();
            try
            {
                List<Masina> masini = adminMasini.GetMasiniIndex(Convert.ToInt32(masina.IdMasina - 1));
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
                            inForma = true;

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
                            lblProprietar.Text = "Proprietar: " + masini.Last().NumeProprietar;
                            MessageBox.Show("Masina achizitionata cu succes!", "Info Cumparare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("S-a produs o eroare!", "Eroare selectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            List<Masina> msn = adminMasini.GetMasiniIndex(masina.IdMasina-1);
            if (msn.Last().NumeProprietar == OptiuneInfoForm.InfoPersoana.NumeComplet)
            {
                OptiuneModificaForm modificaForm = new OptiuneModificaForm(masina);
                modificaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu puteti modifica o masina care nu va apartine", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSerieMasina_Click(object sender, EventArgs e)
        {
            MessageBox.Show(masina.SerieMasina, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListaMasiniForm_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(37,37,37);
            lblFirma.BackColor = Color.FromArgb(37, 37, 37);
            lblModel.BackColor = Color.FromArgb(37, 37, 37);
            lblOptiuni.BackColor = Color.FromArgb(37, 37, 37);
            lblPret.BackColor = Color.FromArgb(37, 37, 37);
            lblData.BackColor = Color.FromArgb(37, 37, 37);
            lblProprietar.BackColor = Color.FromArgb(37, 37, 37);
            lblCuloare.BackColor = Color.FromArgb(37, 37, 37);

            lblCuloare.ForeColor = Color.White;
            lblData.ForeColor = Color.White;
            lblFirma.ForeColor = Color.White;
            lblModel.ForeColor = Color.White;
            lblOptiuni.ForeColor = Color.White;
            lblPret.ForeColor = Color.White;
            lblProprietar.ForeColor = Color.White;

        }

        private void ListaMasiniForm_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonFace;
            lblFirma.BackColor = SystemColors.ButtonFace;
            lblModel.BackColor = SystemColors.ButtonFace;
            lblOptiuni.BackColor = SystemColors.ButtonFace;
            lblPret.BackColor = SystemColors.ButtonFace;
            lblData.BackColor = SystemColors.ButtonFace;
            lblProprietar.BackColor = SystemColors.ButtonFace;
            lblCuloare.BackColor = SystemColors.ButtonFace;

            lblCuloare.ForeColor = Color.Black;
            lblData.ForeColor = Color.Black;
            lblFirma.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
            lblOptiuni.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblProprietar.ForeColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OptiuneDetaliiMasinaForm detaliiForm = new OptiuneDetaliiMasinaForm(masina);
            detaliiForm.ShowDialog();
        }
    }

}
