//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Windows.Forms;
using Modele;

namespace TargDeMasiniForm
{
    
    class Program
    {
        public static PaginaStartForm startForm;
        
        [STAThread]
        static void Main(string[] args)
        {
            Persoana p = LoginForm.infoPersoana;

            startForm = new PaginaStartForm();           

            startForm.Show();
            Application.Run();

        }
    }
}