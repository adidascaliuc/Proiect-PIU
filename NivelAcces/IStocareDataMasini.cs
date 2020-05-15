using Modele;
using System.Collections.Generic;

namespace NivelAcces
{
    public interface IStocareDataMasini
    {
        void AddMasina(Masina m);       
        List<Masina> GetMasini();
        List<Masina> GetMasiniIndex(int index);
        void UpdateMasina(Masina m, int index);
    }
}
