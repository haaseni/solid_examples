using LiskovSubstitutionPrincipleExample.Interfaces;

namespace LiskovSubstitutionPrincipleExample.Classes
{
    public abstract class Shape : IShape
    {
        public abstract double Area();
    }
}