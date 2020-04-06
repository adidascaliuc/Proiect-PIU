using System;
using Modele;

namespace NivelAcces
{
    public class AdministrarePersoane_FisierBinar : IStocareDataPersoane
    {
        string NumeFisier { get; set; }
        public AdministrarePersoane_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddPersoana(Persoana p)
        {
            throw new Exception("Optiunea AddPersoane nu este implementata");
        }

        public Persoana[] GetPersoane(out int nrPersoane)
        {
            throw new Exception("Optiunea GetPersoane nu este implementata");
        }
    }
}
