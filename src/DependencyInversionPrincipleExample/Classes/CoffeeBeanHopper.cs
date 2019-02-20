using System;

namespace DependencyInversionPrincipleExample
{
    public class CoffeeBeanHopper
    {
        private CoffeeBeans _coffeeBeans;

        public CoffeeBeans Dispense()
        {
            decimal ouncesDispense = 3;

            if (_coffeeBeans.Ounces / ouncesDispense >= 1)
            {
                _coffeeBeans.Ounces = _coffeeBeans.Ounces - ouncesDispense;
                return new CoffeeBeans { Ounces = ouncesDispense };
            }

            Console.WriteLine("Insufficient espresso coffee beans. Please replenish.");
            return null;
        }

        public void Add(CoffeeBeans coffeeBeans)
        {
            _coffeeBeans = coffeeBeans;
        }
    }
}
