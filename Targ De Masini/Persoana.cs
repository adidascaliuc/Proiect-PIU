using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Targ_De_Masini
{
    class Persoana
    {
        int NUME = 0;
        int PRENUME = 1;
        int TIPPERSOANA = 2;
        int BUGET = 3;
        string SEPARATOR_FISIER = " ";
        int PAS_ALOCARE = 1;
       
        //parametrii auto-implemented
        public string nume { set; get; }
        public string prenume { set; get; }
        public TipPersoana tipPersoana { set; get; }
        public string numeComplet { get{ return nume +" "+ prenume; } }
        double buget;

        public Persoana() //constructor implicit fara parametrii
        {
            nume = string.Empty;
            prenume = string.Empty;
            tipPersoana = TipPersoana.None;
            buget = 0.0f;
   
        }

        public Persoana(string nume, string prenume, int tipPersoana, double buget) //constructor cu parametrii
        {
            this.nume = nume;
            this.prenume = prenume;
            this.tipPersoana = (TipPersoana) Convert.ToInt32( tipPersoana );
            this.buget = buget;

        }

        //constructor sir de caractere
        public Persoana(string s)
        {
            string[] date = s.Split( );
            nume = date[NUME];
            prenume = date[PRENUME];
            tipPersoana = (TipPersoana) Convert.ToInt32( date[TIPPERSOANA] );
            buget = Double.Parse( date[BUGET] );

        }

        public int Compara(Persoana p1)
        {
            if(p1.buget > this.buget)
            {
                return -1;
                //Console.WriteLine(p1.tipPersoana+"ul " + p1.numeComplet + " este mai bogat decat " + this.tipPersoana.ToString().ToLower() + "ul " +
                //    this.numeComplet + " cu " + ((float)(p1.buget-this.buget)), .2f);
            }
            else if(p1.buget < this.buget)
            {
                return 1;
                //Console.WriteLine(this.tipPersoana + "ul " + this.numeComplet + " este mai bogat decat " + p1.tipPersoana + "ul " +
                //    p1.numeComplet + " cu " + ((float)(this.buget - p1.buget)), .2f);
            }
            return 0; //Acelasi buget
        }


        public void wrtFile(string numeFisier)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    swFisierText.WriteLine(this.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public Persoana[] readFile(out int nrPersoane)
        {
            Persoana[] persoane = new Persoana[PAS_ALOCARE];
            nrPersoane = 0;

            try
            {
                Console.WriteLine("Introduceti numele fisierului: ");
                string numeFisier = Console.ReadLine();
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string linie;
                    int numarLinie = 0;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        persoane[numarLinie++] = new Persoana(linie);
                        if (numarLinie == PAS_ALOCARE)
                        {
                            Array.Resize(ref persoane, numarLinie + PAS_ALOCARE);
                        }
                    }
                    nrPersoane = numarLinie;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return persoane;
        }
        


        public string ConversieLaSir_PentruFisier()
        { 
            string date = string.Format("{1}{0}{2}{0}{3}", SEPARATOR_FISIER, numeComplet, tipPersoana, buget);

            return date;
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
