using InterfaceSegregationPrincipleExample.Interfaces;

namespace InterfaceSegregationPrincipleExample.Classes
{
    class Slacks : IProduct, IPants
    {
        public int Id { get; set; }

        public double Weight { get; set; }

        public int Stock { get; set; }

        public int Inseam { get; set; }

        public int WaistSize { get; set; }

        public bool HasPermanentCrease { get; set; }

        public bool HasCuff { get; set; }
    }
}
