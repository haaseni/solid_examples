namespace LiskovSubstitutionPrincipleExample.Classes
{
    public class Square : Rectangle
    {
        public Square()
        {
            Height = Width;
        }

        public new void SetWidth(double width)
        {
            base.SetWidth(width);
            base.SetHeight(width);
        }

        public new void SetHeight(double height)
        {
            base.SetHeight(height);
            base.SetWidth(height);
        }
    }
}
