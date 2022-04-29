using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadanie3;

namespace TestProject1
{
    [TestClass]
    public class AirportTests
    {
        [TestMethod]
        public void FailTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { var airport = new Airport(0); });
        }

        [TestMethod]
        public void SuccesTest()
        {
            var airport = new Airport(3);
            Assert.IsNotNull(airport);
        }

        [TestMethod]
        public void CapacityDepleted()
        {
            var airport = new Airport(1);
            Plane plane1 = airport.AcquirePlane();

            Assert.ThrowsException<ArgumentException>(
                () =>
                {
                    Plane plane2 = airport.AcquirePlane();
                });
        }

        [TestMethod]
        public void ReusedObject()
        {
            var airport = new Airport(1);
            Plane plane1 = airport.AcquirePlane();

            airport.RelasePlane(plane1);

            Plane plane2 = airport.AcquirePlane();

            Assert.AreEqual(plane2, plane1);
        }

        [TestMethod]
        public void RelisedInvalidPlane()
        {
            var airport = new Airport(1);
            Plane plane1 = new Plane();

            Assert.ThrowsException<ArgumentException>(
                () =>
                {
                    airport.RelasePlane(plane1);
                });           
        }
    }
}
