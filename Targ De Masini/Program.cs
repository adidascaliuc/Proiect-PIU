using System;

namespace Targ_De_Masini 
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrPersoane = 0, nrMasini = 0;
            Persoana[] persoane = new Persoana[50];
            Masina[] masini = new Masina[50];

            while (true)
            {
                Console.WriteLine("P - adauga persoana\n" +
                    "M - adauga masina\n" +
                    "A - afiseaza persoane\n" +
                    "N - afiseaza masini\n" +
                    "C - citeste din fisier\n" +
                    "S - salveaza in fisier\n" +
                    "X - Iesire\n");
                Console.WriteLine("Alegeti o optiune: ");
                string opt = Console.ReadLine();
                switch (opt.ToUpper()) {
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
                        int buget = Convert.ToInt32( Console.ReadLine() );
                        persoane[nrPersoane++] = new Persoana(nume, prenume, tipPersoana, buget);

                        break;

                    case "M":
                        Console.WriteLine("Introduceti numele firmei: ");
                        string firma = Console.ReadLine();

                        Console.WriteLine("Introduceti modelul: ");
                        string model = Console.ReadLine();

                        Console.WriteLine("Introduceti anul fabricatiei: ");
                        int anF = Convert.ToInt32( Console.ReadLine() );

                        Console.WriteLine("Alegeti o culoare: \n" +
                            "1. Alb\n" +
                            "2. Negru\n" +
                            "3. Rosu\n" +
                            "4. Albastru\n" +
                            "5. Verde\n");
                        int culoare = Convert.ToInt32( Console.ReadLine() );

                        Console.WriteLine("Introduceti pretul masinii: ");
                        double pret = Convert.ToDouble( Console.ReadLine() );

                        masini[nrMasini++] = new Masina(firma, model, anF, culoare, pret);

                        break;

                    case "A":
                        Console.WriteLine("Avem introduse " + nrPersoane + " persoane.");
                        for(int i=0; i<nrPersoane; i++)
                        {
                            Console.WriteLine((i+1) + ". " + persoane[i].ConversieLaSir());
                        }

                        break;

                    case "N":
                        Console.WriteLine("Avem in stoc " + nrMasini + " masini.");
                        for(int i=0; i<nrMasini; i++)
                        {
                            Console.WriteLine((i+1) + ". " + masini[i].ConversieLaSir());
                        }

                        break;

                    case "C":
                        break;

                    case "S":
                        break;

                    case "X":
                        return;
                        break;

                    default:
                        break;
                }

            }
            


        }   

    }
}
