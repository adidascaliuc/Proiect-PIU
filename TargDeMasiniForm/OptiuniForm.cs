using Modele;
using NivelAcces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TargDeMasiniForm
{
    public partial class OptiuniForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public List<String> optiuniSelectate = new List<string>();

        public OptiuniForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnAfisare_MouseClick(object sender, MouseEventArgs e)
        //{
        //    lBoxAfisare.Items.Clear();
        //    Boolean gasit = false;
        //    List<Masina> masini = adminMasini.GetMasini(out int nrMasini);

        //    foreach (Masina m in masini)
        //    {
        //        if (m != null)
        //        {
        //            lBoxAfisare.Items.Add(m.ConversieLaSir());
        //            gasit = true;
        //        }
        //    }
        //    if (gasit == false)
        //    {
        //        lBoxAfisare.Items.Clear();
        //        lBoxAfisare.Items.Add("Nu exista masini introduse!");
        //    }

        //}

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

        //private void btnAdauga_Click(object sender, EventArgs e)
        //{
        //    int culoare = ValidareCuloare();
        //    int optiuni = ValidareOptiuni();

        //    int validare = ValidareMasina();

        //    if (validare == 0)
        //    {
        //        Masina m = new Masina(txtFirma.Text, txtModel.Text, Convert.ToInt32(cBoxAnFabricatie.Text), culoare, optiuni, Convert.ToDouble(txtPret.Text));
        //        adminMasini.AddMasina(m);
        //        lblInfo.Text = "Masina a fost adaugata cu succes!";
        //    }
        //    else
        //    {
        //        CodEroareMasina(validare);
        //    }


        //}

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

        //private void btnCautare_Click(object sender, EventArgs e)
        //{
        //    lBoxAfisare.Items.Clear();

        //    List<Masina> masini = adminMasini.GetMasini(out int nrMasini);
        //    Boolean gasit = false;

        //    foreach (Masina m in masini)
        //    {
        //        if (m != null)
        //        {
        //            if (m.NumeFirma == txtFirma.Text && m.Model == txtModel.Text)
        //            {
        //                lBoxAfisare.Items.Add(m.ConversieLaSir());
        //                gasit = true;
        //            }
        //        }
        //    }
        //    if (gasit == false)
        //    {
        //        lBoxAfisare.Items.Add("Nu exista o astfel de masina!");
        //    }
        //}

        //private void btnModificare_Click(object sender, EventArgs e)
        //{
        //    List<Masina> masini = adminMasini.GetMasiniIndex(Convert.ToInt32(lBoxAfisare.SelectedIndex));
            

        //    if (masini != null)
        //    {
        //        Masina m = masini.Last();
        //        ModificaForm modForm = new ModificaForm(m, lBoxAfisare.SelectedIndex);
        //        modForm.Show();
        //        //lblInfo.Text = "Masina modificata cu succes!";
        //    }
        //    else
        //    {
        //        lBoxAfisare.Items.Clear();
        //        lBoxAfisare.Items.Add("Selectati o masina!");
        //    }
        //}

        private void lBoxAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Masina> masini = adminMasini.GetMasiniIndex(lBoxAfisare.SelectedIndex);

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

            lBoxAfisare.Items.Clear();


        }

        private void btnNrMasini_Click(object sender, EventArgs e)
        {
            List<Masina> masini = adminMasini.GetMasiniIndex(lBoxAfisare.SelectedIndex);
            lblNrMasini.Text = "Serie Masina: " + masini[0].SerieMasina;
        }

        private void cBoxOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string optiuneSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(optiuneSelectata);
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }

        private void lblDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaStartForm pgnStart = new PaginaStartForm();
            pgnStart.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaStartForm pgnStart = new PaginaStartForm();
            pgnStart.Show();
        }

        private void pctModifica_Click(object sender, EventArgs e)
        {

            List<Masina> masini = adminMasini.GetMasiniIndex(Convert.ToInt32(lBoxAfisare.SelectedIndex));


            if (masini != null)
            {
                Masina m = masini.Last();
                OptiuneModificaForm modForm = new OptiuneModificaForm(m, lBoxAfisare.SelectedIndex);
                modForm.Show();
                //lblInfo.Text = "Masina modificata cu succes!";
            }
            else
            {
                lBoxAfisare.Items.Clear();
                lBoxAfisare.Items.Add("Selectati o masina!");
            }
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
            lBoxAfisare.Items.Clear();
            Boolean gasit = false;
            List<Masina> masini = adminMasini.GetMasini(out int nrMasini);

            foreach (Masina m in masini)
            {
                if (m != null)
                {
                    lBoxAfisare.Items.Add(m.ConversieLaSir());
                    gasit = true;
                }
            }
            if (gasit == false)
            {
                lBoxAfisare.Items.Clear();
                lBoxAfisare.Items.Add("Nu exista masini introduse!");
            }
        }

        private void pctCauta_Click(object sender, EventArgs e)
        {
            OptiuneCautaForm cautaForm = new OptiuneCautaForm();
            cautaForm.Show();
            this.Hide();
            lBoxAfisare.Items.Clear();

            List<Masina> masini = adminMasini.GetMasini(out int nrMasini);
            Boolean gasit = false;

            foreach (Masina m in masini)
            {
                if (m != null)
                {
                    if (m.NumeFirma == txtFirma.Text && m.Model == txtModel.Text)
                    {
                        lBoxAfisare.Items.Add(m.ConversieLaSir());
                        gasit = true;
                    }
                }
            }
            if (gasit == false)
            {
                MessageBox.Show("Nu exista o astfel de masina","Cautare", MessageBoxButtons.OK);
            }
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
                lblInfo.Text = "Masina a fost adaugata cu succes!";
            }
            else
            {
                CodEroareMasina(validare);
            }
        }
    }

}