using System;

namespace Targ_De_Masini
{
    //clasa Masina cu parametrii auto-implemented
    class Masina
    {
        public string numeFirma { set; get; }
        public string model { set; get; }
        public int anFabricatie { set; get; }
        public Culoare culoare { set; get; }
        public double pret { set; get; }
      

        //constructor implicit fara parametrii
        public Masina()
        {
            numeFirma = string.Empty;
            model = string.Empty;
            anFabricatie = 0;
            culoare = Culoare.None;
            pret = 0;
        }

        //constructor cu parametrii
        public Masina(string numeFirma, string model, int anFabricatie, int culoare, double pret)
        {
           
            this.numeFirma = numeFirma;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.culoare = (Culoare) culoare;
            this.pret = pret;

        }
        //constructor sir de caractere
        public Masina(string s)
        {
            string[] date = s.Split(" ");
            numeFirma = date[0];
            model = date[1];
            anFabricatie = Convert.ToInt32(date[2]);
            culoare = (Culoare) Convert.ToInt32( date[3] );
            pret = Convert.ToDouble(date[4]);

        }

        public void Compara(Masina m1)
        {
            if(this.pret > m1.pret)
            {
                Console.WriteLine("Masina "+this.numeFirma+" "+this.model+" este mai scumpa decat masina "
                    + m1.numeFirma + " " + m1.model + " cu " + (float)(this.pret - m1.pret) + "$");
            }
            else
            {
                Console.WriteLine("Masina " + m1.numeFirma + " " + m1.model + " este mai scumpa decat masina "
                    + this.numeFirma + " " + this.model + " cu " + (m1.pret - this.pret));
            }
        }
        
        public static int optCuloare()
        {
            Console.WriteLine("Alegeti o optiune: ");
            Console.WriteLine("1. Alb\n" +
                              "2. Negru\n" +
                              "3. Rosu\n" +
                              "4. Albastru\n" +
                              "5. Verde\n");
            int opt = Convert.ToInt32( Console.ReadLine() );
            return opt;
        }

        public string ConversieLaSir() //Afiseaza date despre masina
        {
            string buff = "";
            buff += "Masina: "+ numeFirma+ "\nModel: " + model + "\nAn Fabricatie: " + anFabricatie + "\nCuloare: " + culoare + "\nPret: " + pret + "$\n";
            return buff;
        }
        
    }
}
