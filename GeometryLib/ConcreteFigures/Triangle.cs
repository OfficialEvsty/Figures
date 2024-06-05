using GeometryLib.Exceptions;

namespace GeometryLib.ConcreteFigures
{
    /// <summary>
    /// Конкретная фигура Triangle.
    /// </summary>
    public class Triangle : Figure, IRectangular
    {
        private double d_aLen;
        private double d_bLen;
        private double d_cLen;

        public double ALength { get { return d_aLen; } }
        public double BLength { get { return d_bLen; } }
        public double CLength {  get { return d_cLen; } }

        public Triangle(double a, double b, double c) 
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentNegativeException("Стороны треугольника не могут быть отрицательными.");
            else if (a == 0 || b == 0 || c == 0)
                throw new Exceptions.ArgumentNullException("Стороны треугольника не могут быть равны нулю.");
            else
            {
                var listToSort = new List<double>() { d_aLen, d_bLen, d_cLen};
                listToSort.Sort();
                d_aLen = listToSort[0]; d_bLen = listToSort[1]; d_cLen = listToSort[2];
            }
        }
        public override double GetArea()
        {
            double GetPerimeter(Triangle triangle)
            {
                return triangle.ALength + triangle.BLength + triangle.CLength;
            }
            var halfP = GetPerimeter(this);
            return Math.Sqrt(halfP * (halfP - this.d_aLen) * (halfP - this.d_bLen) * (halfP - this.d_cLen));
        }

        public bool IsRectangular()
        {
            return (bool)(Math.Pow(d_cLen, 2) == Math.Pow(d_aLen, 2) + Math.Pow(d_bLen, 2));
        }
    }
}
