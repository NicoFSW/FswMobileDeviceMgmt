using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FswMobileDeviceMgmt.Test
{
    public class ValuePassingTests
    {

        [Fact]
        public void CSharpdoesPassbyValue()
        {
            //Arrange
            int x = 3;

            //Act
            change(x);

            //Assert
            Assert.Equal(3, x);

        }

        public void change(int y)
        {
            y = 33;
        }


        [Fact]
        public void CSharpforcePassbyReference()
        {
            //Arrange
            int x = 3;

            //Act
            Change2(ref x);

            //Assert
            Assert.Equal(33, x);

        }

        public void Change2(ref int y)
        {
            y = 33;
        }


    }
}
