using static System.Math;

namespace CSharpChallenge
{
    public class Shape
    {
        
    }

    public class Circle: Shape{
        public double Radio { get; set; }        
    }

    public class MathHelper
    {
        public static (double Area, double Length) Calculate(Shape shape) => 
            shape is Circle circle ? (PI * Pow(circle.Radio, 2), 2 * PI * circle.Radio): (0, 0);
    }
}