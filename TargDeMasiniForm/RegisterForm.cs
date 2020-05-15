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
        }

        private void txtUsername_DragLeave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Persoana p = new Persoana();
            adminPersoane.AddPersoana(p);



        }
    }
}
