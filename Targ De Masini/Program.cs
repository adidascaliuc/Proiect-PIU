using System;

namespace Targ_De_Masini 
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrPersoane = 0;
            int nrMasini;

            Persoana[] persoane = new Persoana[50];
            Masina[] masini;


            IStocareData adminMasini = StocareFactory.GetAdministratorStocare();
            IStocareData adminPersoane = StocareFactory.GetAdministratorStocare();
            
            masini = adminMasini.GetMasini(out nrMasini);
            //persoane = adminPersoane.GetPersoane(out nrPersoane);

            while (true)
            {
                Console.WriteLine("P - adauga persoana\n" +
                    "M - adauga masina\n" +
                    "A - afiseaza persoane\n" +
                    "C - compara 2 persoane\n" +
                    "N - afiseaza masini\n" +
                    "O - modifica masina\n" +
                    "R - modificare persoana\n" +
                    "F - citeste din fisier\n" +
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
                        persoane[nrPersoane++] = new Persoana(nume, prenume, tipPersoana, buget);

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
                            "(Pentru a alege optiuni multiple va rugam sa adunati\n" +
                            "numerele din fata si sa introduceti suma): \n" +
                            "1. Aer Conditionat\n" +
                            "2. Optiuni Volan\n" +
                            "4. Scaune De Piele\n" +
                            "8. Modul Bengos\n" +
                            "16. Navigatie\n" +
                            "32. Cutie Automata\n");

                        int optiuni = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduceti pretul masinii: ");
                        double pret = Convert.ToDouble(Console.ReadLine());

                        adminMasini.AddMasina(masini[nrMasini++] = new Masina(firma, model, anF, culoare, optiuni, pret));

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
                        int id1 = Convert.ToInt32( Console.ReadLine() ) - 1;

                        Console.WriteLine("Introduceti id-ul pntru a doua persoana: ");
                        int id2 = Convert.ToInt32( Console.ReadLine() ) - 1;
                        int rezultat = persoane[id1].Compara(persoane[id2]);

                        if(rezultat == 1)
                        {
                            Console.WriteLine(persoane[id1].tipPersoana+"ul " + persoane[id1].NumeComplet + " este mai bogat decat " + persoane[id2].tipPersoana.ToString().ToLower() + "ul " +
                                persoane[id2].NumeComplet + " cu " + ((float)(persoane[id1].Buget- persoane[id2].Buget)), .2f);
                        }

                        if(rezultat == -1)
                        {
                            Console.WriteLine(persoane[id2].tipPersoana + "ul " + persoane[id2].NumeComplet + " este mai bogat decat " + persoane[id1].tipPersoana + "ul " +
                                persoane[id1].NumeComplet + " cu " + ((float)(persoane[id2].Buget - persoane[id1].Buget)), .2f);
                        }
                        else
                        {
                            Console.WriteLine("Persoanele au aceeasi suma de bani.");
                        }
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
                            "(Pentru a alege optiuni multiple va rugam sa adunati\n" +
                            "numerele din fata si sa introduceti suma): \n" +
                            "1. Aer Conditionat\n" +
                            "2. Optiuni Volan\n" +
                            "4. Scaune De Piele\n" +
                            "8. Modul Bengos\n" +
                            "16. Navigatie\n" +
                            "32. Cutie Automata\n");

                                optiuni = Convert.ToInt32(Console.ReadLine());
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
                            }

                        }

                        break;

                    case "R":
                        bool anotherPers = true;
                        Console.WriteLine("Introduceti ID-ul persoanei pe care doriti sa o modificati: ");
                        int id = Convert.ToInt32(Console.ReadLine() ) - 1;

                        while (anotherPers)
                        {
                            Console.WriteLine("Ce doriti sa modificati?\n");
                            Console.WriteLine("1. Nume\n" +
                                "2. Prenume\n" +
                                "3. Tipul Persoanei\n" +
                                "4. Buget\n");
                            int optiune = Convert.ToInt32( Console.ReadLine() );

                            if(optiune == 1)
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
                                persoane[id].Buget = Convert.ToDouble( Console.ReadLine() );
                            }

                            Console.WriteLine("Doriti sa mai faceti modificari? [Y/N]");
                            string ans = Console.ReadLine().ToUpper();

                            if(ans == "Y")
                            {
                                anotherPers = true;
                            }
                            else
                            {
                                anotherPers = false;
                            }

                        }

                        break;

                    case "F":
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
