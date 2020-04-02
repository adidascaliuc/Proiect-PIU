using System;

namespace Targ_De_Masini 
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrPersoane = 0;
            int nrMasini = 0;

            Persoana[] persoane = new Persoana[50];
            Masina[] masini;


            IStocareData adminMasini = StocareFactory.GetAdministratorStocare();
            
            masini = adminMasini.GetMasini(out nrMasini);

            while (true)
            {
                Console.WriteLine("P - adauga persoana\n" +
                    "M - adauga masina\n" +
                    "A - afiseaza persoane\n" +
                    "N - afiseaza masini\n" +
                    "O - modifica masina\n" +
                    "C - citeste din fisier\n" +
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
                            "2.Vanzator\n");
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
                            Console.WriteLine((i + 1) + ". " + persoane[i].ConversieLaSir());
                        }

                        break;

                    case "N":
                        Console.WriteLine("Avem in stoc " + nrMasini + " masini.");
                        for (int i = 0; i < nrMasini; i++)
                        {
                            Console.WriteLine("ID "+(i + 1) + "# " + masini[i].ConversieLaSir());
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

                    case "C":
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
