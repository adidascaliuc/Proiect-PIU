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
        public static PaginaStartForm startForm;
        [STAThread]
        static void Main(string[] args)
        {
            startForm = new PaginaStartForm();
            startForm.Show();
            Application.Run();

        }
    }
}