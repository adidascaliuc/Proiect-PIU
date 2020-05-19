using Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAcces;

namespace TargDeMasiniForm
{
    public partial class LoginForm : Form
    {
        public static OptiuneInfoForm infoForm;
        public static Persoana infoPersoana = null;
        IStocareDataPersoane adminPersoane = StocareFactoryPersoane.GetAdministratorStocare();
        public LoginForm()
        {                   
            InitializeComponent();            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            
        }
        
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.BackColor = SystemColors.ActiveCaption;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = SystemColors.ActiveCaption;
            txtPassword.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: admin\nPassword: 1234", "Date Log in", MessageBoxButtons.OK);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Persoana> persoane = adminPersoane.GetPersoane();

            bool gasit = false;
            if (ValidareInput() == 0)
            {               
                    foreach (Persoana p in persoane)
                    {
                        if (txtUsername.Text == p.Username && txtPassword.Text == p.Password)
                        {
                            infoPersoana = p;
                            infoForm = new OptiuneInfoForm(p);
                            infoForm.StartPosition = FormStartPosition.CenterScreen;
                            this.Hide();
                            Program.startForm.Hide();
                            infoForm.ShowDialog();
                            gasit = true;
                        }

                    }
                    if (!gasit)
                    {
                        MessageBox.Show("Nume sau parola incorecte!");
                    }                
                }
            
            else
            {
                MessageBox.Show("Completati spatiile marcate cu rosu!!!");
            }
        }

        private int ValidareInput()
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.BackColor = Color.Red;
            }
            else
            {
                txtUsername.BackColor = SystemColors.ButtonFace;
            }
            if (txtPassword.Text == "Password")
            {
                txtPassword.BackColor = Color.Red;
            }
            else
            {
                txtPassword.BackColor = SystemColors.ButtonFace;
            }
            if (txtUsername.BackColor == Color.Red || txtPassword.BackColor == Color.Red)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            
        }

        private void pictureShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pictureShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';           
            
        }
    }
}
