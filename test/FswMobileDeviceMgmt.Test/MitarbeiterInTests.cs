using System;
using System.Collections.Generic;
using Xunit;

namespace FswMobileDeviceMgmt.Test
{
    public class MitarbeiterInTests
    {
        [Fact]
        public void GetKuerzelreturnsKuerzel()
        {
            //Arange

            MitarbeiterIn TestMitarbeiter = new MitarbeiterIn
                (

                 "ifswtst",
                 null,

                 null,

                 null

                );
            
            
            //Act

            string ActualErgebnis = TestMitarbeiter.GetKuerzel();


            //Assert

            string ExpectedErgebnis = "ifswtst";

            Assert.Equal( ExpectedErgebnis , ActualErgebnis);

        }
        
        [Fact]
        public void GeraeteAnzahlOhneTelOhneCompReturns0()
        {

            //Arrange
            MitarbeiterIn TestMitarbeiter = new MitarbeiterIn
                (
                 "ifswtst",
                 null,
                 null,
                 null
                );


            //Act

            int ActualErgebnis = TestMitarbeiter.GeraeteAnzahl();



            //Assert

            int ExpectedErgebnis = 0;

            Assert.Equal(ExpectedErgebnis, ActualErgebnis);
        }


        [Fact]
        public void GeraeteAnzahl1Tel2CompReturns3()
        {

            //Arrange
            MitarbeiterIn TestMitarbeiter = new MitarbeiterIn
                (
                 "ifswtst",
                 null,
                 

                 new List<Telefon>
                            {

                            new Telefon
                                    (
                                        "FestNetzTelefon",
                                        "/",
                                        "02 1245 900"
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
                                "203434"
                            ),

                    }
                  );


            //Act

            int ActualErgebnis = TestMitarbeiter.GeraeteAnzahl();



            //Assert

            int ExpectedErgebnis = 3;

            Assert.Equal(ExpectedErgebnis, ActualErgebnis);
        }


        [Fact]
        public void GetNamereturnsName()
        {
            //Arrange
            MitarbeiterIn TestMitarbeiter = new MitarbeiterIn
            (
                "ifswtst",
                new Person
                    (
                        "Nikole Schumacher",
                        "45",
                        null
                    ),
                null,
                null



            );


            //Act
            string ActualErgebnis = TestMitarbeiter.GetName();


            //Assert

            string ExpectedErgebnis = "Nikole Schumacher";
            Assert.Equal(ExpectedErgebnis, ActualErgebnis);
        }
    }


    public class TelefonTests
    {



    }
}
