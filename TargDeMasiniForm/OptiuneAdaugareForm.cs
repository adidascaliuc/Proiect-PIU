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
    public partial class OptiuneAdaugareForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();

        public OptiuneAdaugareForm()
        {
            InitializeComponent();
        }

        private int ValidareOptiuni()
        {
            int optiuni = 0;

            if (cBoxAerConditionat.Checked)
            {
                optiuni += 1;
            }
            if (cBoxOptiuniVolan.Checked)
            {
                optiuni += 2;
            }
            if (cBoxScaunePiele.Checked)
            {
                optiuni += 4;
            }
            if (cBoxGeamuriElectrice.Checked)
            {
                optiuni += 8;
            }
            if (cBoxNavigatie.Checked)
            {
                optiuni += 16;
            }
            if (cBoxCutieAutomata.Checked)
            {
                optiuni += 32;
            }

            return optiuni;
        }

        private int ValidareCuloare()
        {
            if (radioAlb.Checked)
            {
                return 1;
            }
            if (radioNegru.Checked)
            {
                return 2;
            }
            if (radioRosu.Checked)
            {
                return 3;
            }
            if (radioAlbastru.Checked)
            {
                return 4;
            }
            if (radioVerde.Checked)
            {
                return 5;
            }
            if (radioArgintiu.Checked)
            {
                return 6;
            }

            return 0;
        }

        
        private int ValidareMasina()
        {
            if (txtFirma.Text == string.Empty)
            {
                txtFirma.BackColor = Color.Red;
                
            }
            if (txtModel.Text == string.Empty)
            {
                txtModel.BackColor = Color.Red;
               
            }
            if (cBoxAnFabricatie.Text == string.Empty)
            {
                cBoxAnFabricatie.BackColor = Color.Red;
                
            }
            if (radioAlb.Enabled == false || radioAlbastru.Enabled == false || radioArgintiu.Enabled == false || radioNegru.Enabled == false || radioRosu.Enabled == false || radioVerde.Enabled == false)
            {
                lblCuloare.BackColor = Color.Red;
                
            }
            if (cBoxAerConditionat.Checked == false && cBoxCutieAutomata.Checked == false && cBoxGeamuriElectrice.Checked == false && cBoxNavigatie.Checked == false && cBoxOptiuniVolan.Checked == false && cBoxScaunePiele.Checked == false)
            {
                //lblOptiuni.BackColor = Color.Red;
                
            }
            if (txtPret.Text == string.Empty)
            {
                txtPret.BackColor = Color.Red;
                
            }

            if(txtFirma.BackColor == Color.Red || txtModel.BackColor == Color.Red ||
                cBoxAnFabricatie.BackColor == Color.Red || lblCuloare.BackColor == Color.Red ||
                lblOptiuni.BackColor == Color.Red || txtPret.BackColor == Color.Red)
            {
                return 1;
            }
            return 0;
        }

        private void lBoxAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Masina> masini = adminMasini.GetMasiniIndex(lBoxAfisare.SelectedIndex);

        }

        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirma.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtPret.Text = string.Empty;

            cBoxAnFabricatie.Text = string.Empty;

            radioAlb.Checked = false;
            radioAlbastru.Checked = false;
            radioArgintiu.Checked = false;
            radioNegru.Checked = false;
            radioRosu.Checked = false;
            radioVerde.Checked = false;

            cBoxAerConditionat.Checked = false;
            cBoxCutieAutomata.Checked = false;
            cBoxGeamuriElectrice.Checked = false;
            cBoxNavigatie.Checked = false;
            cBoxOptiuniVolan.Checked = false;
            cBoxScaunePiele.Checked = false;


        }


        private void pctAdauga_Click(object sender, EventArgs e)
        {
            int culoare = ValidareCuloare();
            int optiuni = ValidareOptiuni();

            int validare = ValidareMasina();

            if (validare == 0)
            {
                Masina m = new Masina(txtFirma.Text, txtModel.Text, Convert.ToInt32(cBoxAnFabricatie.Text), culoare, optiuni, Convert.ToDouble(txtPret.Text));
                adminMasini.AddMasina(m);
                MessageBox.Show("Masina adaugata");
            }
            else
            {
                MessageBox.Show("Completati campurile marcate cu rosu!");
            }
            
        }

        private void lblDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaStartForm pgnStart = new PaginaStartForm();
            pgnStart.Show();
        }


        private void pictureDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaStartForm pgnStart = new PaginaStartForm();
            pgnStart.Show();
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

        private void pctModifica_Click(object sender, EventArgs e)
        {
            OptiuneAfiseazaForm modificaForm = new OptiuneAfiseazaForm();
            modificaForm.Show();
            this.Hide();
        }

        private void txtFirma_Enter(object sender, EventArgs e)
        {
            txtFirma.BackColor = SystemColors.Window;
        }

        private void txtModel_Enter(object sender, EventArgs e)
        {
            txtModel.BackColor = SystemColors.Window;
        }

        private void cBoxAnFabricatie_Enter(object sender, EventArgs e)
        {
            cBoxAnFabricatie.BackColor = SystemColors.Window;
        }

        private void txtPret_Enter(object sender, EventArgs e)
        {
            txtPret.BackColor = SystemColors.Window;
        }

        private void lblDeconectare_Click_1(object sender, EventArgs e)
        {
            PaginaStartForm startForm = new PaginaStartForm();
            startForm.Show();
            this.Hide();
        }

        private void pictureDeconectare_Click_1(object sender, EventArgs e)
        {
            PaginaStartForm startForm = new PaginaStartForm();
            startForm.Show();
            this.Hide();
        }

        private void lblCuloare_Click(object sender, EventArgs e)
        {
            if(ValidareCuloare() != 0)
            {
                lblCuloare.BackColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OptiuneInfoForm infoForm = new OptiuneInfoForm();
            infoForm.Show();
            this.Hide();

        }
    }
}
