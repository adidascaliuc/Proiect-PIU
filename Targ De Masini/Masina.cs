using System;

namespace Targ_De_Masini
{
    //clasa Masina cu parametrii auto-implemented
    class Masina
    {
        public string numeFirma { set; get; }
        public string model { set; get; }
        public int anFabricatie { set; get; }
        public string culoare { set; get; }
        public double pret { set; get; }
      

        //constructor implicit fara parametrii
        public Masina()
        {
            numeFirma = string.Empty;
            model = string.Empty;
            anFabricatie = 0;
            culoare = string.Empty;
            pret = 0;
        }

        //constructor cu parametrii
        public Masina(string numeFirma, string model, int anFabricatie, string culoare, double pret)
        {
           
            this.numeFirma = numeFirma;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.culoare = culoare;
            this.pret = pret;

        }
        //constructor sir de caractere
        public Masina(string s)
        {
            string[] date = s.Split(" ");
            numeFirma = date[0];
            model = date[1];
            anFabricatie = Convert.ToInt32(date[2]);
            culoare = date[3];
            pret = Convert.ToDouble(date[4]);

        }

        public void Compara(Masina m1)
        {

        }
        

        public string ConversieLaSir() //Afiseaza date despre masina
        {
            string buff = "";
            buff += "Masina: "+ numeFirma+ "\nModel: " + model + "\nAn Fabricatie: " + anFabricatie + "\nCuloare: " + culoare + "\nPret: " + pret + "$\n";
            return buff;
        }
        
    }
}
