using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Modele

{
    //clasa Masina cu parametrii auto-implemented
    public class Masina
    {
        const int ID = 0;
        const int NUMEFIRMA = 1;
        const int MODEL = 2;
        const int ANFABRICATIE = 3;
        const int INDEXCULOARE = 4;
        const int INDEXOPTIUNI = 5;
        const int PRET = 6;
        const int DATA = 7;
        const int OPTIUNI_INT = 8;
        const int SERIE = 9;
        const int NUMEPROPRIETAR = 10;


        public int IdMasina { set; get; }
        public string NumeFirma { set; get; }
        public string Model { set; get; }
        public int AnFabricatie { set; get; }
        public Culoare CULOARE { set; get; }
        public Optiuni OPTIUNI { set; get; }
        public double Pret { set; get; }
        public DateTime DataActualizare { set; get; }
        public string NumeProprietar { get; set; }
        public string SerieMasina;
        public string optiuniInt { set; get; }

        public string SerieMasinaImplemented
        {
            set { SerieMasina = SerieUnica() + IdMasina.ToString() + DataActualizare.Day; }
            get { return SerieMasina; }
        }

        private string SerieUnica()
        {
            string serie = "";
            Random rnd = new Random();
            string choose = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for(int i=0; i<8; i++)
            {
                serie += choose[rnd.Next(choose.Length-1)];
            }
            return serie;
        }

        //constructor implicit fara parametrii
        public Masina()
        {
            NumeFirma = string.Empty;
            Model = string.Empty;
            AnFabricatie = 0;
            CULOARE = Culoare.None;
            OPTIUNI = Optiuni.None;
            Pret = 0;
            IdMasina++;
            
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
            string[] date = s.Split(';');
            IdMasina = Convert.ToInt32(date[ID]);
            NumeFirma = date[NUMEFIRMA];
            Model = date[MODEL];
            AnFabricatie = Convert.ToInt32( date[ANFABRICATIE] );
            CULOARE = (Culoare)Convert.ToInt32( date[INDEXCULOARE] );
            OPTIUNI = (Optiuni)Convert.ToInt32( date[INDEXOPTIUNI] );
            Pret = Convert.ToDouble( date[PRET] );
            string dataFisier = date[DATA];

            DataActualizare = Convert.ToDateTime(dataFisier);
            optiuniInt = date[OPTIUNI_INT];
            SerieMasina = date[SERIE];
            NumeProprietar = date[NUMEPROPRIETAR];
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
            return string.Format( "#ID: " + IdMasina + "\nMasina: " + NumeFirma + "\nModel: " + Model + "\nAn Fabricatie: " + AnFabricatie + "\nCuloare: " + CULOARE + "\nOptiuni: " + OPTIUNI + "\nPret: " + Pret + "$" +"\nProprietar: "+NumeProprietar+"\n\n" );           
        }

        public string ConversieLaSir_PentruFisiere()
        {
            return string.Format(IdMasina + ";" + NumeFirma + ";" + Model + ";" + AnFabricatie + ";" + Convert.ToInt32(CULOARE) + ";" + Convert.ToInt32(OPTIUNI) + ";" + Pret + ";" + DataActualizare + ';' + string.Join(" ",optiuniInt)+";"+SerieMasina+";"+NumeProprietar);
        }
    }
            
}
