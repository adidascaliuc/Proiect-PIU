using Modele;

namespace NivelAcces
{
    public interface IStocareDataMasini
    {
        void AddMasina(Masina m);       
        Masina[] GetMasini(out int nrMasini);
    }
}
