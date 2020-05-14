using System;
using System.Collections.Generic;
using System.Text;
namespace FswMobileDeviceMgmt
{
    public class Telefon
    {

        private string TelefonMarke;
        private string TelefonNummer;
        private string TelefonTyp;
        
        //Constructor

        public Telefon( string TelefonTyp, string TelefonMarke, string TelefonNummer)
        {
            this.TelefonTyp = TelefonTyp;
            this.TelefonMarke = TelefonMarke;
            this.TelefonNummer = TelefonNummer;

        }

        public void WriteTelefonInfo()
        {
            Console.WriteLine("\nTelefonTyp: " + TelefonTyp + "\nTelefonMarke: " + TelefonMarke + "\nTelefonnummer: " + TelefonNummer);

        }
    }
}
