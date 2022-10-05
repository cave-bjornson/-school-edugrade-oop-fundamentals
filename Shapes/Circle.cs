// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Defines the Circle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Shapes
{
    public class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public double Area => GetArea();

        /// <summary>
        /// The get area.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}