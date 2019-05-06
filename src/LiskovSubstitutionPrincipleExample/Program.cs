using System;
using LiskovSubstitutionPrincipleExample.Classes;

namespace LiskovSubstitutionPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is an example of the Liskov Substitution Principle. 
            // A derived class such as Square, should be able to be substituted
            // by its parent class, Rectangle.

            // Set a square's height, which should also set the square width
            // to the same value
            var square = new Square();
            square.SetHeight(10);
            Console.WriteLine("\nSet square height to 10");
            Console.WriteLine("Square");
            PrintRectangle(square);
            
            // Now re-cast the square to it's parent class, rectangle, and
            // setting a different height and width should work. We are
            // substituting a rectangle for a square.
            var rectangle = (Rectangle)square;
            rectangle.SetWidth(10);
            rectangle.SetHeight(20);
            Console.WriteLine("\nSet rectangle width to 10");
            Console.WriteLine("\nSet rectangle height to 20");
            Console.WriteLine("\nSquare Back To Rectangle");
            PrintRectangle(rectangle);
            Console.WriteLine("\nSee, we can't set a different height from the width because we are violating the Liskov Substitution Principle!");

            Console.ReadKey();
        }

        static void PrintRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"Height: {rectangle.Height}");
            Console.WriteLine($"Width: {rectangle.Width}");
        }
    }
}
