using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Adresse
    {

        private string BundesLand;
        private string Bezirk;
        private string Strasse;


        //constructor

        public Adresse(string x, string y, string Strasse)
        {
            this.BundesLand = x;
            this.Bezirk = y;
            this.Strasse = Strasse;
        }

        public void WriteAdresseInfo()
        {
            Console.WriteLine( "\nBundesLand: " + BundesLand + "\nBezirk: " + Bezirk + "\nStrasse: " + Strasse );
        }




    }
}
