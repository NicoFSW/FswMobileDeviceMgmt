using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Person
    {
        private string _name;
        private string _alter;
        private Adresse _peAdresse;

        //Constructor

        public Person ( string Name, string Alter, Adresse PeAdresse )
        {
            this._name = Name;
            this._alter = Alter;
            this._peAdresse = PeAdresse;
        }

        public void WritePersonInfo()
        {
            Console.WriteLine("Name: " + _name + "\nAlter: " + _alter );

            if (_peAdresse != null)
            {
                _peAdresse.WriteAdresseInfo();
            }

            else 
            {
                Console.WriteLine("\nNo Adress Added" + "\n");
            }

        }

        public string GetPersonName()
        {
            return _name;
        }

        public void SetPersonName(string yourName)
        {
            if (yourName.Length > 3)
            {
                _name = yourName; 
            }
            else
            {
                throw new Exception("new name is too short");
            }
        }

    }
}
