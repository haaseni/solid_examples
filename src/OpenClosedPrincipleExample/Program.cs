using System;
using OpenClosedPrincipleExample.Classes;

namespace OpenClosedPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mock up some shapes
            // Notice how the Array is of type Shape but the objects
            // are derived objects of shape. Thus Shape is open to
            // extension, but closed to modification.

            Circle circle = new Circle((double) 20);
            var rectangle = new Rectangle((double) 5, (double) 10);

            Shape[] shapes = new Shape[2] { circle, rectangle };

            Console.WriteLine("Shapes:");
            Console.WriteLine($"Circle Area   : {circle.Area()}");
            Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
            Console.WriteLine($"Total Area    : {TotalArea(shapes)}");

            Console.ReadKey();
        }

        static double TotalArea(Shape[] shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
