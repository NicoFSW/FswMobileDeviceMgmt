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

            mitarbeiterInnen.Add(new MitarbeiterIn("Nikole Schumacher", "ifswnsc", "Iphone8", "0660 1254 889", "11111", "203459", "010 1234"));
            mitarbeiterInnen.Add(new MitarbeiterIn("Wolfgang Hans", "ifswwha", "Iphone8", "0660 1234 556", "22222", "203456", "010 1234"));
            mitarbeiterInnen.Add(new MitarbeiterIn("Peter Ludwig", "ifswplu", "Iphone8", "0650 9898 334", "33333", "203457", "010 1234"));
            mitarbeiterInnen.Add(new MitarbeiterIn("Alexandra Sabine", "ifswasa", "IphoneSE", "0650 5656 900", "44444", "203458", "010 1234"));


            //eingabe
            string eingabe;
            
            
            do
            {

                Console.WriteLine("Please enter Name or \"exit\" \n");
                
                eingabe = Console.ReadLine();

                if (eingabe.Equals("Exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                else
                {
                    foreach (MitarbeiterIn ma in mitarbeiterInnen)
                    {
                        // Console.WriteLine(ma.Name);
                        if (eingabe.Equals(ma.GetName(), StringComparison.InvariantCultureIgnoreCase) || eingabe.Equals(ma.GetKuerzel(), StringComparison.InvariantCultureIgnoreCase)) 
                        {
                            ma.WriteAllgemeineInfo();
                        }
                    }
                }
            } while (true);
        }
    }
}
