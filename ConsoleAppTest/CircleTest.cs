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
    }
}