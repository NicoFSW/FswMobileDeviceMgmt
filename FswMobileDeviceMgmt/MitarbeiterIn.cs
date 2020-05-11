using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class MitarbeiterIn
    {
        private string Name;
        private string Kuerzel = "Unbekannt";
        private string Durchwahl;
        private string TelefonVorwahl = "050 1234";
        private Handy MaHandy;
        private NoteBook MaNoteBook;

        // constructor
        public MitarbeiterIn(string Name, string Kuerzel, Handy MaHandy, NoteBook MaNoteBook, string Durchwahl, string TelefonVorwahl )
        {
            this.Name = Name;
            this.Durchwahl = Durchwahl;
            this.TelefonVorwahl = TelefonVorwahl;
            this.MaHandy = MaHandy;
            this.MaNoteBook = MaNoteBook;


            if (Kuerzel.Length == 7 )
            {
                this.Kuerzel = Kuerzel;
            }
            else
            {
                Console.WriteLine("Wrong Kuerzel: " + Kuerzel);
            }
        }

        public string GetName()
        {
            return Name;
        }

        public string GetKuerzel()
        {
            return Kuerzel;
        }


        public void WriteAllgemeineInfo()
        {

            Console.WriteLine("Kürzel: " + Kuerzel + "\nName: " + Name);
            MaHandy.WriteHandyInfo();
            MaNoteBook.WriteNoteBookInfo();
            Console.WriteLine("Vorwahl: " + TelefonVorwahl + "\nDurchwahl: " + Durchwahl ); 

        }
    }
}
