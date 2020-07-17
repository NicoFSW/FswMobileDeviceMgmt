using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    class OdwMitarbeiterIn : MitarbeiterIn
    {
        //private string _iodwKuerzel;


        // constructor
        public OdwMitarbeiterIn( string Kuerzel, Person MaPerson, List<Telefon> MaTelefone, List<Computer> MaComputer)
            : base(Kuerzel, MaPerson, MaTelefone, MaComputer)
        {
            string prefix = Kuerzel.Substring(0, 4);
            if (prefix == "iodw")
            {
                //this._iodwKuerzel = iodwKuerzel;
            }
            else
            {
                throw new Exception($"Kürzel:{Kuerzel} ist nicht korrekt! Ein Kürzel von Odw muss mit \"iodw\" anfangen");

                //Console.WriteLine($"Kürzel:{iodwKuerzel} ist nicht korrekt! Ein Kürzel von Odw muss mit \"iodw\" anfangen");
            }
        }

        //overloaded constructor
        public OdwMitarbeiterIn(string Kuerzel, Person MaPerson) : base(Kuerzel, MaPerson)
        {
            string prefix = Kuerzel.Substring(0, 4);
            if (prefix == "iodw")
            {
                //this._iodwKuerzel = iodwKuerzel;
            }
            else
            {
                throw new Exception($"Kürzel:{Kuerzel} ist nicht korrekt! Ein Kürzel von Odw muss mit \"iodw\" anfangen");
            }
        }
    }
}
