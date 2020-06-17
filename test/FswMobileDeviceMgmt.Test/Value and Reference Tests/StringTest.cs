using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FswMobileDeviceMgmt.Test
{
    public class StringTest
    {
        [Fact]
        static void StringPassByValue()
        {


            //arrange
            string x = "Nico";

            //act
            Change(x);

            //assert
            Assert.Equal("Nico", x);

        }

        static void Change(string y)
        {
            y = "Peter";
        }

        [Fact]
        static void StringPassByValue1()
        {


            //arrange
            string x = "Nico";

            //act
            x = MyToUpper(x);

            //assert
            Assert.Equal("NICO", x);

        }

        static string MyToUpper(string y)
        {
            y = y.ToUpper();
            return y;
        }

    }
}
