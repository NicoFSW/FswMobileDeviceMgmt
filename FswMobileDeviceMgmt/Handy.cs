using System;
using System.Collections.Generic;
using System.Text;
namespace FswMobileDeviceMgmt
{
    public class Handy
    {

        private string HandyTyp;
        private string HandyNummer;

        
        //Constructor

        public Handy(string HandyTyp, string HandyNummer)
        {
            this.HandyTyp = HandyTyp;
            this.HandyNummer = HandyNummer;

        }

        public void WriteHandyInfo()
        {
            Console.WriteLine("HandyTyp: " + HandyTyp + "\nHandynummer: " + HandyNummer);

        }
    }
}
