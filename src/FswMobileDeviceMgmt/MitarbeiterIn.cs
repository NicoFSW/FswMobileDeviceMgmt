using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class MitarbeiterIn
    {
        private string Kuerzel;
        private List<Telefon> MaTelefone;
        private List<Computer> MaComputer;
        private Person MaPerson;

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

        public string GetName()
        {
            return MaPerson.GetPersonName();
        }

        public string GetKuerzel()
        {
            return Kuerzel;
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
