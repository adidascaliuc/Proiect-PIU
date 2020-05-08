using Modele;
using System.Collections.Generic;

namespace NivelAcces
{
    public interface IStocareDataMasini
    {
        void AddMasina(Masina m);       
        List<Masina> GetMasini(out int nrMasini);
        List<Masina> GetMasiniIndex(int index);
        void UpdateMasina(Masina m, int index);
    }
}
