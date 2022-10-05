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
        /// The <c>double</c> value of the circles area.
        /// </returns>
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}