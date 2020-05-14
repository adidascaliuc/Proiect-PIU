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
    public partial class OptiuneCautaForm : Form
    {
        public OptiuneCautaForm()
        {
            InitializeComponent();
        }

        private void pctAfiseaza_Click(object sender, EventArgs e)
        {
            OptiuniForm optForm = new OptiuniForm();
            optForm.Show();
            this.Hide();
        }
    }
}
