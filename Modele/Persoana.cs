//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.IO;
using System.Linq;

namespace Modele
{
    public class Persoana
    {
        string SEPARATOR_FISIER = "|";

        const int NUME = 0;
        const int PRENUME = 1;
        const int USERNAME = 2;
        const int PASSWORD = 3;
        const int BUGET = 4;
        const int MASINI = 5;
        const int IMAGE = 6;


        //parametrii auto-implemented
        public string Nume { set; get; }
        public string Prenume { set; get; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public double Buget;
        public string Username { set; get; }
        public string Password { set; get; }
        public List<Masina> masiniCumparate = new List<Masina>();
        string imageLocation;
        public string ImageLocation
        {
            set
            {
                imageLocation = @value;
            }
            get

            {               
                    return imageLocation;                              
            }
        }

        public Persoana() //constructor implicit fara parametrii
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            Buget = 0.0f;
        }

        public Persoana(string nume, string prenume, string username, string password) //constructor cu parametrii
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Username = username;
            this.Password = password;
            this.Buget = 0;
            masiniCumparate = null;

        }

        //constructor sir de caractere
        public Persoana(string s)
        {
            string[] date = s.Split('|');
            Nume = date[NUME];
            Prenume = date[PRENUME];
            Username = date[USERNAME];
            Password = date[PASSWORD];
            Buget = Double.Parse(date[BUGET]);
            if (date[MASINI] == "" || date[MASINI] == null)
            {
                masiniCumparate.Add(null);
            }
            else
            {
                masiniCumparate.Add(new Masina(date[MASINI]));
            }
            ImageLocation = date[IMAGE];
        }

        public string masiniToString()
        {
            string masini = "";
            if (masiniCumparate != null)
                foreach (Masina m in masiniCumparate)
                {
                    if (m != null)
                    {
                        masini += m.ConversieLaSir_PentruFisiere() + "@";
                    }
                }
            return masini;
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}", SEPARATOR_FISIER, Nume, Prenume, Username, Password, Buget, masiniToString(), ImageLocation);
        }

        public string ConversieLaSir() //Afiseaza date despre persoana
        {
            string buff = "";
            buff += "Nume : " + NumeComplet;
            buff += "\nBuget: " + Buget + "$\n";
            return buff;
        }
    }
}
