using InterfaceSegregationPrincipleExample.Interfaces;

namespace InterfaceSegregationPrincipleExample.Classes
{
    public class DressShoes : IProduct, IShoes
    {
        public int Id { get; set; }

        public double Weight { get; set; }

        public int Stock { get; set; }

        public double ShoeSize { get; set; }

        public string LeatherType { get; set; }
    }
}
