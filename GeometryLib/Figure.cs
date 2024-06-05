namespace GeometryLib
{
    /// <summary>
    /// Абстрактный класс для любой 2D фигуры.
    /// </summary>
    public abstract class Figure : IAreaCalculable
    {
        public abstract double GetArea();
    }
}