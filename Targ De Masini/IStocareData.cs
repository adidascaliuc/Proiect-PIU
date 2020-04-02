
namespace Targ_De_Masini
{
     public interface IStocareData
    {
        void AddMasina(Masina m);
        Masina[] GetMasini(out int nrMasini);
    }
}
