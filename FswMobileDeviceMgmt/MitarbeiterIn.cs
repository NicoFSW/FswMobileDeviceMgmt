using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class MitarbeiterIn
    {
        public string Handynummer,Name, Handy, Notebook, Kuerzel;        
        




        public void WriteAllgemeineInfo()
        {

            Console.WriteLine("Kürzel: " + Kuerzel + "\nName: " + Name + "\nHandy: " + Handy + "\nHandynummer: " + Handynummer + "\nNB: " + Notebook + "\n");

        }
    }
}
