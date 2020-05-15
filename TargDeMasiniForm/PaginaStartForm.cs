using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargDeMasiniForm
{
    public partial class PaginaStartForm : Form
    {
        public PaginaStartForm()
        {
            
            InitializeComponent();

            timer1.Start();
            lblOra.Text = DateTime.Now.ToLongTimeString();

            lblData.Text += DateTime.Now.ToLongDateString(); 
        }

        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            LoginForm lgnForm = new LoginForm();
            lgnForm.ShowDialog();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOra.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
