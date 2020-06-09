//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Modele;
using NivelAcces;

namespace TargDeMasiniForm
{
    public partial class OptiuneAdaugareForm : Form
    {
        IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
        public ArrayList optiuniSelectate = new ArrayList();
        private bool imageSelected = false;

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
            if (comboFirma.Text == string.Empty)
            {
                lblFirma.BackColor = Color.Red;
            }
            if (comboModel.Text == string.Empty)
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

            if (comboFirma.BackColor == Color.Red || comboModel.BackColor == Color.Red ||
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


        private void ResetControls()
        {
            comboFirma.Text = string.Empty;
            comboModel.Text = string.Empty;
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

        private string ValidareOptiuniCheked()
        {
            string checkedOpt = "";
            if (cBoxAerConditionat.Checked == true)
            {
                checkedOpt += "1";
            }
            if (cBoxOptiuniVolan.Checked == true)
            {
                checkedOpt += " 2";
            }
            if (cBoxScaunePiele.Checked == true)
            {
                checkedOpt += " 4";
            }
            if (cBoxGeamuriElectrice.Checked == true)
            {
                checkedOpt += " 8";
            }
            if (cBoxNavigatie.Checked == true)
            {
                checkedOpt += " 16";
            }
            if (cBoxCutieAutomata.Checked == true)
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
            new PaginaStartForm().Show();
        }


        private void pictureDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaginaStartForm().Show();
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

        private void pctModifica_Click(object sender, EventArgs e)
        {
            new OptiuneAfiseazaForm().Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm.infoForm.Show();
            this.Hide();

        }

        private void radioAlb_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAlb.Checked == true)
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

        private void cBoxAnFabricatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnFabricatie.BackColor = SystemColors.Control;
        }

        private void comboFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFirma.BackColor = SystemColors.ButtonFace;
            if (comboFirma.Text == "Audi")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("A4");
                comboModel.Items.Add("A5");
                comboModel.Items.Add("A6");
                comboModel.Items.Add("Q5");
                comboModel.Items.Add("Q7");
            }
            if (comboFirma.Text == "BMW")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Seria 5");
                comboModel.Items.Add("Seria 7");
                comboModel.Items.Add("X5");
                comboModel.Items.Add("6");
                comboModel.Items.Add("i8");
            }
            if (comboFirma.Text == "Ford")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Mustang");
                comboModel.Items.Add("Fiesta");
                comboModel.Items.Add("Tourneo Courier");
                comboModel.Items.Add("Ecosport");
                comboModel.Items.Add("Kuga");
            }
            if (comboFirma.Text == "Honda")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Civic Sedan");
                comboModel.Items.Add("Civic 5D");
                comboModel.Items.Add("Jazz");
                comboModel.Items.Add("Honda E");
                comboModel.Items.Add("CR-V HYBRID");
            }
            if (comboFirma.Text == "Hyundai")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("i10");
                comboModel.Items.Add("i30 Fastback");
                comboModel.Items.Add("Elantra");
                comboModel.Items.Add("KONA");
                comboModel.Items.Add("Santa Fe");
            }
            if (comboFirma.Text == "Lexus")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("RX");
                comboModel.Items.Add("NX");
                comboModel.Items.Add("LS");
                comboModel.Items.Add("CT");
                comboModel.Items.Add("IS");
            }
            if (comboFirma.Text == "Mercedes")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("S Class");
                comboModel.Items.Add("E Class");
                comboModel.Items.Add("CLA");
                comboModel.Items.Add("GLE Coupe");
                comboModel.Items.Add("GLE SUV");
            }
            if (comboFirma.Text == "Porche")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Cayman");
                comboModel.Items.Add("Boxter");
                comboModel.Items.Add("Panamera");
                comboModel.Items.Add("Carrera");
                comboModel.Items.Add("Cayenne");
            }
            if (comboFirma.Text == "Toyota")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Aygo");
                comboModel.Items.Add("Corola");
                comboModel.Items.Add("Proace Verso");
                comboModel.Items.Add("Prius");
                comboModel.Items.Add("C-HR facelift");
            }
            if (comboFirma.Text == "Volkswagen")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Polo");
                comboModel.Items.Add("Golf 5");
                comboModel.Items.Add("Golf 7");
                comboModel.Items.Add("T-Cross");
                comboModel.Items.Add("Tiguan");
            }
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblModel.BackColor = SystemColors.ButtonFace;
        }

        private void btnSchimbaImagine_Click(object sender, EventArgs e)
        {
            List<Masina> masini = adminMasini.GetMasini();
            string imageLocation = "";
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = fileDialog.FileName;
                    pictureMasina.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("A aparut o eroare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            int culoare = ValidareCuloare();
            int optiuni = ValidareOptiuni();
            string validareChecked = ValidareOptiuniCheked();

            int validare = ValidareMasina();

            if (validare == 0)
            {
                if (Double.TryParse(txtPret.Text, out double result) == true)
                {
                    if (Convert.ToDouble(txtPret.Text) <= 0)
                    {
                        MessageBox.Show("Pretul masinii trebuie sa fie mai mare decat 0!", "Info Pret", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Masina m = new Masina(comboFirma.Text, comboModel.Text, Convert.ToInt32(cBoxAnFabricatie.Text), culoare, optiuni, Convert.ToDouble(txtPret.Text));
                        m.optiuniInt = validareChecked;
                        m.DataActualizare = DateTime.Now;
                        m.NumeProprietar = OptiuneInfoForm.InfoPersoana.NumeComplet;
                        m.ImageLocation = pictureMasina.ImageLocation;
                        m.istoricProprietari.Add(OptiuneInfoForm.InfoPersoana.NumeComplet);
                        m.istoricPreturi.Add(Convert.ToDouble(txtPret.Text));
                        adminMasini.AddMasina(m);
                        MessageBox.Show("Masina adaugata", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetControls();
                    }
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
    }
}
