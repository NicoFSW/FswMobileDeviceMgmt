using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class NoteBook
    {
        private string NoteBookTyp;
        private string NoteBookNummer;


        //Constructor

        public NoteBook(string NoteBookTyp, string NoteBookNummer)
        {
            this.NoteBookTyp = NoteBookTyp;
            this.NoteBookNummer = NoteBookNummer;

        }

        public void WriteNoteBookInfo()
        {
            Console.WriteLine("NoteBookTyp: " + NoteBookTyp + "\nNoteBookNummer: " + NoteBookNummer);

        }
    }
}
