using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day4_01._19._17;

namespace Day4.Bike
{
    [TestClass]
    public class BikeFactoryTest
    {
        //(10:54AM)

        [TestMethod]
        public void BikeFactoryCanCreateXBikes()
        {
            var listOfBikes = BikeFactory.CreateXBikes(5);
            Assert.AreEqual(5, listOfBikes.Count);
        }
    }
}
