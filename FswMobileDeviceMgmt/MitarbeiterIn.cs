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
        private Handy MaHandy;
        private NoteBook MaNoteBook;
        private Person MaPerson;

        // constructor
        public MitarbeiterIn( string MaKuerzel, Person MaPerson, Handy MaHandy, NoteBook MaNoteBook )
        {
            this.Kuerzel = MaKuerzel;
            this.MaPerson = MaPerson;
            this.MaHandy = MaHandy;
            this.MaNoteBook = MaNoteBook;


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
            MaHandy.WriteHandyInfo();
            MaNoteBook.WriteNoteBookInfo();

        }
    }
}
