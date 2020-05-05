using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Modele;
using NivelAcces;
using Targ_De_Masini;

namespace FormTargDeMasini
{
    static class Program
    {


        [STAThread]
        static void Main()
        {
            FormMasini form = new FormMasini();
            form.Show();
            Application.Run();
        }

        public class FormMasini : Form
        {
            IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
            private Button btnAdauga;
            private Label lblFirma, lblModel, lblAnFabricatie, lblCuloare, lblOptiuni, lblPret, lblInfo, lblAbout;
            private TextBox txtFirma, txtModel, txtAnFabricatie, txtCuloare, txtOptiuni, txtPret;

            private const int LATIME_CONTROL = 150;
            private const int INALTIME_CONTROL = 20;
            private const int DIMENSIUNE_PAS_Y = 30;
            private const int DIMENSIUNE_PAS_X = 170;
            private const int LUNGIME_MAX = 15;

            public FormMasini()
            {
                this.Size = new System.Drawing.Size(1000, 500);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new System.Drawing.Point(100, 100);
                this.Font = new Font("Arial", 9, FontStyle.Bold);
                this.ForeColor = Color.Black;
                this.Text = "Targ De Masini";

                lblFirma = new Label();
                lblFirma.Width = LATIME_CONTROL;
                lblFirma.Text = "Firma: ";
                lblFirma.BackColor = Color.Aqua;
                this.Controls.Add(lblFirma);

                lblModel = new Label();
                lblModel.Width = LATIME_CONTROL;
                lblModel.Text = "Model: ";
                lblModel.Top = DIMENSIUNE_PAS_Y;
                lblModel.BackColor = Color.Aqua;
                this.Controls.Add(lblModel);

                lblAnFabricatie = new Label();
                lblAnFabricatie.Width = LATIME_CONTROL;
                lblAnFabricatie.Text = "An Fabricatie: ";
                lblAnFabricatie.Top = DIMENSIUNE_PAS_Y * 2;
                lblAnFabricatie.BackColor = Color.Aqua;
                this.Controls.Add(lblAnFabricatie);

                lblCuloare = new Label();
                lblCuloare.Width = LATIME_CONTROL;
                lblCuloare.Text = "Culoare: ";
                lblCuloare.Top = DIMENSIUNE_PAS_Y * 3;
                lblCuloare.BackColor = Color.Aqua;
                this.Controls.Add(lblCuloare);

                lblOptiuni = new Label();
                lblOptiuni.Width = LATIME_CONTROL;
                lblOptiuni.Text = "Optiuni: ";
                lblOptiuni.Top = DIMENSIUNE_PAS_Y * 4;
                lblOptiuni.BackColor = Color.Aqua;
                this.Controls.Add(lblOptiuni);

                lblPret = new Label();
                lblPret.Width = LATIME_CONTROL;
                lblPret.Text = "Pret: ";
                lblPret.Top = DIMENSIUNE_PAS_Y * 5;
                lblPret.BackColor = Color.Aqua;
                this.Controls.Add(lblPret);




                txtFirma = new TextBox();
                txtFirma.Width = LATIME_CONTROL;
                txtFirma.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 0);
                this.Controls.Add(txtFirma);


                txtModel = new TextBox();
                txtModel.Width = LATIME_CONTROL;
                txtModel.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
                this.Controls.Add(txtModel);

                txtAnFabricatie = new TextBox();
                txtAnFabricatie.Width = LATIME_CONTROL;
                txtAnFabricatie.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 2);
                this.Controls.Add(txtAnFabricatie);

                txtCuloare = new TextBox();
                txtCuloare.Width = LATIME_CONTROL;
                txtCuloare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 3);
                this.Controls.Add(txtCuloare);

                txtOptiuni = new TextBox();
                txtOptiuni.Width = LATIME_CONTROL;
                txtOptiuni.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 4);
                this.Controls.Add(txtOptiuni);

                txtPret = new TextBox();
                txtPret.Width = LATIME_CONTROL;
                txtPret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 5);
                this.Controls.Add(txtPret);

                btnAdauga = new Button();
                btnAdauga.Text = "Adauga";
                btnAdauga.Location = new Point(DIMENSIUNE_PAS_X + 40, DIMENSIUNE_PAS_Y * 6);
                this.Controls.Add(btnAdauga);

                btnAdauga.Click += OnButtonAdaugaClicked;
                this.Controls.Add(btnAdauga);

                lblAbout = new Label();
                lblAbout.AutoSize = true;
                lblAbout.Text = "*** Info ***\n" +
                    "Culoare:\n" +
                    "1. Alb\n" +
                    "2. Negru\n" +
                    "3. Rosu\n" +
                    "4. Albastru\n" +
                    "5.Verde\n" +
                    "\nOptiuni:\n" +
                    "1. AerConditionat\n" +
                    "2. OptiuniVolan\n" +
                    "4. ScaundePiele\n" +
                    "8. ModBengos\n" +
                    "16. Navigatie\n" +
                    "32. CutieAutomata\n";

                lblAbout.Location = new Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 7);
                this.Controls.Add(lblAbout);

                lblInfo = new Label();
                lblInfo.Location = new Point(DIMENSIUNE_PAS_X * 2);
                lblInfo.Text = "*** Masini ***\n";
                lblInfo.AutoSize = true;
                this.Controls.Add(lblInfo);





            }

            private void OnButtonAdaugaClicked(object sender, EventArgs e)
            {
                int validare = Validare();

                if (validare == 0)

                {
                    Masina m = new Masina(txtFirma.Text, txtModel.Text,Convert.ToInt16( txtAnFabricatie.Text ),Convert.ToInt16( txtCuloare.Text ), Convert.ToInt16( txtOptiuni.Text ), Convert.ToDouble( txtPret.Text ));

                    lblInfo.Text += m.ConversieLaSir() + "\n";
                    //adminMasini.AddMasina(m);

                }
                else
                {

                    switch (validare)
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
                        default:
                            break;
                    }

                }
            }
            private int Validare()
            {
                
                if (txtFirma.Text == string.Empty || txtFirma.Text.Length > LUNGIME_MAX)
                {
                    return 1;
                }
                else if (txtModel.Text == string.Empty || txtModel.Text.Length > LUNGIME_MAX)
                {
                    return 2;
                }
                else if (txtAnFabricatie.Text == string.Empty)
                {
                    return 3;
                }
                else if(txtCuloare.Text == string.Empty)
                {
                    return 4;
                }
                else if(txtOptiuni.Text ==  string.Empty)
                {
                    return 5;
                }
                else if(txtPret.Text == string.Empty)
                {
                    return 6;
                }


                return 0;
            }
        }
    }
}
