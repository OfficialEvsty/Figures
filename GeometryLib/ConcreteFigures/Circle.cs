

using GeometryLib.Utils;
using GeometryLib.Exceptions;

namespace GeometryLib.ConcreteFigures
{
    /// <summary>
    /// Конкретная фигура Circle
    /// </summary>
    public class Circle : Figure
    {
        private double d_radius;
        public double Radius { get { return d_radius; } }
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentNegativeException("Радиус круга не может быть отрицательным.");
            else if (radius == 0)
                throw new Exceptions.ArgumentNullException("Радиус круга не может быть равен нулю.");
            else
                d_radius = radius;

        }
        public override double GetArea()
        {
            return Constants.PI * Math.Pow(d_radius, 2);
        }
    }
}
