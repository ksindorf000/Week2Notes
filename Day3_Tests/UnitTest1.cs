using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day3_01._18;

namespace Day3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareComputesCorrectly()
        {
            //"sut" is a convention that stands for "system under test"
            //      The variable named "sut" is the variable that matters most,
            //      the one you are _really_ testing.
            var sut = new Square(5, 3); 

            //Make sure that the parameters are in the correct order
            Assert.AreEqual(5, sut.height);
            Assert.AreEqual(3, sut.width);

            //Make sure that the math is right
            Assert.AreEqual(15, sut.CalcArea());
        }

        [TestMethod]
        public void CircleComputesCorrectly()
        {
            var sut = new Circle(5);
            Assert.AreEqual(5, sut.radius);
            Assert.AreEqual(10, sut.diameter);

            //AreEqual(double expected, double actual, double delta)
            //      double delta = the range of margin for error
            Assert.AreEqual(78.54, sut.CalcArea(), .01);             
        }

        [TestMethod]
        public void ShapeComputesCorrectly()
        {
            var sut = new Shape();
            Assert.AreEqual(0, sut.height);
            Assert.AreEqual(0, sut.height);
            Assert.AreEqual(0, sut.height);
            Assert.AreEqual(0, sut.height);
        }
    }
}
