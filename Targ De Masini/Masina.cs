using System;

namespace Targ_De_Masini
{
    //clasa Masina cu parametrii auto-implemented
    class Masina
    {
        public string NumeFirma { set; get; }
        public string Model { set; get; }
        public int AnFabricatie { set; get; }
        public Culoare CULOARE { set; get; }
        public double Pret { set; get; }
      

        //constructor implicit fara parametrii
        public Masina()
        {
            NumeFirma = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            CULOARE = Culoare.None;
            Pret = 0;
        }

        //constructor cu parametrii
        public Masina(string numeFirma, string model, int anFabricatie, int culoare, double pret)
        {
           
            this.NumeFirma = numeFirma;
            this.Model = model;
            this.AnFabricatie = anFabricatie;
            this.CULOARE = (Culoare) culoare;
            this.Pret = pret;

        }
        //constructor sir de caractere
        public Masina(string s)
        {
            string[] date = s.Split(" ");
            NumeFirma = date[0];
            Model = date[1];
            AnFabricatie = Convert.ToInt32( date[2] );
            CULOARE = (Culoare) Convert.ToInt32( date[3] );
            Pret = Convert.ToDouble( date[4] );

        }

        public int Compara(Masina m1)
        {
            if(this.Pret > m1.Pret)
            {
                return 1;
                
            }
            else
            {
                return 2;
                
            }
        }

        public string ConversieLaSir() //Afiseaza date despre masina
        {
            string buff = "";
            buff += "Masina: "+ NumeFirma+ "\nModel: " + Model + "\nAn Fabricatie: " + AnFabricatie + "\nCuloare: " + CULOARE + "\nPret: " + Pret + "$\n";
            return buff;
        }
        
    }
}
