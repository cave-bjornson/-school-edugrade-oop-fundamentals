namespace ShapeTests
{
    using Shapes;

    public class CircleTest
    {
        private readonly Circle circle = new(1.0);

        [Fact]
        public void GetArea_RadiusIsOne_ReturnPi()
        {
            Assert.Equal(Math.PI, this.circle.GetArea());
        }

        [Fact]
        public void GetCircumference_RadiusIsOne_ReturnPi()
        {
            double computedPI = circle.GetCircumference() / 1d / 2d;
            Assert.Equal(Math.PI, computedPI);
        }

        [Fact]
        public void GetVolume_RadiusIsOne_ReturnOne()
        {
            double computedRadius = Math.Cbrt((circle.GetVolume() * (3d / 4d) / Math.PI));
            Assert.Equal(1d, computedRadius);
        }
    }

    public class TriangleTest
    {
        private readonly Triangle triangle = new Triangle(4.0, 3.0);

        [Fact]
        public void GetArea_ReturnsSame()
        {
            Assert.Equal((4d * 3d) / 2d, triangle.GetArea());
        }
    }
}