
using FiguresTest;
using GeometryLib.ConcreteFigures;
using Tests;

try
{
    var circleTest = new CircleTest();
    var triangleTest = new TriangleTest();
    circleTest.GetSquareTest();
    circleTest.ZeroRadiusTest();
    circleTest.NegativeRadiusTest();

    triangleTest.InitNotTriangleTest();
    triangleTest.GetSquareTest();
    triangleTest.InitTriangleWithErrorTest(2, 4, 3);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }
