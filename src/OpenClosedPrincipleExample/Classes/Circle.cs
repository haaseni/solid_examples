using System;

namespace OpenClosedPrincipleExample.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
