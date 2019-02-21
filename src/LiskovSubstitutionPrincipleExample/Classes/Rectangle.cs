namespace LiskovSubstitutionPrincipleExample.Classes
{
    public class Rectangle : Shape
    {
        public double Width { get; protected set; }

        public double Height { get; protected set; }

        public Rectangle()
        {}

        public void SetWidth(double width)
        {
            Width = width;
        }

        public void SetHeight(double height)
        {
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
