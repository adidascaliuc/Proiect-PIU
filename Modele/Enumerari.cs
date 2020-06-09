//Nume: Dascaliuc Adi       Grupa: 3123b
using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public enum Culoare
    {
        None = 0,
        Alb = 1,  // stiu ca sunt nonculori :))
        Negru = 2,  // stiu ca sunt nonculori :))
        Rosu = 3,
        Albastru = 4,
        Verde = 5,
        Argintiu = 6,
    }

    [Flags]
    public enum Optiuni
    {
        None = 0,
        AerConditionat = 1,
        OptiuniVolan = 2,
        ScaunePiele = 4,
        GeamuriElectrice = 8,
        Navigatie = 16,
        CutieAutomata = 32,
    }
    
    

    public enum ModAfisare
    {
        FORMAAFISARE = 1,
        FORMAMYCARS = 2,
    }
}
