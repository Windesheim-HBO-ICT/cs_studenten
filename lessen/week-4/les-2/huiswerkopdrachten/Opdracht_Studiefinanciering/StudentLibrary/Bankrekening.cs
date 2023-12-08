using System.Globalization;

namespace StudentLibrary
{
    public class Bankrekening
    {
        public string Rekeningnummer { get; set; }

        public decimal Saldo { get; set; }

        public string SaldoInfo
        {
            get
            {
                return string.Format("{0:C}", Saldo);
            }
        }

        #region Mocht je tijd over hebben.. =>

        /// <summary>
        /// Expression bodied members<br/>
        /// Is SaldoInfo_Expression een public field of een property?
        /// </summary>
        public string SaldoInfo_Expression => string.Format("{0:C}", Saldo);

        /// <summary>
        /// Globalisatie is het aanpassen van een applicatie zodat het meer meerdere talen en regio's overweg kan<br/>
        /// Localisatie is het aanpassen van een applicatie voor een specifieke taal en regio 
        /// </summary>
        public string SaldoInfo_Expression_CultureInfo => string.Format(new CultureInfo("hu-HU"), "{0:C}", Saldo);

        #endregion
    }
}