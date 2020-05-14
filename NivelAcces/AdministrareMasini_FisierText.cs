using System;
using System.Collections.Generic;
using System.IO;
using Modele;


namespace NivelAcces
{
    public class AdministrareMasini_FisierText : IStocareDataMasini
    {
            private const int PAS_ALOCARE = 10;
            string NumeFisier { get; set; }
            public AdministrareMasini_FisierText(string numeFisier)
            {
                this.NumeFisier = numeFisier;
                Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
                sFisierText.Close();

                //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
                //instructiunea 'using' va apela sFisierText.Close();
                //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
            }
            public void AddMasina(Masina m)
            {
                try
                {
                    //instructiunea 'using' va apela la final swFisierText.Close();
                    //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                    using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                    {
                        swFisierText.WriteLine(m.ConversieLaSir_PentruFisiere());
                    }
                }
                catch (IOException eIO)
                {
                    throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
                }
                catch (Exception eGen)
                {
                    throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
                }
            }
        public void UpdateMasina(Masina m, int index)
        {
            List<Masina> masini = GetMasini(out int nrMasini);
            int indexMasina = 0;

            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Masina msn in masini)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (indexMasina == index)
                        {
                            swFisierText.WriteLine(m.ConversieLaSir_PentruFisiere());
                        }
                        else
                        {
                            swFisierText.WriteLine(msn.ConversieLaSir_PentruFisiere());
                        }
                        indexMasina++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

        }
        public List<Masina> GetMasini(out int nrMasini)
            {
                List<Masina> masini = new List<Masina>();

                try
                {
                    // instructiunea 'using' va apela sr.Close()
                    using (StreamReader sr = new StreamReader(NumeFisier))
                    {
                        string line;
                        nrMasini = 0;

                        //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                        while ((line = sr.ReadLine()) != null)
                        {
                            Masina m = new Masina(line);
                            masini.Add( m );
                            nrMasini++;
                        }
                    }
                }
                catch (IOException eIO)
                {
                    throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
                }
                catch (Exception eGen)
                {
                    throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
                }

                return masini;
            }

        public List<Masina> GetMasiniIndex(int index)
        {
            List<Masina> masini = new List<Masina>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    int nrMasini = 0;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masina m = new Masina(line);
                        masini.Add(m);

                        if(nrMasini == index)
                        {
                            return masini;
                        }
                        nrMasini++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return null;
        }
    }
}
