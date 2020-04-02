using System;
using System.Collections.Generic;

namespace Targ_De_Masini
{
    public class AdministrareMasini_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMasina(Masina m)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public Masina[] GetMasini(out int nrMasini)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
