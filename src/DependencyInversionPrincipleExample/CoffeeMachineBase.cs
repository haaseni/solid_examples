using System;
using DependencyInversionPrincipleExample.Interfaces;

namespace DependencyInversionPrincipleExample
{
    public abstract class CoffeeMachineBase : ICoffeeMachine
    {
        public abstract Coffee Brew(Water water, CoffeeGrounds coffeeGrounds, string coffeeType);

        protected void HeatWater(Water water)
        {
            if (water != null)
                water.TemperatureF = 212;
        }

        protected abstract Coffee StartBrew(Water water);

        protected void StopBrew()
        {
            Console.WriteLine("\nStop Dripping\n");
        }
    }
}
