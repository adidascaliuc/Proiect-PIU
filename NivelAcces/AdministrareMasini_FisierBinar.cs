//Nume: Dascaliuc Adi       Grupa: 3123b
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

        public List<Masina> GetMasini()
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }
        public List<Masina> GetMasiniIndex(int index)
        {
            throw new Exception("Optiunea GetMasiniIndex nu este implementata");
        }
        public void UpdateMasina(Masina m)
        {
            throw new Exception("Optiunea UpdateMasina nu este implementata");
        }

        public List<Masina> GetMasiniUser(string username)
        {
            throw new Exception("Optiunea GetMasiniUser nu este implementata");
        }
    }
}
