using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TargDeMasiniForm
{
    class Program
    {
        static void Main(string[] args)
        {
            PaginaStartForm startForm = new PaginaStartForm();
            startForm.Show();
            Application.Run();

        }
    }
}