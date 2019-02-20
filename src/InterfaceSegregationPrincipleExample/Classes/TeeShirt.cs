using InterfaceSegregationPrincipleExample.Interfaces;

namespace InterfaceSegregationPrincipleExample.Classes
{
    public class TeeShirt : IProduct, IShirt
    {
        public int Id { get; set; }

        public double Weight { get; set; }

        public int Stock { get; set; }

        public string ShirtSize { get; set; }
    }
}
