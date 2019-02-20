namespace DependencyInversionPrincipleExample
{
    public class PremiumCoffeeMaker
    {
        private Filter _filter;
        private Portafilter _portafilter;
        private CoffeeMachine _coffeeMachine;
        private EspressoMachine _espressoMachine;
        private readonly WaterHopper _waterHopper;
        private readonly CoffeeBeanHopper _coffeeBeanHopper;
        
        public PremiumCoffeeMaker()
        {
            _waterHopper = new WaterHopper();
            _coffeeBeanHopper = new CoffeeBeanHopper();
        }

        public Coffee BrewFilterCoffee()
        {
            _coffeeMachine = new CoffeeMachine();
            _filter = new Filter();

            var water = _waterHopper.Dispense(10);
            var coffeeBeans = _coffeeBeanHopper.Dispense();
            var coffeeGrounds = GrindCoffee(coffeeBeans, CoffeeType.Filtered);

            AddCoffeeToFilter(coffeeGrounds);

            return _coffeeMachine.Brew(water, coffeeGrounds, CoffeeType.Filtered);
        }

        public Coffee BrewEspressoCoffee()
        {
            _espressoMachine = new EspressoMachine();
            _portafilter = new Portafilter();

            var water = _waterHopper.Dispense(4);
            var coffeeBeans = _coffeeBeanHopper.Dispense();
            var coffeeGrounds = GrindCoffee(coffeeBeans, CoffeeType.Espresso);

            AddCoffeeToPortafilter(coffeeGrounds);

            return _espressoMachine.Brew(water, coffeeGrounds, CoffeeType.Espresso);
        }
        
        private CoffeeGrounds GrindCoffee(CoffeeBeans coffeeBeans, string coffeeType)
        {
            return new CoffeeGrounds
            {
                Ounces = coffeeBeans.Ounces,
                Type = coffeeType,
                GrindType = coffeeType == CoffeeType.Espresso ? GrindType.Fine : GrindType.Coarse
            };
        }
        
        public void AddWater(Water water)
        {
            _waterHopper.Add(water);
        }

        public void AddCoffeeBeans(CoffeeBeans coffeeBeans)
        {
            _coffeeBeanHopper.Add(coffeeBeans);
        }
        
        public void AddCoffeeToFilter(CoffeeGrounds coffeeGrounds)
        {
            _filter.CoffeeGrounds = coffeeGrounds;
        }

        public void AddCoffeeToPortafilter(CoffeeGrounds coffeeGrounds)
        {
            _portafilter.CoffeeGrounds = coffeeGrounds;
        }
    }
}
