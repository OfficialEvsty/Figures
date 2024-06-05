
namespace GeometryLib.Exceptions
{
    /// <summary>
    /// Ошибка, вызываемая при передаче отрицательных аргументов в конструктор создания фигуры.
    /// </summary>
    public class ArgumentNegativeException : Exception
    {
        public ArgumentNegativeException(string message) : base(message) { }
    }
}
