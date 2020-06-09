//Nume: Dascaliuc Adi       Grupa: 3123b
using Modele;
using System.Collections.Generic;

namespace NivelAcces
{
    public interface IStocareDataMasini
    {
        void AddMasina(Masina m);       
        List<Masina> GetMasini();
        List<Masina> GetMasiniIndex(int index);
        void UpdateMasina(Masina m);
        List<Masina> GetMasiniUser(string username);
    }
}
