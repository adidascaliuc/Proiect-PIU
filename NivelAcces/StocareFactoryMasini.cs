using System.Configuration;
using NivelAcces;

namespace NivelAcces
{
    public static class StocareFactoryMasini
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisierMasini";
        public static IStocareDataMasini GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareMasini_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMasini_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
