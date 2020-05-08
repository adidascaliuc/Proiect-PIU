using System;
using System.Collections.Generic;
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
            throw new Exception("Optiunea AddMasina nu este implementata");
        }

        public List<Masina> GetMasini(out int nrMasini)
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }
        public List<Masina> GetMasiniIndex(int index)
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }
        public void UpdateMasina(Masina m, int index)
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }
    }
}
