
namespace Targ_De_Masini
{
     public interface IStocareData
    {
        void AddMasina(Masina m);
        //void AddPersoana(Persoana p);
        Masina[] GetMasini(out int nrMasini);
        //Persoana[] GetPersoana(out int nrPersoane);
    }
}
