using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Modele
{
    public class Persoana
    {
        string SEPARATOR_FISIER = ";";

        int NUME = 0;
        int PRENUME = 1;
        int USERNAME = 2;
        int PASSWORD = 3;
        int BUGET = 4;
        int MASINI = 5;


        public List<Masina> masini = null;
        //parametrii auto-implemented
        public string Nume { set; get; }
        public string Prenume { set; get; }
        public TipPersoana tipPersoana { set; get; }
        public string NumeComplet { get{ return Nume +" "+ Prenume; } }
        public double Buget;
        public string Username { set; get; }
        public string Password { set; get; }

        public Persoana() //constructor implicit fara parametrii
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            tipPersoana = TipPersoana.None;
            Buget = 0.0f;
   
        }

        public Persoana(string nume, string prenume, string username, string password) //constructor cu parametrii
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Username = username;
            this.Password = password;
            this.Buget = 0;
            masini = null;

        }

        //constructor sir de caractere
        public Persoana(string s)
        {
            string[] date = s.Split( );
            Nume = date[NUME];
            Prenume = date[PRENUME];
            Username = date[USERNAME];
            Password = date[PASSWORD];
            Buget = Double.Parse( date[BUGET] );
           // masini.Add(date[MASINI]);

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
            string date = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", SEPARATOR_FISIER, Nume, Prenume, Username, Password, Buget, masini);

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
