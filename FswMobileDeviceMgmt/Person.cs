using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Person
    {
        private string Name;
        private string Alter;
        private string Adresse;
        private string Bezirk;
        private string BundesLand;


        //Constructor

        public Person ( string Name, string Alter, string BundesLand, string Bezirk,string Adresse)
        {
            this.Name = Name;
            this.Alter = Alter;
            this.Adresse = Adresse;
            this.BundesLand = BundesLand;
            this.Bezirk = Bezirk;

        }

        public void WritePersonInfo()
        {
            Console.WriteLine( "Name: " + Name + "\nAlter: " + Alter 
                               + "\nStadt: " + BundesLand + "\nBezirk: " + Bezirk+ "\nAdresse: " + Adresse );

        }

        public string GetPersonName()
        {
            return Name;
        }

    }
}
