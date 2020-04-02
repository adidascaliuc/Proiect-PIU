using System;
using System.Collections.Generic;
using System.Text;

namespace Targ_De_Masini
{
    [Flags]
    public enum Culoare
    {
        None = 0,
        Alb = 1,  // stiu ca sunt nonculori :))
        Negru = 2,  // stiu ca sunt nonculori :))
        Rosu = 4,
        Albastru = 8,
        Verde = 16,
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
