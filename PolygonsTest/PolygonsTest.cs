using System;
using System.Collections.Generic;
using NUnit.Framework;
using Polygons;

namespace PolygonsTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCircleConstructorInvalidData()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
        
        [Test]
        public void TestCircleConstructorValidData()
        {
            var circle = new Circle(1.12);
            Assert.AreEqual(1.12, circle.R);
        }
        
        [Test]
        public void TestCircleAreaCalculation()
        {
            var circle = new Circle(2);
            Assert.AreEqual(Math.Pow(2, 2) * Math.PI, circle.GetArea());
            Assert.AreEqual(12.566370614359172, circle.GetArea());
        }
        
        [Test]
        public void TestTriangleConstructorInvalidData()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -2));
            Assert.Throws<ArgumentException>(() => new Triangle(2.5, 1, 2));
        }
        
        [Test]
        public void TestTriangleConstructorValidData()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.AreEqual(3, triangle.A);
            Assert.AreEqual(4, triangle.B);
            Assert.AreEqual(6, triangle.C);
        }
        
        [Test]
        public void TestTriangleIsRightPropertyValid()
        {
            var triangles = new List<Triangle>
            {
                new Triangle(3, 4, 5),
                new Triangle(12, 5, 13),
                new Triangle(17, 15, 8)
            };

            foreach (var triangle in triangles)
            {
                Assert.AreEqual(true, triangle.IsRight);
            }
        }
        
        [Test]
        public void TestTriangleIsRightPropertyInvalid()
        {
            var triangles = new List<Triangle>
            {
                new Triangle(7, 8, 5),
                new Triangle(4, 3, 6),
                new Triangle(2, 3, 4)
            };

            foreach (var triangle in triangles)
            {
                Assert.AreEqual(false, triangle.IsRight);
            }
        }

        [Test]
        public void TestTriangleAreaCalculation()
        {
            var triangle = new Triangle(6, 7, 10);
            Assert.AreEqual(20.662465970933866, triangle.GetArea());
        }
    }
}