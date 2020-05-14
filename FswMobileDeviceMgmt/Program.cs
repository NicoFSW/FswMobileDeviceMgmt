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
                            
                                new Adresse
                                    (
                                        "Wien",
                                        "3",
                                        "Guglgasse 1"
                                    )
                                    
                            ),

                        new List<Telefon>
                            {

                                new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1245 900"
                                    ),
                                new Telefon
                                    (
                                        "MobilTelefon",
                                        "Iphone8",
                                        "0660 1245 900"
                                    ),
                            },

                            new List<Computer> 
                                {
                                    new Computer
                                        (
                                            "Notebook",
                                            "HP EliteBook",
                                            "203456"
                                        ),
                                    new Computer
                                        (
                                            "Notebook",
                                            "HP UltraBook",
                                            "203463"
                                        ),
                                }

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

                                 new Adresse
                                    (
                                        "Wien",
                                        "5",
                                        "Liebespaar 2/1/13"
                                    )
                            ),
                        new List<Telefon>
                        {
                            new Telefon
                                (
                                    "FestNetzTelefon",
                                    "/",
                                    "02 1231 497"
                                ),
                            new Telefon
                                (
                                    "MobilTelefon",
                                    "Iphone8",
                                    "0660 1467 823"
                                ),
                            new Telefon
                                (
                                    "MobilTelefon",
                                    "IphoneSE",
                                    "0650 7542 556"
                                )
                        },
                        new List<Computer>
                            {
                            }
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
                            
                            new Adresse
                                (
                                    "NiederÖsterreich",
                                    "8",
                                    "Hofburg 3"
                                )
                        ),
                        new List<Telefon>
                            {
                                new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1546 767"
                                    ),
                                new Telefon
                                    (
                                        "MobilTelefon",
                                        "Iphone6",
                                        "0660 1546 767"
                                    ),
                            },

                        new List<Computer>
                            {
                                new Computer
                                    (
                                        "Notebook",
                                        "Dell",
                                        "204476"
                                    )
                            }
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
                            null

                        /*new Adresse
                            (
                                "",
                                "",
                                ""
                            )*/
                        ),

                        new List<Telefon>
                            {
                                new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1123 332"
                                    ),
                                new Telefon
                                    (
                                        "MobilTelefon",
                                        "IphoneSE",
                                        "0650 1123 332"
                                    )
                            },

                        new List<Computer>
                            {
                                new Computer
                                    (
                                        "Notebook",
                                        "HP EliteBook",
                                        "204563"
                                    ),
                                new Computer
                                    (
                                        "Notebook",
                                        "HP LightBook",
                                        "205739"
                                    )
                            }
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
                            Console.WriteLine("\n");
                            ma.WriteAllgemeineInfo();
                        }
                    }
                }
            } while (true);
        }
    }
}
