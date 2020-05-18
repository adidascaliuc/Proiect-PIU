using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Modele;

namespace TargDeMasiniForm
{
    
    class Program
    {
        public static PaginaStartForm startForm;
        public static OptiuneInfoForm infoForm;
        
        [STAThread]
        static void Main(string[] args)
        {
            Persoana p = new Persoana("admin", "admin", "admin", "1234");
            startForm = new PaginaStartForm();           
            infoForm = new OptiuneInfoForm(p);
            infoForm.StartPosition = FormStartPosition.CenterScreen;

            startForm.Show();
            Application.Run();

        }
    }
}