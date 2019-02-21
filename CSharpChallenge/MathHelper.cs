using System;

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
        public static void Calculate(Shape shape, out double area, out double length){
            area = 0;
            length = 0;

            if (shape is Circle)
            {
                var radio = ((Circle)shape).Radio;
                area = Math.PI * Math.Pow(radio, 2);
                length = 2 * Math.PI * radio;
            }
        }
    }
}