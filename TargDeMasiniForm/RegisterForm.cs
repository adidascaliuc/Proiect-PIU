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
    public partial class RegisterForm : Form      
    {
        IStocareDataPersoane adminPersoane = StocareFactoryPersoane.GetAdministratorStocare();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNume_Enter(object sender, EventArgs e)
        {
            txtNume.Text = "";
            txtNume.BackColor = SystemColors.Control;
        }

        private void txtNume_Leave(object sender, EventArgs e)
        {
            if(txtNume.Text == "")
            {
                txtNume.Text = "Nume";
            }
        }

        private void textPrenume_Enter(object sender, EventArgs e)
        {
            txtPrenume.Text = "";
            txtPrenume.BackColor = SystemColors.Control;
            
        }

        private void txtPrenume_Leave(object sender, EventArgs e)
        {
            if(txtPrenume.Text == "")
            {
                txtPrenume.Text = "Prenume";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.BackColor = SystemColors.Control;
        }

        public int ValidareInput()
        {
            if (txtNume.BackColor == Color.Red || txtPrenume.BackColor == Color.Red || txtUsername.BackColor == Color.Red || txtPassword.BackColor == Color.Red)
            {
                return 0;
            }
            return 1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ValidareControale();

            if (ValidareInput() == 1)
            {
                if (ValidareUsername(txtUsername.Text) == 1)
                {
                    if (ValidarePassword() == 1)
                    {
                        if (txtPassword.Text.Length < 5)
                        {
                            MessageBox.Show("Parola trebuie sa contina cel putin 5 caractere!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            Persoana p = new Persoana(txtNume.Text, txtPrenume.Text, txtUsername.Text, txtPassword.Text);
                            adminPersoane.AddPersoana(p);
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolele difera!!!","Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Exista deja un utilizator cu acest username","Username Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Completati spatiile marcate cu rosu!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int ValidareUsername(string username)
        {
            List<Persoana> persoane = adminPersoane.GetPersoane();
            if (persoane != null)
            {
                foreach (Persoana p in persoane)
                {
                    if(p.Username == username)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        private int ValidarePassword()
        {           
            if( (txtPassword.Text == txtConfirmPassword.Text) && (txtPassword.Text != "Password" && txtConfirmPassword.Text != "Password") )
            {
                return 1;
            }
            return 0;
        }

        private void ValidareControale()
        {
            if(txtNume.Text == "" || txtNume.Text == "Nume")
            {
                txtNume.BackColor = Color.Red;
            }
            if(txtPrenume.Text == "" || txtPrenume.Text == "Prenume")
            {
                txtPrenume.BackColor = Color.Red;
            }
            if(txtUsername.Text == "" || txtUsername.Text == "Username")
            {
                txtUsername.BackColor = Color.Red;
            }
            if(txtPassword.Text == "" || txtPassword.Text == "Password")
            {
                txtPassword.BackColor = Color.Red;
            }     
            if(txtConfirmPassword.Text == "" || txtConfirmPassword.Text == "Password")
            {
                txtConfirmPassword.BackColor = Color.Red;
            }

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
            txtConfirmPassword.BackColor = SystemColors.ButtonFace;
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Password";
            }
        }

        private void pictureShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pictureShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void pictureShowConfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.PasswordChar = '\0';
        }

        private void pictureShowConfirmPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.PasswordChar = '●';
        }
    }
}
