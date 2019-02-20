using InterfaceSegregationPrincipleExample.Interfaces;

namespace InterfaceSegregationPrincipleExample.Classes
{
    public class Outfit
    {
        public string Name { get; set; }

        public IHat Hat { get; set; }

        public IShirt Shirt { get; set; }

        public IPants Pants { get; set; }

        public IShoes Shoes { get; set; }
    }
}
