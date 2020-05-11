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
                        "ifswnsc",
                        new Person
                            (
                            "Nikole Schumacher", 
                            "45",
                            "Wien",
                            "3",
                            "Guglgasse 23/3/60"
                            ), 
                        new Handy
                            (
                                "Iphone8",
                                "0660 1245 900"
                            ), 
                        new NoteBook
                            (
                                "HP EliteBook",
                                "203456"
                            )
                    )
                 );

            mitarbeiterInnen.Add
                (
                    new MitarbeiterIn
                    (
                        "ifswwha",
                        new Person
                            (
                            "Wolfgang Hans",
                            "54",
                            "Wien",
                            "5",
                            "Liebespaar 2/1/13"
                            ),
                        new Handy
                            (
                                "Iphone8",
                                "06650 7831 435"
                            ), 
                        new NoteBook
                            (
                                "Dell",
                                "203566"
                            )
                    )
                );


            mitarbeiterInnen.Add
                (
                new MitarbeiterIn
                    (
                        "ifswplu",
                        new Person
                        (
                        "Peter Ludwig",
                        "36",
                        "NiederÖsterreich",
                        "8",
                        "Hofburg 3"
                        ),
                        new Handy
                            (
                                "Iphone6",
                                "0660 1546 767"
                            ),
                        new NoteBook
                            (
                                "Dell",
                                "203778"
                            )
                    )
                );


            mitarbeiterInnen.Add
                (
                    new MitarbeiterIn
                    (
                        "ifswasa",
                        new Person
                        (
                        "Alexandra Sabine",
                        "27",
                        "Burgenland",
                        "1",
                        "Neusiedlersee 67"
                        ),
                        new Handy
                            (
                            "IphoneSE",
                            "0650 1123 332"
                            ),
                        new NoteBook
                            (
                                "HP EliteBook",
                                "203991"
                            )
                    )
                );


            //eingabe
            string eingabe;
            
            
            do
            {

                Console.WriteLine("\nPlease enter Name or \"exit\" \n");
                
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
