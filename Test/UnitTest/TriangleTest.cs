using System;
using System.Reflection.Metadata.Ecma335;
using GeometryLib.Utils;
using GeometryLib.ConcreteFigures;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;

namespace Tests
{
    public class TriangleTest
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void InitTriangleTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;

            // Act.
            var triangle = new Triangle(a, b, c);

            // Assert.
            ClassicAssert.NotNull(triangle);
            ClassicAssert.Less(Math.Abs(triangle.ALength - a), Constants.CALCULATION_ACCURACY);
            ClassicAssert.Less(Math.Abs(triangle.BLength - b), Constants.CALCULATION_ACCURACY);
            ClassicAssert.Less(Math.Abs(triangle.CLength - c), Constants.CALCULATION_ACCURACY);
        }

        [Test]
        public void GetSquareTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var square = triangle?.GetArea();

            // Assert.
            ClassicAssert.NotNull(square);
            ClassicAssert.Less(Math.Abs(square.Value - result), Constants.CALCULATION_ACCURACY);
        }

        [Test]
        public void InitNotTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
        }

        [TestCase(3, 4, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5 + 2e-7, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5.000000001, ExpectedResult = true)]
        public bool NotRightTriangle(double a, double b, double c)
        {
            // Data.
            var triangle = new Triangle(a, b, c);

            // Act.
            var isRight = triangle.IsRectangular();

            // Assert. 
            return isRight;
        }
    }
}