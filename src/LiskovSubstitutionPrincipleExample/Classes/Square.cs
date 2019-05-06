namespace LiskovSubstitutionPrincipleExample.Classes
{
    public class Square : Rectangle
    {
        public Square()
        { }

        public override void SetWidth(double width)
        {
            _width = width;
            _height = width;
        }

        public override void SetHeight(double height)
        {
            _width = height;
            _height = height;
        }
    }
}
