using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetCircumfrance_CircrumfaceOfCircle()
        {
            Circle newCircle = new Circle(5);
            double result = newCircle.GetCircumfrance();
            double expected = 31.4;
            Console.WriteLine(result.GetType());
            Console.WriteLine(expected.GetType());
            Assert.AreEqual(expected, result);
        }
        // [TestMethod]
        // public void Circle 
    }
}