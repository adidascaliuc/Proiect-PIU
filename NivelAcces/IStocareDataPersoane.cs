using Modele;

namespace NivelAcces
{
    public interface IStocareDataPersoane
    {
        void AddPersoana(Persoana p);
        Persoana[] GetPersoane(out int nrPersoane);       
    }
}
