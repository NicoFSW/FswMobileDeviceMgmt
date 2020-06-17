using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FswMobileDeviceMgmt.Test
{
    public class ValuePassingTestsWithObjects
    {

        public class MyNumb
        {
            //field
            public int Wert;
        }

        [Fact]
        public void CSharpdoesPassbyValue()
        {
            //Arrange
            MyNumb x = new MyNumb();
            x.Wert = 3;
       

            //Act
            change(x);

            //Assert
            Assert.Equal(33, x.Wert);

        }

        public void change(MyNumb y)
        {
            y.Wert = 33;
        }


        [Fact]
        public void CSharpforcePassbyReference()
        {
            //Arrange
            MyNumb x = new MyNumb();
            x.Wert = 3;

            //Act
            Change2(ref x);

            //Assert
            Assert.Equal(33, x.Wert);

        }

        public void Change2(ref MyNumb y)
        {
            y = new MyNumb();
            y.Wert = 33;
        }


    }
}
