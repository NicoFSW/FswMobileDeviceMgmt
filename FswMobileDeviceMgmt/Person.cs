using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Person
    {
        private string Name;
        private string Alter;
        private Adresse PeAdresse;

        //Constructor

        public Person ( string Name, string Alter, Adresse PeAdresse )
        {
            this.Name = Name;
            this.Alter = Alter;
            this.PeAdresse = PeAdresse;
        }

        public void WritePersonInfo()
        {
            Console.WriteLine("Name: " + Name + "\nAlter: " + Alter );

            if (PeAdresse != null)
            {
                PeAdresse.WriteAdresseInfo();
            }

            else 
            {
                Console.WriteLine("No Adress Added");
            }

        }

        public string GetPersonName()
        {
            return Name;
        }

    }
}
