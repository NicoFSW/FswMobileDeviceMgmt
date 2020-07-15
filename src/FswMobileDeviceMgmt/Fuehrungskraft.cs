using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FswMobileDeviceMgmt
{
    public class Fuehrungskraft : MitarbeiterIn
    {
        private string _fkLevel;


        // constructor
        public Fuehrungskraft(string MaKuerzel, string FKLevel, Person MaPerson, List<Telefon> MaTelefone, List<Computer> MaComputer) 
            : base(MaKuerzel, MaPerson, MaTelefone, MaComputer)
        {
            this._fkLevel = FKLevel;
            //this._kuerzel = MaKuerzel;
            //this._maPerson = MaPerson;
            //this._maTelefone = MaTelefone;
            //this._maComputer = MaComputer;
        }

        //overloaded constructor
        public Fuehrungskraft(string MaKuerzel, Person MaPerson) : base(MaKuerzel, MaPerson)
        {
            this._kuerzel = MaKuerzel;
            this._maPerson = MaPerson;
        }


        public override void WriteAllgemeineInfo()
        {
            Console.WriteLine("FK Level: " + _fkLevel);

            base.WriteAllgemeineInfo();

            //Console.WriteLine("Kuerzel: " + _kuerzel);
            //_maPerson.WritePersonInfo();
            //foreach (Telefon TEL in _maTelefone)
            //{
            //    TEL.WriteTelefonInfo();
            //}

            //foreach (Computer CP in _maComputer)
            //{
            //    CP.WriteComputerInfo();
            //}
        }

    }
}
