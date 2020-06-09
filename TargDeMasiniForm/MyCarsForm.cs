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

namespace TargDeMasiniForm
{
    public partial class MyCarsForm : Form
    {
        public MyCarsForm(List<Masina> masini)
        {
            InitializeComponent();
            foreach (Masina m in masini)
            {
                flowLayoutPanel1.Controls.Add(new ListaMasiniForm(m, (int)ModAfisare.FORMAMYCARS ));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
