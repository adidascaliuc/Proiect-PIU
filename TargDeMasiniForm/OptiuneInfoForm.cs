using Modele;
using NivelAcces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TargDeMasiniForm
{
    public partial class OptiuneInfoForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();

        public OptiuneInfoForm(Persoana p)
        {            
            InitializeComponent();
            lblNume.Text = "Nume: " + p.Nume;
            lblPrenume.Text = "Prenume: " + p.Prenume;
            lblUsername.Text = "Username: " + p.Username;
            lblBuget.Text = "Buget: " + p.Buget;           
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
            Program.infoForm.Show();
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
    }

}