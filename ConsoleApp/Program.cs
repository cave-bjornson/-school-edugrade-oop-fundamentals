namespace ConsoleApp
{
    using Shapes;

    public class Program
    {
        public static void Main()
        {
            const string Unit = "m";
            const char PowerTwoChar = '\u00B2';
            const char PowerThreeChar = '\u00B3';

            var circleA = new Circle(5.0);
            var circleB = new Circle(6.0);
            var triangle = new Triangle(5.0, 6.0);

            Console.WriteLine("Here's some shapes!");
            Console.WriteLine();

            CircleWriter(circleA);
            Console.WriteLine();
            CircleWriter(circleB);
            Console.WriteLine();
            Console.WriteLine(
                $"A triangle with the base {triangle.Base:N}{Unit} and height {triangle.Height:N}{Unit} "
                + $"has an area of {triangle.GetArea():N}{Unit}{PowerTwoChar}");

            void CircleWriter(Circle aCircle) =>
                Console.WriteLine(
                    "{0}{1}{2}{3}",
                    $"A circle with a radius of {aCircle.Radius:N}{Unit} has:\n",
                    $"Area: {aCircle.GetArea():N}{Unit}{PowerTwoChar}\n",
                    $"Circumference: {aCircle.GetCircumference():N}{Unit}\n",
                    $"Volume (As a globe with this radius): {aCircle.GetVolume():N}{Unit}{PowerThreeChar}");
        }
    }
}