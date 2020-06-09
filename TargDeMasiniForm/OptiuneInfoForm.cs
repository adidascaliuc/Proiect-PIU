//Nume: Dascaliuc Adi       Grupa: 3123b
using Modele;
using NivelAcces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing;

namespace TargDeMasiniForm
{
    public partial class OptiuneInfoForm : Form
    {
        public const int FORMAAFISARE = 1;
        public const int FORMAMYCARS = 2;

        public List<string> optiuniSelectate = new List<string>();
        public static Persoana InfoPersoana = null;
        IStocareDataPersoane adminPersoane = StocareFactoryPersoane.GetAdministratorStocare();
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();

        public OptiuneInfoForm(Persoana p)
        {
            InitializeComponent();
            if (p != null)
            {
                lblNume.Text = "Nume: " + p.Nume;
                lblPrenume.Text = "Prenume: " + p.Prenume;
                lblUsername.Text = "Username: " + p.Username;
                lblBuget.Text = "Buget: " + p.Buget + "$";
                try
                {
                    pictureUserPhoto.Image = Image.FromFile(@p.ImageLocation);
                }
                catch
                {
                    pictureUserPhoto.Image = pictureUserPhoto.ErrorImage;
                }

            }
            else
            {
                MessageBox.Show("Eroare");
            }
            InfoPersoana = p;
        }


        private void pctModifica_Click(object sender, EventArgs e)
        {
            new OptiuneAfiseazaForm().Show();
            this.Hide();
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
            new OptiuneAfiseazaForm().Show();
            this.Hide();
        }


        private void pctAdauga_Click_1(object sender, EventArgs e)
        {
            new OptiuneAdaugareForm().Show();
            this.Hide();

        }

        private void pctCauta_Click(object sender, EventArgs e)
        {
            new OptiuneCautaForm().Show();
            this.Hide();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            List<Persoana> persoane = adminPersoane.GetPersoane();
            string imageLocation = "";
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = fileDialog.FileName;
                    pictureUserPhoto.ImageLocation = imageLocation;

                    foreach (Persoana p in persoane)
                    {
                        if (p.Username == LoginForm.infoPersoana.Username)
                        {
                            p.ImageLocation = imageLocation;
                            adminPersoane.UpdatePersoana(p);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("A aparut o eroare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaBuget_Click(object sender, EventArgs e)
        {
            List<Persoana> persoane = adminPersoane.GetPersoane();
            string buget;
            bool ok;
            do
            {
                ok = true;
                buget = Interaction.InputBox("Introduceti suma: ", "Adaugare fonduri");
                if (buget.Length == 0)
                {
                    buget = "0";
                    break;
                }
                else if (double.TryParse(buget, out double result) == false)
                {
                    MessageBox.Show("Introduceti date valide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ok = false;
                }
                if (double.TryParse(buget, out double rezultat) == true)
                {
                    if (Convert.ToDouble(buget) < 0)
                    {
                        MessageBox.Show("Introduceti o suma pozitiva!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ok = false;
                    }
                }

            } while (ok == false);

            foreach (Persoana p in persoane)
            {
                if (p.Username == LoginForm.infoPersoana.Username)
                {
                    p.Buget += Convert.ToDouble(buget);
                    adminPersoane.UpdatePersoana(p);
                    LoginForm.infoPersoana.Buget += Convert.ToDouble(buget);
                    lblBuget.Text = "Buget: " + p.Buget + "$";
                }
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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            List<Persoana> persoane = adminPersoane.GetPersoane();
            string newPassword;
            bool parolaCorecta;
            do
            {
                newPassword = Interaction.InputBox("Introduceti noua parola:", "Change Password");
                parolaCorecta = true;
                if (newPassword.Length == 0)
                {
                    newPassword = LoginForm.infoPersoana.Password;
                    break;
                }
                if (newPassword.Length < 5)
                {
                    MessageBox.Show("Parola trebuie sa contina cel putin 5 caractere", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    parolaCorecta = false;
                }

                if (newPassword == LoginForm.infoPersoana.Password)
                {
                    MessageBox.Show("Aveti deja setata aceasta parola", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parolaCorecta = false;
                }

            } while (parolaCorecta == false);

            if (newPassword == LoginForm.infoPersoana.Password)
            {
                MessageBox.Show("Parola a ramas neschimbata!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Noua parola este: " + newPassword, "Info Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (Persoana p in persoane)
            {
                if (p.Username == LoginForm.infoPersoana.Username)
                {
                    p.Password = newPassword;
                    LoginForm.infoPersoana.Password = newPassword;
                    adminPersoane.UpdatePersoana(p);
                }
            }
        }

        private void pictureMyCars_Click(object sender, EventArgs e)
        {
            List<Masina> masinileMele = adminMasini.GetMasiniUser(OptiuneInfoForm.InfoPersoana.NumeComplet);
            if(masinileMele.Count == 0)
            {
                MessageBox.Show("Nu aveti masini adaugate sau achizitionate!", "Info Masini", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new MyCarsForm(masinileMele).ShowDialog();
            }
        }
    }
}