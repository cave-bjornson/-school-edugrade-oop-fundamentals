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
        /// Computes the area of the circle.
        /// </summary>
        /// <returns>
        /// The <c>double</c> value of the area.
        /// </returns>
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        /// <summary>
        /// Computes the circumference of the circle.
        /// </summary>
        /// <returns>The <c>double</c> value of the circumference</returns>
        public double GetCircumference()
        {
            return 2d * Math.PI * _radius;
        }


        /// <summary>
        /// Computes the volume of a globe with the same radius as this circle.
        /// </summary>
        /// <returns>The <c>double</c> value of the volume.</returns>
        public double GetVolume()
        {
            return (4d / 3d) * Math.PI * Math.Pow(_radius, 3d);
        }
    }
}