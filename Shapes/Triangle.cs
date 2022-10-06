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

        public double Base => _base;

        public double Height => _height;

        /// <summary>
        /// Computes the area of the triangle.
        /// </summary>
        /// <returns>The <c>double</c> value of the area.</returns>
        public double GetArea()
        {
            return (_base * _height) / 2d;
        }

        public override string ToString()
        {
            return $"{nameof(_base)}: {_base}, {nameof(_height)}: {_height}";
        }
    }
}