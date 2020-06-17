using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace FswMobileDeviceMgmt
{
    public class ValueReferenceTypTests
    {
        [Fact]
        public void ValueTypeTest()
        {
            //Arrange
            int numb1 = 10;
            int numb2 = 20;

            //Act
            numb1 = numb2;
            numb2 = 30;

            //Assert
            Assert.Equal(20, numb1);
            Assert.NotEqual(numb1, numb2);

        }



        private class MyNumb
        {
           public int Wert;

            /*public  MyNumb(int Wert)
            {
                this.Wert = Wert;
            }*/
        }

        [Fact]
        public void ReferenceTypeTest()
        {
            //Arrange
            MyNumb numb1 = new MyNumb();
            numb1.Wert = 10;

            MyNumb numb2 = new MyNumb();
            numb2.Wert = 20;

            //Act
            numb1 = numb2;
            numb2.Wert = 30;

            //Assert
            Assert.Equal(30, numb1.Wert);
            Assert.Same(numb1, numb2);
        }



    }
}
