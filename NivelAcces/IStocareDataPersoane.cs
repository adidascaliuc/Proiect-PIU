using Modele;
using System.Collections.Generic;

namespace NivelAcces
{
    public interface IStocareDataPersoane
    {
        void AddPersoana(Persoana p);
        List<Persoana> GetPersoane(out int nrPersoane);       
    }
}
