using System;

namespace DependencyInversionPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeGrounds coffeeGrounds = null;
            Coffee coffee = null;

            Console.WriteLine("Hello!");
            Console.WriteLine("For premium coffee, please type 'P'. For regular, please type 'R':");
            var machineType = Console.ReadLine();
            
            switch (machineType)
            {
                case MachineType.Regular:
                    var regularCoffeeMachine = new RegularCoffeeMaker();

                    regularCoffeeMachine.AddWater(new Water { Ounces = 10, TemperatureF = 75 });
                    regularCoffeeMachine.AddCoffeeToFilter(new CoffeeGrounds { Ounces = 3, GrindType = GrindType.Coarse});

                    coffee = regularCoffeeMachine.BrewFilterCoffee();
                    break;
                case MachineType.Premium:
                    var premiumCoffeeMachine = new PremiumCoffeeMaker();

                    Console.WriteLine("For filtered coffee, please type 'F'. For espresso, please type 'E':");
                    var coffeeType = Console.ReadLine();

                    premiumCoffeeMachine.AddWater(new Water { Ounces = 48, TemperatureF = 75 });
                    premiumCoffeeMachine.AddCoffeeBeans(new CoffeeBeans { Ounces = 30 });

                    switch (coffeeType)
                    {
                        case CoffeeType.Filtered:
                            coffee = premiumCoffeeMachine.BrewFilterCoffee();
                            break;
                        case CoffeeType.Espresso:
                            coffee = premiumCoffeeMachine.BrewEspressoCoffee();
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            if (coffee != null)
            {
                Console.WriteLine("Coffee is ready.");
                Console.WriteLine($"{coffee.Ounces}oz made.");
                Console.WriteLine($"Temperature {coffee.TemperatureF}(F).");
                Console.WriteLine("Enjoy your day!");
            }

            Main(null);
        }
    }
}
