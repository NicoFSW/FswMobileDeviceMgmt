using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;

namespace FswMobileDeviceMgmt
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialisierung
            List<MitarbeiterIn> mitarbeiterInnen = InitialiseMitarbeiterInnnen();

            //Eingabe und Suche
            do
            {

                Console.WriteLine("\nPlease press 1 for entering the name\nPlease press 2 for entering the Kuerzel\nPlease press 3 for EXIT\n");

                int eingabe = ReadEingabe();

                if (eingabe == 1)
                {
                    Console.WriteLine("Please enter full Name");
                    string Name = Console.ReadLine();
                    foreach (MitarbeiterIn ma in mitarbeiterInnen)
                    {
                        //Console.WriteLine(ma.Name);
                        if (Name.Equals(ma.GetName(), StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("\n");
                            ma.WriteAllgemeineInfo();
                            break;
                        }
                    }
                }

                else if (eingabe == 2)
                {
                    Console.WriteLine("Please enter Kuerzel");
                    string Kuerzel1 = Console.ReadLine();
                    foreach (MitarbeiterIn ma in mitarbeiterInnen)
                    {
                        //Console.WriteLine(ma.Name);
                        if (Kuerzel1.Equals(ma.Kuerzel, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("\n");
                            ma.WriteAllgemeineInfo();
                        }
                    }
                }

                else if (eingabe.Equals(3))
                {
                    break;
                }
            } while (true);
        }


        private static int ReadEingabe()
        {
            int eingabe = 0;

            try
            {
                eingabe = Convert.ToInt32(Console.ReadLine());
                //throw new Exception("RIP");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please Type in a Number" + "\n" + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Please Type in a Number that is bigger than -2,147,483,648 and smaller than 2,147,483,647" + "\n" + e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("General Error 404");
            }
            finally
            {
                Console.WriteLine("FINALLY Block");
            }

            return eingabe;
        }
        
        
        private static List<MitarbeiterIn> InitialiseMitarbeiterInnnen()
        {
            List<MitarbeiterIn> mitarbeiterInnen = new List<MitarbeiterIn>();
            


            // add new MitarbeiterIn
            string MyMAKuerzel = "ifswnsc";
            string MyMAName = "nikole schumacher";
            string MyMAALter = "45";
            string MyMAStadt = "Wien";
            string MyMABezirk = "3";
            string MyMAStrasse = "Guglgasse 1";
            //string MyMAStrasse = new String("Guglgasse 1");

            Adresse MyMAAdresse = new Adresse
                (
                    MyMAStadt,
                    MyMABezirk,
                    MyMAStrasse
                );
            Person MyMAPersonName = new Person
            (
                 MyMAName,
                 MyMAALter,
                 MyMAAdresse
            );

            MitarbeiterIn MyMA = new MitarbeiterIn
                     (
                        MyMAKuerzel,
                        MyMAPersonName,


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

                    );

            mitarbeiterInnen.Add
                (
                    MyMA
                 );




            // add new MitarbeiterIn
            mitarbeiterInnen.Add
                (
                    new MitarbeiterIn
                    (
                        "ifswwha",
                        new Person
                            (
                                "Wolfgang Hans",
                                "54",
                                "Männlich",

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


            // add new MitarbeiterIn
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


            // add new MitarbeiterIn
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


            // add new Fuehrungskraft => POLYMORFISMUS
            mitarbeiterInnen.Add
            (
                    new Fuehrungskraft
                    (
                        "ifswtiv",
                        "FK1",
                        new Person
                        (
                            "Thomas der IV.",
                            "80",
                            new Adresse
                                (
                                    "Niederösterreich",
                                    "08",
                                    "Königsstrasse 4"
                                )
                        ),

                        new List<Telefon>
                            {
                                new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1123 444"
                                    ),
                                new Telefon
                                    (
                                        "MobilTelefon",
                                        "IphoneSE",
                                        "0650 1123 444"
                                    )
                            },

                        new List<Computer>
                            {
                                new Computer
                                    (
                                        "Notebook",
                                        "HP EliteBook",
                                        "204564"
                                    ),
                            }
                    )
                );




            try
            {
                mitarbeiterInnen.Add
                (
                        new OdwMitarbeiterIn
                        (
                            "ixxxbul",
                            new Person
                            (
                                "Birgitt Ulricke",
                                "53",
                                new Adresse
                                    (
                                        "Burgenland",
                                        "01",
                                        "Alteomastraße 3"
                                    )
                            ),

                            new List<Telefon>
                                {
                                new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1123 444"
                                    ),
                                },

                            new List<Computer>
                                {
                                new Computer
                                    (
                                        "Notebook",
                                        "Dell",
                                        "204221"
                                    ),
                                }
                        )
                    );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            mitarbeiterInnen.Add
            (
                    new OdwMitarbeiterIn
                    (
                        "iodwmhe",
                        new Person
                        (
                            "Manuela Heinricke",
                            "53",
                            new Adresse
                                (
                                    "Burgenland",
                                    "01",
                                    "Alteomastraße 3"
                                )
                        ),

                        new List<Telefon>
                            {
                                new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1123 444"
                                    ),
                            },

                        new List<Computer>
                            {
                                new Computer
                                    (
                                        "Notebook",
                                        "Dell",
                                        "204221"
                                    ),
                            }
                    )
                );




            // change MitarbeiterIn ifswplu
            MitarbeiterIn ifswplu = mitarbeiterInnen[2];
            ifswplu.MASetPersonName("");


            // add new MitarbeiterIn
            mitarbeiterInnen.Add
               (
                   new MitarbeiterIn
                   (
                       "ifswasp",
                       new Person
                       (
                           "Alexandra Peter",
                           "97",
                           null

                       )

                   )
               );


            // change MitarbeiterIn ifswplu
            MitarbeiterIn ifswasa = mitarbeiterInnen[3];
            ifswasa.Kuerzel = "ha";


            return mitarbeiterInnen;
        }
    }
}
