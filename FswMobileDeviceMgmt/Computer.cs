using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Computer
    {
        private string ComputerArt;
        private string ComputerTyp;
        private string NoteBookNummer;


        //Constructor

        public Computer( string ComputerArt, string ComputerTyp, string CopmuterNummer)
        {
            this.ComputerTyp = ComputerTyp;
            this.NoteBookNummer = CopmuterNummer;
        }

        public void WriteComputerInfo()
        {
            Console.WriteLine( "\nComputerArt: " + ComputerArt +"\nComputerTyp: " + ComputerTyp + "\nComputerNummer: " + NoteBookNummer);

        }
    }
}
