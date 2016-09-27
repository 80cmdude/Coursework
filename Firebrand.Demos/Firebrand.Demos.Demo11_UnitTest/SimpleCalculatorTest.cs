using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Firebrand.Demos
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        [TestMethod]
        public void SubTest()
        {
            //Arrange 
            int actual, expected;
            expected = 25;
            
            SimpleCalculator calc = new SimpleCalculator();

            //Act
            actual = calc.Sub(35, 10);

            //Assert
            Assert.AreEqual(actual, expected, "Expected and actual values do not match");

        }
    }
}
