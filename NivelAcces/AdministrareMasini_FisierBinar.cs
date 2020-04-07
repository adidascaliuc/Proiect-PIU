using System;
using Modele;

namespace NivelAcces
{
    public class AdministrareMasini_FisierBinar : IStocareDataMasini
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string NumeFisiser)
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
