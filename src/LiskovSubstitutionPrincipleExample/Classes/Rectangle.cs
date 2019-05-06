namespace LiskovSubstitutionPrincipleExample.Classes
{
    public class Rectangle : Shape
    {
        protected double _width;
        protected double _height;
        
        public double Width
        {
           get { return _width; } 
        }

        public double Height
        {
            get { return _height; }
        }

        public Rectangle()
        {}

        public virtual void SetWidth(double width)
        {
            _width = width;
        }

        public virtual void SetHeight(double height)
        {
            _height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }
    }
}
