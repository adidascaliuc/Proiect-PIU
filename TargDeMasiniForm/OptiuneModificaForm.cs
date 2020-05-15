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

            return 2;
        }

        private int ValidareMasina()
        {
            if (txtFirma.Text == string.Empty)
            {
                return 1;
            }
            if (txtModel.Text == string.Empty)
            {
                return 2;
            }
            if (cBoxAnFabricatie.Text == string.Empty)
            {
                return 3;
            }
            if (radioAlb.Enabled == false || radioAlbastru.Enabled == false || radioArgintiu.Enabled == false || radioNegru.Enabled == false || radioRosu.Enabled == false || radioVerde.Enabled == false)
            {
                return 4;
            }
            if (cBoxAerConditionat.Checked == false && cBoxCutieAutomata.Checked == false && cBoxGeamuriElectrice.Checked == false && cBoxNavigatie.Checked == false && cBoxOptiuniVolan.Checked == false && cBoxScaunePiele.Checked == false)
            {
                return 5;
            }
            if (txtPret.Text == string.Empty)
            {
                return 6;
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

        
    }
}