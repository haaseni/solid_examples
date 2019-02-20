using System;
using System.Collections.Generic;
using System.Reflection;
using InterfaceSegregationPrincipleExample.Classes;
using InterfaceSegregationPrincipleExample.Interfaces;

namespace InterfaceSegregationPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Interface Segregation Principle is implemented in
            // this example through the use of interfaces to define common
            // members for general types. For example all hats,
            // shirts, pants, and shoes share common members with specific
            // types of hats, shirts, pants, and shoes. Putting
            // all of the members in one interface to cover all products 
            // would be a violation of the Interface Segregation Principle.
            // This principle means to define an interfaces as narrowly as
            // the granularity of specific types that are needed.

            // For example if I have a new clothes outfit...
            var outfit1 = new Outfit();
            outfit1.Name = "Colby";

            // I select a tee shirt as the outfit shirt
            outfit1.Shirt = new TeeShirt 
            {
                Id = 1,
                Stock = 500,
                Weight = 1.5,
                ShirtSize = "XL"
            };

            // I select jeans as the outfit pants
            outfit1.Pants = new Jeans 
            {
                Id = 2,
                Stock = 300,
                Weight = 3.5,
                Inseam = 32,
                WaistSize = 38
            };

            // I select sneakers as the outfit shoes
            outfit1.Shoes = new Sneakers
            {
                Id = 3,
                Stock = 200,
                Weight = 1.5,
                ShoeSize = 10.5
            };

            // I select baseball cap as the outfit hat
            outfit1.Hat = new BaseballCap
            {
                Id = 4,
                Stock = 55,
                Weight = .5,
                HatSize = 12
            }; 

            // Let's say I want a second outfit...
            var outfit2 = new Outfit();
            outfit2.Name = "Executive";

            outfit2.Shirt = new DressShirt
            {
                Id = 5,
                Stock = 550,
                Weight = 1.7,
                ShirtSize = "S",
                NumberOfPockets = 1,
                NumberOfButtons = 12
            };

            outfit2.Pants = new Slacks
            {
                Id = 6,
                Stock = 150,
                Weight = 1.4,
                WaistSize = 36,
                Inseam = 34,
                HasCuff = false,
                HasPermanentCrease = true
            };

            outfit2.Shoes = new DressShoes
            {
                Id = 7,
                Stock = 45,
                Weight = 1.8,
                ShoeSize = 11,
                LeatherType = "Patent"
            };

            outfit2.Hat = new Fedora
            {
                Id = 8,
                Stock = 87,
                Weight = .6,
                HatSize = 13,
                BrimSize = 2
            };

            // List the outfits so we can see how different outfits share
            // some of the same properties but are segregated by interface.
            var outfits = new List<Outfit> {outfit1, outfit2};

            foreach (var outfit in outfits)
            {
                ListProperties(outfit, 0);
                Console.WriteLine(new string('-', 77));
            }

            Console.ReadKey();
        }

        static void ListProperties(object obj, int indent)
        {
            if (obj == null)
                return;

            string indentString = new string(' ', indent);

            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object propValue = property.GetValue(obj, null);
                if (property.PropertyType.Assembly == objType.Assembly && !property.PropertyType.IsEnum)
                {
                    Console.WriteLine($"{indentString}{property.Name}: ");
                    ListProperties(propValue, indent + 2);
                }
                else
                {
                    Console.WriteLine($"{indentString}{property.Name}: {propValue}");
                }
            }
        }
    }
}
