namespace DependencyInversionPrincipleExample.Interfaces
{
    public interface ICoffeeMachine
    {
        Coffee Brew(Water water, CoffeeGrounds coffeeGrounds, string coffeeType);
    }
}
