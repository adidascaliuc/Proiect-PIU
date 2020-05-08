using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Modele;
using NivelAcces;

namespace Targ_De_Masini 
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nrPersoane;
            //int nrMasini;

            List<Persoana> persoane = new List<Persoana>();
            List<Masina> masini = new List<Masina>();


            IStocareDataMasini adminMasini = StocareFactoryMasini.GetAdministratorStocare();
            IStocareDataPersoane adminPersoane = StocareFactoryPersoane.GetAdministratorStocare();
            
            masini = adminMasini.GetMasini(out int nrMasini);
            persoane = adminPersoane.GetPersoane(out int nrPersoane);

            while (true)
            {
                Console.WriteLine("P - adauga persoana\n" +
                    "A - afiseaza persoane\n" +
                    "C - compara 2 persoane\n" +
                    "R - modificare persoana\n" +
                    "M - adauga masina\n" + 
                    "N - afiseaza masini\n" +
                    "O - modifica masina\n" +
                    "X - Iesire\n");
                Console.WriteLine("Alegeti o optiune: ");
                string opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "P":
                        Console.WriteLine("Introduceti numele persoanei: ");
                        string nume = Console.ReadLine();

                        Console.WriteLine("Introduceti prenumele persoanei: ");
                        string prenume = Console.ReadLine();

                        Console.WriteLine("Ati venit in calitate de: \n" +
                            "1. Cumparator\n" +
                            "2. Vanzator\n");
                        int tipPersoana = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti bugetul: ");
                        int buget = Convert.ToInt32(Console.ReadLine());
                        adminPersoane.AddPersoana(persoane[nrPersoane++] = new Persoana(nume, prenume, tipPersoana, buget));

                        break;

                    case "A":
                        Console.WriteLine("Avem introduse " + nrPersoane + " persoane.");
                        for (int i = 0; i < nrPersoane; i++)
                        {
                            Console.WriteLine("ID " + " #" + (i + 1) + "\n" + persoane[i].ConversieLaSir());
                        }

                        break;

                    case "C":
                        Console.WriteLine("Introduceti id-ul primei persoane: ");
                        int id1 = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("Introduceti id-ul pntru a doua persoana: ");
                        int id2 = Convert.ToInt32(Console.ReadLine()) - 1;
                        int rezultat = persoane[id1].Compara(persoane[id2]);

                        if (rezultat == 1)
                        {
                            Console.WriteLine(persoane[id1].tipPersoana + "ul " + persoane[id1].NumeComplet + " este mai bogat decat " + persoane[id2].tipPersoana.ToString().ToLower() + "ul " +
                                persoane[id2].NumeComplet + " cu " + ((float)(persoane[id1].Buget - persoane[id2].Buget)), .2f + "$");
                        }

                        if (rezultat == -1)
                        {
                            Console.WriteLine(persoane[id2].tipPersoana + "ul " + persoane[id2].NumeComplet + " este mai bogat decat " + persoane[id1].tipPersoana + "ul " +
                                persoane[id1].NumeComplet + " cu " + ((float)(persoane[id2].Buget - persoane[id1].Buget)), .2f);
                        }
                        else
                        {
                            Console.WriteLine("Persoanele au aceeasi suma de bani.");
                        }
                        break;

                    case "R":
                        bool anotherPers = true;
                        Console.WriteLine("Introduceti ID-ul persoanei pe care doriti sa o modificati: ");
                        int id = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                        while (anotherPers)
                        {
                            Console.WriteLine("Ce doriti sa modificati?\n");
                            Console.WriteLine("1. Nume\n" +
                                "2. Prenume\n" +
                                "3. Tipul Persoanei\n" +
                                "4. Buget\n");
                            int optiune = Convert.ToInt32(Console.ReadLine());

                            if (optiune == 1)
                            {
                                Console.WriteLine("Reintroduceti numele: ");
                                persoane[id].Nume = Console.ReadLine();
                            }

                            if (optiune == 2)
                            {
                                Console.WriteLine("Reintroduceti prenumele: ");
                                persoane[id].Prenume = Console.ReadLine();
                            }

                            if (optiune == 3)
                            {
                                Console.WriteLine("Reintroduceti tipul de persoana: ");
                                Console.WriteLine("Ati venit in calitate de: \n" +
                                                "1. Cumparator\n" +
                                                "2. Vanzator\n");
                                tipPersoana = Convert.ToInt32(Console.ReadLine());
                                persoane[id].tipPersoana = (TipPersoana)tipPersoana;
                            }

                            if (optiune == 4)
                            {
                                Console.WriteLine("Reintroduceti bugetul: ");
                                persoane[id].Buget = Convert.ToDouble(Console.ReadLine());
                            }

                            Console.WriteLine("Doriti sa mai faceti modificari? [Y/N]");
                            string ans = Console.ReadLine().ToUpper();

                            if (ans == "Y")
                            {
                                anotherPers = true;
                            }
                            else
                            {
                                anotherPers = false;
                                File.WriteAllText(ConfigurationManager.AppSettings["NumeFisierPersoane"] + ".txt", string.Empty);
                                for (int i=0; i<nrPersoane; i++)
                                {
                                    adminPersoane.AddPersoana(persoane[i]);
                                }
                            
                            }
                            

                        }

                        break;
                    
                    case "M":
                        Console.WriteLine("Introduceti numele firmei: ");
                        string firma = Console.ReadLine();

                        Console.WriteLine("Introduceti modelul: ");
                        string model = Console.ReadLine();

                        Console.WriteLine("Introduceti anul fabricatiei: ");
                        int anF = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Alegeti o culoare: \n" +
                            "1. Alb\n" +
                            "2. Negru\n" +
                            "3. Rosu\n" +
                            "4. Albastru\n" +
                            "5. Verde\n");
                        int culoare = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Alegeti optiunile\n" +
                            "(Introduceti optiunile prin spatiere: \n" +
                            "1. Aer Conditionat\n" +
                            "2. Optiuni Volan\n" +
                            "3. Scaune De Piele\n" +
                            "4. Modul Bengos\n" +
                            "5. Navigatie\n" +
                            "6. Cutie Automata\n");

                        string[] date = Console.ReadLine().Split(' ');
                        int optiuni = 0;
                        foreach(string data in date)
                        {
                            optiuni += Convert.ToInt32( Math.Pow(2, Convert.ToDouble(data)-1) );
                        }
                        Console.WriteLine(optiuni);
                        Console.WriteLine("Introduceti pretul masinii: ");
                        double pret = Convert.ToDouble(Console.ReadLine());

                        adminMasini.AddMasina(masini[nrMasini++] = new Masina(firma, model, anF, culoare, optiuni, pret));

                        break;

                    
                    
                    case "N":
                        Console.WriteLine("Avem in stoc " + nrMasini + " masini.");
                        for (int i = 0; i < nrMasini; i++)
                        {
                            Console.WriteLine("ID "+ " #" + (i + 1) +  "\n" + masini[i].ConversieLaSir());
                        }

                        break;
                    case "O":
                        Console.WriteLine("Introduceti indexul masinii pe care doriti sa o modificati: ");
                        int index = Convert.ToInt32( Console.ReadLine() ) - 1;
                        bool another = true;
                        while (another)
                        {
                            Console.WriteLine("Ce doriti sa modificati?\n" +
                                "1. Firma\n" +
                                "2. Model\n" +
                                "3. An Fabricatie\n" +
                                "4. Culoare\n" +
                                "5. Optiuni\n" +
                                "6.Pret");
                            int mod = Convert.ToInt32( Console.ReadLine() );
                            if(mod == 1)
                            {
                                Console.WriteLine("Reintroduceti firma: ");
                                masini[index].NumeFirma = Console.ReadLine();
                            }
                            if (mod == 2)
                            {
                                Console.WriteLine("Reintroduceti modelul: ");
                                masini[index].Model = Console.ReadLine();
                            }
                            if (mod == 3)
                            {
                                Console.WriteLine("Reintroduceti anul fabricatiei: ");
                                masini[index].AnFabricatie = Convert.ToInt32( Console.ReadLine() );
                            }
                            if (mod == 4)
                            {
                                Console.WriteLine("Reintroduceti culoarea: ");
                                Console.WriteLine("Alegeti o culoare: \n" +
                            "1. Alb\n" +
                            "2. Negru\n" +
                            "3. Rosu\n" +
                            "4. Albastru\n" +
                            "5. Verde\n");
                                culoare = Convert.ToInt32(Console.ReadLine());
                                masini[index].CULOARE = (Culoare)culoare;
                            }
                            if (mod == 5)
                            {
                                Console.WriteLine("Reintroduceti optiunile: ");
                                Console.WriteLine("Alegeti optiunile\n" +
                            "(Introduceti optiunile prin spatiere): \n" +
                            "1. Aer Conditionat\n" +
                            "2. Optiuni Volan\n" +
                            "3. Scaune De Piele\n" +
                            "4. Modul Bengos\n" +
                            "5. Navigatie\n" +
                            "6. Cutie Automata\n");

                                string[] datee = Console.ReadLine().Split(' ');
                                optiuni = 0;
                                foreach (string data in datee)
                                {
                                    optiuni += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(data)-1));
                                }
                                masini[index].OPTIUNI = (Optiuni)optiuni;
                            }
                            if (mod == 6)
                            {
                                Console.WriteLine("Reintroduceti pretul: ");
                                masini[index].Pret = Convert.ToDouble( Console.ReadLine() );
                            }
                            Console.WriteLine("Doriti sa mai schimbati ceva?[Y/N]");
                            string answer = Console.ReadLine().ToUpper();
                            if(answer == "Y")
                            {
                                another = true;
                            }
                            else
                            {
                                another = false;
                                File.WriteAllText(ConfigurationManager.AppSettings["NumeFisierMasini"] + "." + ConfigurationManager.AppSettings["NumeFormat"], string.Empty);
                                for (int i = 0; i < nrMasini; i++)
                                {
                                    adminMasini.AddMasina(masini[i]);
                                }

                            }

                        }

                        break;

                    
                            
                    case "X":
                        return;
                    
                    default:
                        break;
                }
            }            
        }   
    }
}
