using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class MitarbeiterIn
    {
        private string Kuerzel;
        private List<Telefon> MaTelefone;
        private List<Computer> MaComputer;
        public Person MaPerson;

        // constructor
        public MitarbeiterIn( string MaKuerzel, Person MaPerson, List<Telefon> MaTelefone, List<Computer> MaComputer )
        {
            this.Kuerzel = MaKuerzel;
            this.MaPerson = MaPerson;
            this.MaTelefone = MaTelefone;
            this.MaComputer = MaComputer;


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
        public MitarbeiterIn(string MaKuerzel, Person MaPerson)
        {
            this.Kuerzel = MaKuerzel;
            this.MaPerson = MaPerson;
        }


        public string GetName()
        {
            return MaPerson.GetPersonName();
        }

        public string GetKuerzel()
        {
            return Kuerzel;
        }


        // overloading signature - "MASetPersonName(string)"
        public void MASetPersonName(string yourName)
        {
            try
            {
                MaPerson.SetPersonName(yourName);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // overloading signature - "MASetPersonName(string, string)"
        public void MaSetPersonName(string firstname, string secondname)
        {
            string fullname = firstname + " " +secondname;
            MaPerson.SetPersonName(fullname);
        }

        public void WriteAllgemeineInfo()
        {
            Console.WriteLine("Kuerzel: " + Kuerzel);
            MaPerson.WritePersonInfo();
            foreach (Telefon TEL in MaTelefone)
            {
                TEL.WriteTelefonInfo();
            }

            foreach (Computer CP in MaComputer)
            {
                CP.WriteComputerInfo();
            }

        }

        public int GeraeteAnzahl()
        {
            int anzahlComputer = 0;

            if (MaComputer != null)
            {
                foreach (Computer cp in MaComputer)
                {
                    anzahlComputer += 1;

                }
            }


            int anzahlTelefon = 0;
            if (MaTelefone != null)
            {
                foreach (Telefon TEL in MaTelefone)
                {
                    anzahlTelefon += 1;
                }
            }

            return anzahlComputer + anzahlTelefon;
        }
    }
}
