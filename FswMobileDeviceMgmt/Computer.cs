using System;
using System.Collections.Generic;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Computer
    {
        private string ComputerTyp;
        private string ComputerMarke;
        private string ComputerNummer;


        //Constructor

        public Computer( string ComputerTyp, string ComputerMarke, string ComputerNummer)
        {
            this.ComputerTyp = ComputerTyp;
            this.ComputerMarke = ComputerMarke;
            this.ComputerNummer = ComputerNummer;
        }

        public void WriteComputerInfo()
        {
            Console.WriteLine( "\nComputerTyp: " + ComputerTyp +"\nComputerMarke: " + ComputerMarke + "\nComputerNummer: " + ComputerNummer);

        }
    }
}
