using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Person
    {
        private string _name;
        private readonly string _alter;
        private readonly string _geschlecht;
        private Adresse _peAdresse;
        private const string DATENBANK_NAME = "Vita_Test";


        //Constructor
        public Person ( string Name, string Alter, Adresse PeAdresse )
        {
            this._name = Name;
            this._alter = Alter;
            this._peAdresse = PeAdresse;
        }

        public Person(string Name, string Alter, string Gechlecht,Adresse PeAdresse)
        {
            this._name = Name;
            this._alter = Alter;
            this._geschlecht = Gechlecht;
            this._peAdresse = PeAdresse;
        }

        public void WritePersonInfo()
        {
            //_geschlecht = "Weiblich";
            Console.WriteLine("Name: " + _name + "\nAlter: " + _alter + "\nGeschlecht: " +_geschlecht );

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
