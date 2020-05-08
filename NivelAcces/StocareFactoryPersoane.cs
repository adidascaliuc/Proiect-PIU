using System.Configuration;
using NivelAcces;

namespace NivelAcces
{
    public static class StocareFactoryPersoane
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisierPersoane";
        public static IStocareDataPersoane GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrarePersoane_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrarePersoane_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
