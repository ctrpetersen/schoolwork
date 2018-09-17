using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;


namespace MathLibraryUnitTest
{
    [TestClass]
    public class MathLibraryTest
    {
        [TestMethod]
        public void AddPositiveInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Add(2, 5) == 7);
        }

        [TestMethod]
        public void AddPositiveDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Add(2.5, 2.5) == 5);
        }

        [TestMethod]
        public void AddNegativeInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Add(-2, -5) == -7);
        }

        [TestMethod]
        public void AddNegativeDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Add(-2.5, -2.5) == -5);
        }

        [TestMethod]
        public void SubtractPositiveInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Subtract(5, 2) == 3);
        }

        [TestMethod]
        public void SubtractPositiveDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Subtract(2.5, 2.5) == 0);
        }

        [TestMethod]
        public void SubtractNegativeInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Subtract(-2, -10) == 8);
        }

        [TestMethod]
        public void SubtractNegativeDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Subtract(-2.5, -2.5) == 0);
        }

        [TestMethod]
        public void MultiplyPositiveInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Multiply(2, 5) == 10);
        }

        [TestMethod]
        public void MultiplyPositiveDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Multiply(2.5, 2.5) == 6.25);
        }

        [TestMethod]
        public void MultiplyNegativeInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Multiply(-2, -5) == 10);
        }

        [TestMethod]
        public void MultiplyNegativeDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Multiply(-2.5, -2.5) == 6.25);
        }

        [TestMethod]
        public void DividePositiveInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Divide(10, 2) == 5);
        }

        [TestMethod]
        public void DividePositiveDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Divide(2.5, 2.5) == 1);
        }

        [TestMethod]
        public void DivideNegativeInts()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Divide(-10, -2) == 5);
        }

        [TestMethod]
        public void DivideNegativeDoubles()
        {
            Assert.IsTrue(MathLibrary.MathLibrary.Divide(-2.5, -2.5) == 1);
        }
    }
}
