using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class MitarbeiterIn
    {
        private string Name;
        private string Kuerzel = "Unbekannt";
        private string Notebook;
        private string Handy;
        private string Handynummer;
        private string Durchwahl;
        private string TelefonVorwahl = "050 1234";
        
        // constructor
        public MitarbeiterIn(string myName, string myKuerzel, string myHandy, string myHandynummer, string myDurchwahl, string myNotebook,string myTelefonVorwahl )
        {
            Name = myName;
            Handy = myHandy;
            Handynummer = myHandynummer;
            Durchwahl = myDurchwahl;
            Notebook = myNotebook;
            TelefonVorwahl = myTelefonVorwahl;

            if (myKuerzel.Length == 7 )
            {
                Kuerzel = myKuerzel;
            }
            else
            {
                Console.WriteLine("Wrong Kuerzel: " + myKuerzel);
            }
        }

        public string GetName()
        {
            return Name;
        }

        public string GetKuerzel()
        {
            return Kuerzel;
        }


        public void WriteAllgemeineInfo()
        {

            Console.WriteLine("Kürzel: " + Kuerzel + "\nName: " + Name + "\nHandy: " + Handy + "\nHandynummer: " + Handynummer 
                + "\nVorwahl: " +TelefonVorwahl  + "\nDurchwahl: " +Durchwahl + "\nNB: " + Notebook + "\n");

        }
    }
}
