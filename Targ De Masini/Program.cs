using System;

namespace Targ_De_Masini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||==============||\n" +
                              "||Clasa Persoana||\n" + 
                              "||==============||");
            //Instantierea unui obiectd de tip Persoana fara parametrii
            Persoana p1 = new Persoana();
            Console.WriteLine(p1.ConversieLaSir());//Afisare informatii despre persoana
            Console.WriteLine();

            //Instantierea unui obiect de tip Persoana cu parametrii
            Persoana p2 = new Persoana("Dascaliuc", "Adi", Persoana.optTipPersoana(), 10450.85); ;
            Console.WriteLine(p2.ConversieLaSir());
            p2.wrtFile("PersoaneOut");
            Console.WriteLine();

            //Intantierea unui obiect de tip Persoana cu parametrii intr-un sir de caractere
            Persoana p3 = new Persoana("Marinescu Marin 2 16788.23");
            Console.WriteLine(p3.ConversieLaSir());
            Console.WriteLine();

            //Instantierea unui obiect de tip Persoana cu parametrii introdusi de la tastatura
            Console.WriteLine("Introduceti pe rand numele, prenumele, tipul de persoana (Cumparator/Vanzator) si bugetul: ");
            Persoana p4 = new Persoana(Console.ReadLine(), Console.ReadLine(), Persoana.optTipPersoana(), Double.Parse(Console.ReadLine()));
            Console.WriteLine(p4.ConversieLaSir());
            p2.Compara(p3);
            Console.WriteLine();



            /*
            Console.WriteLine("==========================================\n"+
                "===============Clasa Masina===============");
            //Instantierea unui obiect de tip Masina fara parametrii
            Masina m1 = new Masina();
            Console.WriteLine(m1.ConversieLaSir());//Afisare informatii despre masina
            Console.WriteLine();

            //Instantierea unui obiect de tip Masina cu parametrii
            Masina m2 = new Masina("Audi", "Q5", 2019, Masina.optCuloare(), 17500.39);
            Console.WriteLine(m2.ConversieLaSir());
            Console.WriteLine();

            //Instantierea unui obiect de tip Masina cu parametrii intr-un sir de caractere
            Masina m3 = new Masina("VW Tiguan 2012 2 12500.99");
            Console.WriteLine(m3.ConversieLaSir());
            Console.WriteLine();

            //Instantierea unui obiect de tip Masina cu parametrii cititi de la tastatura
            Console.WriteLine("Introduceri pe rand firma, modelul, anul fabricatiei, culoarea si pretul masinii: ");
            Masina m4 = new Masina(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32( Console.ReadLine() ), Masina.optCuloare(), Convert.ToDouble( Console.ReadLine() ) );
            Console.Write("\n");
            Console.WriteLine(m4.ConversieLaSir());

            m2.Compara(m3);
            Console.WriteLine();
            */

        }   

    }
}
