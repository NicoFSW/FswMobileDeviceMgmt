using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Fuehrungskraft
    {
        private string _fkLevel;
        private string _kuerzel;
        private List<Telefon> _maTelefone;
        private List<Computer> _maComputer;
        private Person _maPerson;

        // constructor
        public Fuehrungskraft(string MaKuerzel, string FKLevel, Person MaPerson, List<Telefon> MaTelefone, List<Computer> MaComputer)
        {
            this._fkLevel = FKLevel;
            this._kuerzel = MaKuerzel;
            this._maPerson = MaPerson;
            this._maTelefone = MaTelefone;
            this._maComputer = MaComputer;


            /*if (Kuerzel.Length == 7 )
            {
                this.Kuerzel = Kuerzel;
            }
            else
            {
                Console.WriteLine("Wrong Kuerzel: " + Kuerzel);
            }*/
        }

        //overloaded constructor
        public Fuehrungskraft(string MaKuerzel, Person MaPerson)
        {
            this._kuerzel = MaKuerzel;
            this._maPerson = MaPerson;
        }


        public string GetName()
        {
            return _maPerson.GetPersonName();
        }

        //public string GetKuerzel()
        //{
        //    return _kuerzel;
        //}
        //public void SetKuerzel(string newKuerzel)
        //{
        //    if (newKuerzel.Length > 3)
        //    {
        //        _kuerzel = newKuerzel;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Das Kürzel ist zu kurz");
        //    }
        //}
        public string Kuerzel
        {
            //get;
            //private set;
            get
            {
                return _kuerzel;
            }
            set
            {
                if (value.Length > 3)
                {
                    _kuerzel = value;
                }
                else
                {
                    Console.WriteLine("Das Kürzel ist zu kurz");
                }
                //Kuerzel = "Welt";
                //Kuerzel = value;
            }
        }




        // overloading signature - "MASetPersonName(string)"
        public void MASetPersonName(string yourName)
        {
            try
            {
                _maPerson.SetPersonName(yourName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        // overloading signature - "MASetPersonName(string, string)"
        public void MaSetPersonName(string firstname, string secondname)
        {
            string fullname = firstname + " " + secondname;
            _maPerson.SetPersonName(fullname);
        }

        public void WriteAllgemeineInfo()
        {
            Console.WriteLine("Kuerzel: " + _kuerzel);
            Console.WriteLine("FK Level: " + _fkLevel);
            _maPerson.WritePersonInfo();
            foreach (Telefon TEL in _maTelefone)
            {
                TEL.WriteTelefonInfo();
            }

            foreach (Computer CP in _maComputer)
            {
                CP.WriteComputerInfo();
            }

        }

        public int GeraeteAnzahl()
        {
            int anzahlComputer = 0;

            if (_maComputer != null)
            {
                foreach (Computer cp in _maComputer)
                {
                    anzahlComputer += 1;

                }
            }


            int anzahlTelefon = 0;
            if (_maTelefone != null)
            {
                foreach (Telefon TEL in _maTelefone)
                {
                    anzahlTelefon += 1;
                }
            }

            return anzahlComputer + anzahlTelefon;
        }
    }
}
