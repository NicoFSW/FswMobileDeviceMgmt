using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace FswMobileDeviceMgmt
{
    class Program
    {
        static void Main(string[] args)
        {

            List<MitarbeiterIn> mitarbeiterInnen = new List<MitarbeiterIn>();


            MitarbeiterIn Nikole = new MitarbeiterIn();

            Nikole.Kuerzel = "ifswnsc";
            Nikole.Name = "Nikole Schumacher";
            Nikole.Handy = "Iphone8";
            Nikole.Handynummer = "0660 1254 889";
            Nikole.Notebook = "203459";



            MitarbeiterIn wolfgang = new MitarbeiterIn();
            
            wolfgang.Kuerzel = "ifswwha";
            wolfgang.Name = "Wolfgang Hans";
            wolfgang.Handy = "Iphone8";
            wolfgang.Handynummer = "0660 1234 556";
            wolfgang.Notebook = "203456";

            MitarbeiterIn peter = new MitarbeiterIn();

            peter.Kuerzel = "ifswplu";
            peter.Name = "Peter Ludwig";
            peter.Handy = "Iphone8";
            peter.Handynummer = "0650 9898 334";
            peter.Notebook = "203457";

            MitarbeiterIn alexandra = new MitarbeiterIn();

            alexandra.Kuerzel = "ifswasa";
            alexandra.Name = "Alexandra Sabine";
            alexandra.Handy = "IphoneSE";
            alexandra.Handynummer = "0650 5656 900";
            alexandra.Notebook = "203458";


            //eingabe
            string eingabe;
            
            
            do
            {

                Console.WriteLine("Please enter Name or \"exit\" \n");
                
                eingabe = Console.ReadLine();


                if (eingabe.Equals("Wolfgang", StringComparison.InvariantCultureIgnoreCase))
                {
                    wolfgang.WriteAllgemeineInfo();
                }


                else if (eingabe.Equals("Nikole", StringComparison.InvariantCultureIgnoreCase))
                {
                    Nikole.WriteAllgemeineInfo();
                }

                else if (eingabe.Equals("Peter", StringComparison.InvariantCultureIgnoreCase))
                {
                    peter.WriteAllgemeineInfo();
                }


                else if (eingabe.Equals("alexandra", StringComparison.InvariantCultureIgnoreCase))
                {
                    alexandra.WriteAllgemeineInfo();
                }

                else if (eingabe.Equals("Exit", StringComparison.InvariantCultureIgnoreCase))
                {
                   break;
                }                

                else
                {
                    Console.WriteLine("\nFalse Name\n");
                                       
                }

            } while (true);
        }
    }
}
