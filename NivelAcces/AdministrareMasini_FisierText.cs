//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections.Generic;
using System.IO;
using Modele;


namespace NivelAcces
{
    public class AdministrareMasini_FisierText : IStocareDataMasini
    {
            private int ID_PRIMA_MASINA = 1;
            private int INCREMENT = 1;
            private const int PAS_ALOCARE = 10;
            string NumeFisier { get; set; }
            public AdministrareMasini_FisierText(string numeFisier)
            {
                this.NumeFisier = numeFisier;
                Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
                sFisierText.Close();
            }

        private int GetId()
        {
            int IdMasina = ID_PRIMA_MASINA;
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Masina m = new Masina(line);
                        IdMasina = m.IdMasina + INCREMENT;
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
            return IdMasina;
        }

        public void AddMasina(Masina m)
            {
            m.IdMasina = GetId();
                try
                {
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
        public void StergeMasina(Masina m)
        {
            List<Masina> masini = GetMasini();
 
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Masina msn in masini)
                    {
                        if (msn == m)
                        {
                            continue;
                        }
                        else
                        {
                            swFisierText.WriteLine(msn.ConversieLaSir_PentruFisiere());
                        }
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
        public void UpdateMasina(Masina m)
        {
            List<Masina> masini = GetMasini();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Masina msn in masini)
                    {
                        if (msn.IdMasina == m.IdMasina)
                        {
                            swFisierText.WriteLine(m.ConversieLaSir_PentruFisiere());
                        }
                        else
                        {
                            swFisierText.WriteLine(msn.ConversieLaSir_PentruFisiere());
                        }
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
        public List<Masina> GetMasini()
            {
                List<Masina> masini = new List<Masina>();

                try
                {
                    using (StreamReader sr = new StreamReader(NumeFisier))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Masina m = new Masina(line);
                            masini.Add( m );
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
