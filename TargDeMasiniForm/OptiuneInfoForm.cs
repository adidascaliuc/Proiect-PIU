using Modele;
using NivelAcces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TargDeMasiniForm
{
    public partial class OptiuneInfoForm : Form
    { 
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();

        public OptiuneInfoForm(Persoana p)
        {
            InitializeComponent();
            if (p != null)
            {
                lblNume.Text = "Nume: " + LoginForm.infoPersoana.Nume;
                lblPrenume.Text = "Prenume: " + LoginForm.infoPersoana.Prenume;
                lblUsername.Text = "Username: " + LoginForm.infoPersoana.Username;
                lblBuget.Text = "Buget: " + LoginForm.infoPersoana.Buget;
            }
            else
            {
                MessageBox.Show("Eroare");
            }
        }        
                         
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


        private void pctAdauga_Click_1(object sender, EventArgs e)
        {
            OptiuneAdaugareForm adaugaForm = new OptiuneAdaugareForm();
            adaugaForm.Show();
            this.Hide();
        }
    
        private void pctCauta_Click(object sender, EventArgs e)
        {
            OptiuneCautaForm optiuneCauta = new OptiuneCautaForm();
            this.Hide();
            optiuneCauta.ShowDialog();
        }      

        private void pictureInfo_Click(object sender, EventArgs e)
        {
            LoginForm.infoForm.Show();
            this.Hide();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if(fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
                {
                    imageLocation = fileDialog.FileName;

                    pictureUserPhoto.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("A aparut o eroare!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaBuget_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBuget.Text, out double result))
            {
                LoginForm.infoPersoana.Buget += Convert.ToDouble(txtBuget.Text);
                lblBuget.Text = "Buget: " + LoginForm.infoPersoana.Buget.ToString() + "$";
            }
            else
            {
                MessageBox.Show("Introduceti date Valide","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuget_Enter(object sender, EventArgs e)
        {
             txtBuget.Text = "";
            
        }

        private void txtBuget_Leave(object sender, EventArgs e)
        {
            if(txtBuget.Text == "")
            {
                txtBuget.Text = "DOLARI";
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
    }
 }