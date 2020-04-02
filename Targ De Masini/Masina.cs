using System;

namespace Targ_De_Masini
{
    //clasa Masina cu parametrii auto-implemented
    public class Masina
    {
        int NUMEFIRMA = 0;
        int MODEL = 1;
        int ANFABRICATIE = 2;
        int INDEXCULOARE = 3;
        int INDEXOPTIUNI = 4;
        int PRET = 5;


        public string NumeFirma { set; get; }
        public string Model { set; get; }
        public int AnFabricatie { set; get; }
        public Culoare CULOARE { set; get; }
        public Optiuni OPTIUNI { set; get; }
        public double Pret { set; get; }


        //constructor implicit fara parametrii
        public Masina()
        {
            NumeFirma = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            CULOARE = Culoare.None;
            OPTIUNI = Optiuni.None;
            Pret = 0;
        }

        //constructor cu parametrii
        public Masina(string numeFirma, string model, int anFabricatie, int culoare, int optiuni, double pret)
        {

            this.NumeFirma = numeFirma;
            this.Model = model;
            this.AnFabricatie = anFabricatie;
            this.CULOARE = (Culoare)culoare;
            this.OPTIUNI = (Optiuni)optiuni;
            this.Pret = pret;

        }
        //constructor sir de caractere
        public Masina(string s)
        {
            string[] date = s.Split(" ");
            NumeFirma = date[NUMEFIRMA];
            Model = date[MODEL];
            AnFabricatie = Convert.ToInt32(date[ANFABRICATIE]);
            CULOARE = (Culoare)Convert.ToInt32(date[INDEXCULOARE]);
            OPTIUNI = (Optiuni)Convert.ToInt32(date[INDEXOPTIUNI]);
            Pret = Convert.ToDouble(date[PRET]);

        }

        public int Compara(Masina m1)
        {
            if (this.Pret > m1.Pret)
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
            buff += "Masina: " + NumeFirma + "\nModel: " + Model + "\nAn Fabricatie: " + AnFabricatie + "\nCuloare: " + CULOARE + "\nOptiuni: " + OPTIUNI + "\nPret: " + Pret + "$\n";
            return buff;
        }

        public string ConversieLaSir_PentruFisiere()
        {
            return string.Format(NumeFirma+";"+Model+";"+AnFabricatie+";"+CULOARE+";"+OPTIUNI+";"+Pret);
        }
    }
            
}
