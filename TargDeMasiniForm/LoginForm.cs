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
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                OptiuneInfoForm optForm = new OptiuneInfoForm();
                optForm.Show();
                this.Hide();
                Program.startForm.Hide();

            }
            else
            {
                MessageBox.Show("Nume sau parola Incorecte!", "Eroare", MessageBoxButtons.OK);
            }

            if (txtUsername.Text == "Username")
            {
                txtUsername.BackColor = Color.Red;
            }

            if(txtPassword.Text == "Password")
            {
                txtPassword.BackColor = Color.Red;
            }

            bool ok = false;
            List<Persoana> persoane = adminPersoane.GetPersoane();
            foreach(Persoana p in persoane)
            {
                if(p.Username == txtUsername.Text && p.Password == txtPassword.Text)
                {
                    MessageBox.Show("Persoana gasita");
                    ok = true;
                    break;
                }

            }
            if(ok == false)
            {
                MessageBox.Show("Username sau Parola gresite !!!");
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            
        }

    }
}
