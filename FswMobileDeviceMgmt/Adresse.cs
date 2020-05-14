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

        public Adresse(string Bundesland, string Bezirk, string Strasse)
        {
            this.BundesLand = Bundesland;
            this.Bezirk = Bezirk;
            this.Strasse = Strasse;
        }

        public void WriteAdresseInfo()
        {
            Console.WriteLine( "\nBundesLand: " + BundesLand + "\nBezirk: " + Bezirk + "\nStrasse: " + Strasse );
        }




    }
}
