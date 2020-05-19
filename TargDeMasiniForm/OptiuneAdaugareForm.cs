using System;
using System.Collections;
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
        public ArrayList optiuniSelectate = new ArrayList();

        public OptiuneAdaugareForm()
        {
            InitializeComponent();
        }
        
        private int ValidareOptiuni()
        {
            int optiuni = 0;

            if (cBoxAerConditionat.Checked == true)
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
            if (radioAlb.Checked == true)
            {
                return 1;
            }
            if (radioNegru.Checked == true)
            {
                return 2;
            }
            if (radioRosu.Checked == true)
            {
                return 3;
            }
            if (radioAlbastru.Checked == true)
            {
                return 4;
            }
            if (radioVerde.Checked == true)
            {
                return 5;
            }
            if (radioArgintiu.Checked == true)
            {
                return 6;
            }

            return 0;
        }

        
        private int ValidareMasina()
        {
            if (txtFirma.Text == string.Empty)
            {
                lblFirma.BackColor = Color.Red;                
            }
            if (txtModel.Text == string.Empty)
            {
                lblModel.BackColor = Color.Red;
               
            }
            if (cBoxAnFabricatie.Text == string.Empty)
            {
                lblAnFabricatie.BackColor = Color.Red;                       
            }
            if (ValidareCuloare() == 0)
            {
                lblCuloare.BackColor = Color.Red;
                
            }           
            if (cBoxAerConditionat.Checked == false && cBoxCutieAutomata.Checked == false && cBoxGeamuriElectrice.Checked == false && cBoxNavigatie.Checked == false && cBoxOptiuniVolan.Checked == false && cBoxScaunePiele.Checked == false)
            {
                lblOptiuni.BackColor = Color.Red;
                
            }           
            if (txtPret.Text == string.Empty || double.TryParse(txtPret.Text, out double result) == false)
            {
                lblPret.BackColor = Color.Red;
                
            }

            if (txtFirma.BackColor == Color.Red || txtModel.BackColor == Color.Red ||
                cBoxAnFabricatie.BackColor == Color.Red || lblCuloare.BackColor == Color.Red ||
                lblOptiuni.BackColor == Color.Red || txtPret.BackColor == Color.Red)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void lBoxAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Masina> masini = adminMasini.GetMasiniIndex(lBoxAfisare.SelectedIndex);

        }

        private void ResetControls()
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
            string validareChecked = ValidareOptiuniCheked();

            int validare = ValidareMasina();

            if (validare == 0)
            {
                if (Double.TryParse(txtPret.Text, out double result) == true)
                    {
                    Masina m = new Masina(txtFirma.Text, txtModel.Text, Convert.ToInt32(cBoxAnFabricatie.Text), culoare, optiuni, Convert.ToDouble(txtPret.Text));
                    m.optiuniInt = validareChecked;
                    m.DataActualizare = DateTime.Now;
                    adminMasini.AddMasina(m);
                    MessageBox.Show("Masina adaugata");
                    ResetControls();
                    }                
               
                else
                {
                    MessageBox.Show("Pretul nu poate fi un sir de caractere!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Completati campurile marcate cu rosu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private string ValidareOptiuniCheked()
        {
            string checkedOpt = "";
            if(cBoxAerConditionat.Checked == true)
            {
                checkedOpt += "1";
            }
            if(cBoxOptiuniVolan.Checked == true)
            {
                checkedOpt += " 2";
            }
            if(cBoxScaunePiele.Checked == true)
            {
                checkedOpt += " 4";
            }
            if(cBoxGeamuriElectrice.Checked == true)
            {
                checkedOpt += " 8";
            }
            if(cBoxNavigatie.Checked == true)
            {
                checkedOpt += " 16";
            }
            if(cBoxCutieAutomata.Checked == true)
            {
                checkedOpt += " 32";
            }
            return checkedOpt;
        }

        private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            lblOptiuni.BackColor = SystemColors.ButtonFace;
            
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
            this.Hide();
            cautaForm.ShowDialog();
            
        }

        private void pctModifica_Click(object sender, EventArgs e)
        {
            OptiuneAfiseazaForm afiseazaForm = new OptiuneAfiseazaForm();
            afiseazaForm.Show();
            this.Hide();
        }

        private void txtFirma_Enter(object sender, EventArgs e)
        {
            lblFirma.BackColor = SystemColors.Control;
        }

        private void txtModel_Enter(object sender, EventArgs e)
        {
            lblModel.BackColor = SystemColors.Control;
        }

        private void txtPret_Enter(object sender, EventArgs e)
        {
            lblPret.BackColor = SystemColors.Control;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm.infoForm.Show();
            this.Hide();

        }

        private void radioAlb_CheckedChanged(object sender, EventArgs e)
        {
            if(radioAlb.Checked == true)
            {
                lblCuloare.BackColor = SystemColors.Control;
            }
        }

        private void radioNegru_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNegru.Checked == true)
            {
                lblCuloare.BackColor = SystemColors.Control;
            }
        }

        private void radioRosu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRosu.Checked == true)
            {
                lblCuloare.BackColor = SystemColors.Control;
            }
        }

        private void radioAlbastru_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAlbastru.Checked == true)
            {
                lblCuloare.BackColor = SystemColors.Control;
            }
        }

        private void radioVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVerde.Checked == true)
            {
                lblCuloare.BackColor = SystemColors.Control;
            }
        }

        private void radioArgintiu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAlb.Checked == true)
            {
                radioArgintiu.BackColor = SystemColors.Control;
            }
        }

        private void cBoxAnFabricatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnFabricatie.BackColor = SystemColors.Control;
        }

        
    }
}
