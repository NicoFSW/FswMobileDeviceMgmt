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

            mitarbeiterInnen.Add
                (
                    new MitarbeiterIn
                     (
                        "Nikole Schumacher", 
                        "ifswnsc", 
                        new Handy
                            (
                                "Iphone8",
                                "0660 1245 900"
                            ), 
                        new NoteBook
                            (
                                "HP EliteBook",
                                "203456"
                            ),
                        "11111",
                        "010 1234"
                    )
                 );

            mitarbeiterInnen.Add
                (
                    new MitarbeiterIn
                    (
                        "Wolfgang Hans",
                        "ifswwha",
                        new Handy
                            (
                                "Iphone8",
                                "06650 7831 435"
                            ), 
                        new NoteBook
                            (
                                "Dell",
                                "203566"
                            ),
                        "22222", 
                        "010 1234"
                    )
                );

           
            mitarbeiterInnen.Add
                (
                new MitarbeiterIn
                    (
                        "Peter Ludwig",
                        "ifswplu",
                        new Handy
                            (
                                "Iphone6",
                                "0660 1546 767"
                            ),
                        new NoteBook
                            (
                                "Dell",
                                "203778"
                            ),
                        "33333",
                        "010 1234"
                    )
                );

            
            mitarbeiterInnen.Add
                (
                    new MitarbeiterIn
                    (
                        "Alexandra Sabine",
                        "ifswasa",
                        new Handy
                            (
                            "IphoneSE",
                            "0650 1123 332"
                            ),
                        new NoteBook
                            (
                                "HP EliteBook",
                                "203991"
                            ),
                        "44444",
                        "010 1234"
                    )
                );


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
