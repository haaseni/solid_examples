﻿using System;
using System.Threading;

namespace DependencyInversionPrincipleExample
{
    public class CoffeeMachine : CoffeeMachineBase
    {
        public override Coffee Brew(Water water, CoffeeGrounds coffeeGrounds, string coffeeType)
        {
            if (water == null)
            {
                Console.WriteLine("Please add water.");
                return null;
            }

            if (coffeeGrounds == null)
            {
                Console.WriteLine("Please add coffee grounds.");
                return null;
            }
            
            HeatWater(water);
            var coffee = StartBrew(water);
            StopBrew();

            return coffee;
        }

        protected override Coffee StartBrew(Water water)
        {
            Console.WriteLine("Start Dripping");

            var totalWaterOunces = water.Ounces;
            var coffeeOunces = decimal.Zero;

            while (water.Ounces > 0)
            {
                var releaseOunces = totalWaterOunces * (decimal).10; // Release water in 10% increments;
                water.Ounces = water.Ounces - releaseOunces;

                coffeeOunces = totalWaterOunces - (releaseOunces * (decimal).20); // 20% water loss due to coffee absorption
                Console.Write(".");
                Thread.Sleep(1000);
            }

            var coffeeTemperatureF = water.TemperatureF - (water.TemperatureF * (decimal).15); // Lower temperature of coffee liquid due to heat loss from brewing

            return new Coffee
            {
                Ounces = coffeeOunces,
                TemperatureF = coffeeTemperatureF
            };
        }
    }
}
