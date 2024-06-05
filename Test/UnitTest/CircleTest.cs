using GeometryLib.ConcreteFigures;
using GeometryLib.Exceptions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace FiguresTest
{
    class CircleTest
    {
        double eps = GeometryLib.Utils.Constants.CALCULATION_ACCURACY;
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<GeometryLib.Exceptions.ArgumentNullException>(() => new Circle(0d));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentNegativeException>(() => new Circle(-1d));
        }

        [Test]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2d);

            var square = circle.GetArea();

            ClassicAssert.Less(Math.Abs(square - expectedValue), eps);
        }
    }
}
