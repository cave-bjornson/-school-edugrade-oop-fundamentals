namespace Shapes
{
    public class Triangle
    {
        private readonly double _base;
        private readonly double _height;

        public Triangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }

        /// <summary>
        /// Computes the area of the triangle.
        /// </summary>
        /// <returns>The <c>double</c> value of the area.</returns>
        public double GetArea()
        {
            return (_base * _height) / 2d;
        }
    }
}