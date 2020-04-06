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
    }

    [Flags]
    public enum Optiuni
    {
        None = 0,
        AerConditionat = 1,
        OptiuniVolan = 2,
        ScaunePiele = 4,
        ModBengos = 8,
        Navigatie = 16,
        CutieAutomata = 32,
    }
    
    

    public enum TipPersoana
    {
        None  = 0,
        Cumparator = 1,
        Vanzator = 2,
    }
}
