using System;

namespace DependencyInversionPrincipleExample
{
    class WaterHopper
    {
        private Water _water;

        public WaterHopper()
        {
            _water = new Water();
        }

        public Water Dispense(decimal ounces)
        {
            if (_water.Ounces / ounces >= 1)
            {
                _water.Ounces = _water.Ounces - ounces;
                return new Water { Ounces = ounces, TemperatureF = _water.TemperatureF };
            }
            
            Console.WriteLine("Insufficient water to brew coffee. Please replenish.");
            return null;
        }

        public void Add(Water water)
        {
            _water.Ounces += water.Ounces;
        }
    }
}
