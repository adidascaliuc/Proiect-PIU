using System;
using System.Collections.Generic;
using System.Text;

namespace Targ_De_Masini
{
    class Persoana
    {
        int NUME = 0;
        int PRENUME = 1;
        int TIPPERSOANA = 2;
        int BUGET = 3;

        
        
        
        //parametrii auto-implemented
        public string nume { set; get; }
        public string prenume { set; get; }
        public string tipPersoana { set; get; }
        public string numeComplet { get{ return nume +" "+ prenume; } }
        double buget;

        public Persoana() //constructor implicit fara parametrii
        {
            nume = string.Empty;
            prenume = string.Empty;
            tipPersoana = string.Empty;
            buget = 0.0f;
   
        }

        public Persoana(string nume, string prenume, string tipPersoana, double buget) //constructor cu parametrii
        {
            this.nume = nume;
            this.prenume = prenume;
            this.tipPersoana = tipPersoana;
            this.buget = buget;

        }

        //constructor sir de caractere
        public Persoana(string s)
        {
            string[] date = s.Split( );
            nume = date[NUME];
            prenume = date[PRENUME];
            tipPersoana = date[TIPPERSOANA];
            buget = Double.Parse(date[BUGET]);

        }

        public void Compara(Persoana p1)
        {
            if(p1.buget > this.buget)
            {
                Console.WriteLine(p1.tipPersoana+"ul " + p1.numeComplet + " este mai bogat decat " + this.tipPersoana.ToLower() + "ul " +
                    this.numeComplet + " cu " + ((float)(p1.buget-this.buget)), .2f);
            }
            else
            {
                Console.WriteLine(this.tipPersoana + "ul " + this.numeComplet + " este mai bogat decat " + p1.tipPersoana + "ul " +
                    p1.numeComplet + " cu " + ((float)(this.buget - p1.buget)), .2f);
            }
        }

        public string ConversieLaSir() //Afiseaza date despre persoana
        {
            string buff = "";
            buff += "Nume " + tipPersoana + ": " + numeComplet;
            buff += "\nBuget: " + buget + "$\n";
            return buff;
        }
    }
}
