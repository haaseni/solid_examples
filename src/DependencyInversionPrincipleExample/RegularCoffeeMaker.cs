namespace DependencyInversionPrincipleExample
{
    public class RegularCoffeeMaker
    {
        private readonly CoffeeMachine _coffeeMachine;
        private readonly Water _water;
        private CoffeeGrounds _coffeeGrounds;
        
        public RegularCoffeeMaker()
        {
            _water = new Water();
            _coffeeGrounds = new CoffeeGrounds();
            _coffeeMachine = new CoffeeMachine();
        }

        public Coffee BrewFilterCoffee()
        {
            return _coffeeMachine.Brew(_water, _coffeeGrounds, CoffeeType.Filtered);
        }

        public void AddWater(Water water)
        {
            _water.Ounces += water.Ounces;
        }

        public void AddCoffeeToFilter(CoffeeGrounds coffeeGrounds)
        {
            _coffeeGrounds = coffeeGrounds;
        }
    }
}
