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
using TargDeMasiniForm;

namespace TargDeMasiniForm
{
    public partial class OptiuneModificaForm : Form
    {
        private Masina m;
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();

        public OptiuneModificaForm(Masina masina, int index)
        {
            InitializeComponent();

            m = masina;

            txtFirma.Text = m.NumeFirma;
            txtModel.Text = m.Model;
            cBoxAnFabricatie.Text = Convert.ToString(m.AnFabricatie);

            

            if (Convert.ToInt32(m.CULOARE) == 1)
            {
                radioAlb.Checked = true;
            }
            if (Convert.ToInt32(m.CULOARE) == 2)
            {
                radioNegru.Checked = true;
            }
            if (Convert.ToInt32(m.CULOARE) == 3)
            {
                radioRosu.Checked = true;
            }
            if (Convert.ToInt32(m.CULOARE) == 4)
            {
                radioAlbastru.Checked = true;
            }
            if (Convert.ToInt32(m.CULOARE) == 5)
            {
                radioVerde.Checked = true;
            }
            if (Convert.ToInt32(m.CULOARE) == 6)
            {
                radioArgintiu.Checked = true;
            }
            txtPret.Text = Convert.ToString(m.Pret);
           
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int modCuloare = ValidareCuloare();
            int modOptiuni = ValidareOptiuni();
            int validare = ValidareMasina();

            if (validare == 0)
            {
                m.NumeFirma = txtFirma.Text;
                m.Model = txtModel.Text;
                m.AnFabricatie = Convert.ToInt32(cBoxAnFabricatie.Text);
                m.CULOARE = (Culoare)modCuloare;
                m.OPTIUNI = (Optiuni)modOptiuni;
                m.Pret = Convert.ToDouble(txtPret.Text);
                m.DataActualizare = DateTime.Now;

                adminMasini.UpdateMasina(m, m.IdMasina - 1);
                this.Hide();

                
            }
            else
            {
                CodEroareMasina(validare);
            }
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
            if (ValidareOptiuni() == 0)
            {
                lblCuloare.BackColor = Color.Red;

            }
            if (cBoxAerConditionat.Checked == false && cBoxCutieAutomata.Checked == false && cBoxGeamuriElectrice.Checked == false && cBoxNavigatie.Checked == false && cBoxOptiuniVolan.Checked == false && cBoxScaunePiele.Checked == false)
            {
                lblOptiuni.BackColor = Color.Red;

            }
            if (txtPret.Text == string.Empty)
            {
                lblPret.BackColor = Color.Red;

            }

            if (txtFirma.BackColor == Color.Red || txtModel.BackColor == Color.Red ||
                cBoxAnFabricatie.BackColor == Color.Red || lblCuloare.BackColor == Color.Red ||
                lblOptiuni.BackColor == Color.Red || txtPret.BackColor == Color.Red)
            {
                return 1;
            }
            return 0;
        }

        private void CodEroareMasina(int eroare)
        {
            switch (eroare)
            {
                case 1:
                    lblFirma.ForeColor = Color.Red;
                    break;
                case 2:
                    lblModel.ForeColor = Color.Red;
                    break;
                case 3:
                    lblAnFabricatie.ForeColor = Color.Red;
                    break;
                case 4:
                    lblCuloare.ForeColor = Color.Red;
                    break;
                case 5:
                    lblOptiuni.ForeColor = Color.Red;
                    break;
                case 6:
                    lblPret.ForeColor = Color.Red;
                    break;
            }
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
            if (radioArgintiu.Checked == true)
            {
                lblCuloare.BackColor = SystemColors.Control;
            }
        }
    }
}