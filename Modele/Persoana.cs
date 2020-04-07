using System;
using System.Configuration;
using System.IO;

namespace Modele
{
    public class Persoana
    {
        int NUME = 0;
        int PRENUME = 1;
        int TIPPERSOANA = 2;
        int BUGET = 3;
        string SEPARATOR_FISIER = " ";
        int PAS_ALOCARE = 1;
       
        //parametrii auto-implemented
        public string Nume { set; get; }
        public string Prenume { set; get; }
        public TipPersoana tipPersoana { set; get; }
        public string NumeComplet { get{ return Nume +" "+ Prenume; } }
        public double Buget;

        public Persoana() //constructor implicit fara parametrii
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            tipPersoana = TipPersoana.None;
            Buget = 0.0f;
   
        }

        public Persoana(string nume, string prenume, int tipPersoana, double buget) //constructor cu parametrii
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.tipPersoana = (TipPersoana) Convert.ToInt32( tipPersoana );
            this.Buget = buget;

        }

        //constructor sir de caractere
        public Persoana(string s)
        {
            string[] date = s.Split( );
            Nume = date[NUME];
            Prenume = date[PRENUME];
            tipPersoana = (TipPersoana) Convert.ToInt32( date[TIPPERSOANA] );
            Buget = Double.Parse( date[BUGET] );

        }

        public int Compara(Persoana p1)
        {
            if(p1.Buget > this.Buget)
            {
                return -1;
                
            }
            else if(p1.Buget < this.Buget)
            {
                return 1;
               
            }
            return 0; //Acelasi buget
        }

        public string ConversieLaSir_PentruFisier()
        { 
            string date = string.Format("{1}{0}{2}{0}{3}{0}{4}", SEPARATOR_FISIER, Nume, Prenume, Convert.ToInt32(tipPersoana), Buget);

            return date;
        }

        public string ConversieLaSir() //Afiseaza date despre persoana
        {
            string buff = "";
            buff += "Nume " + tipPersoana + ": " + NumeComplet;
            buff += "\nBuget: " + Buget + "$\n";
            return buff;
        }
    }
}
