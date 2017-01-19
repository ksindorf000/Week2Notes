using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day4_01._19._17;

namespace Day4_BikeTest
{
    [TestClass]
    public class RaceTest
    {
        [TestMethod]
        public void RaceCanIdentifyWinner()
        {
            Bike testBike = new Bike();
            int finishLine = 10;
            bool isRunning = true;

            testBike.location = 40;

            isRunning = Program.TickRace(testBike, finishLine, isRunning);
            Assert.AreEqual(false, isRunning); //(11:53AM)
        }

        [TestMethod]
        public void RaceWillAdvanceIfNoWinner()
        {
            Bike testBike = new Bike();
            int finishLine = 20;
            bool isRunning = true;
           
            isRunning = Program.TickRace(testBike, finishLine, isRunning);

            Assert.AreEqual(true, isRunning);
            Assert.AreEqual(testBike.location, 1);
        }
    }


    [TestClass]
    public class BikeTest
    {
        [TestMethod]
        public void ValuesInitializedCorrectly()
        {
            var sut = new Bike();
            Assert.AreEqual(0, sut.GetSpeed());
            Assert.AreEqual(1, sut.GetModifier());
            Assert.AreEqual(0, sut.location);
            Assert.AreEqual(12, sut.GetSpeedLimit());
        }

        [TestMethod]
        public void BikeCanBeCreatedWithArgs()
        {
            var sut = new Bike(.6, 20);
            Assert.AreEqual(.6, sut.GetModifier());
            Assert.AreEqual(20, sut.GetSpeedLimit());
        }

        [TestMethod]
        public void BikeCanAccelerate()
        {
            var sut = new Bike();
            sut.Accelerate();
            Assert.AreEqual(1, sut.GetSpeed());
        }

        [TestMethod]
        public void BikeCantBreakSpeedLimit()
        {
            var sut = new Bike();
            for (int i = 0; i < 15; i ++)
            {
                sut.Accelerate();
            }
            //Brittle test (9:58AM) breaks easily
            //      Assert.AreEqual(sut.speedLimit, sut.GetSpeed()); 
            //Better way...
            Assert.AreEqual(sut.GetSpeedLimit(), sut.GetSpeed()); 
        }

        [TestMethod]
        public void BikeMovesForward()
        {
            var sut = new Bike();
            sut.Accelerate();
            sut.Accelerate();
            sut.MoveForward();
            Assert.AreEqual(2, sut.location);
        }

        [TestMethod]
        public void BikeLocationFollowsSpeedLimit()
        {
            var sut = new Bike();
            for (int i = 0; i < 20; i++)
            {
                sut.Accelerate();
            }
            sut.MoveForward();
            Assert.AreEqual(sut.GetSpeedLimit(), sut.location);
        }
    }
}
