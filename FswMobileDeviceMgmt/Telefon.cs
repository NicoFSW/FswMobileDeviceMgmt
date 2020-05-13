using System;
using System.Collections.Generic;
using System.Text;
namespace FswMobileDeviceMgmt
{
    public class Telefon
    {

        private string HandyMarke;
        private string HandyNummer;
        private string TelefonTyp;
        
        //Constructor

        public Telefon( string TelefonTyp, string HandyMarke, string HandyNummer)
        {
            this.TelefonTyp = TelefonTyp;
            this.HandyMarke = HandyMarke;
            this.HandyNummer = HandyNummer;

        }

        public void WriteTelefonInfo()
        {
            Console.WriteLine("\nTelefonTyp: " + TelefonTyp + "\nTelefonTyp: " + HandyMarke + "\nTelefonnummer: " + HandyNummer);

        }
    }
}
