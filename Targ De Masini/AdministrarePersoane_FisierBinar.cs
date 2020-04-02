using System;

namespace Targ_De_Masini
{
    public class AdministrarePersoane_FisierBinar// : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrarePersoane_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddPersoana(Persoana p)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public Persoana[] GetPersoane(out int nrPersoane)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
