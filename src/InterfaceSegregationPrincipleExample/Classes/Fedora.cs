using InterfaceSegregationPrincipleExample.Interfaces;

namespace InterfaceSegregationPrincipleExample.Classes
{
    public class Fedora : IProduct, IHat
    {
        public int Id { get; set; }
        
        public double Weight { get; set; }

        public int Stock { get; set; }

        public int HatSize { get; set; }

        public double BrimSize { get; set; }
    }
}
