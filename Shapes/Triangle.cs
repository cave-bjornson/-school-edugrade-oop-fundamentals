// --------------------------------------------------------------------------------
// <copyright file="Triangle.cs">
//   Björn Agnemo NET22
// </copyright>
// <summary>
//   Defines the Triangle type.
// </summary>
// --------------------------------------------------------------------------------

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
            return $"{this.GetType().Name} with: {nameof(Base)}: {_base}, {nameof(Height)}: {_height}";
        }
    }
}