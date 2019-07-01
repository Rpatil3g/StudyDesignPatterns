using Decorator_Pattern.Coffees;
using Decorator_Pattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();

            Console.WriteLine("Description is: "+beverage1.getDescription());
            Console.WriteLine("Cost is: "+beverage1.cost());

            Console.WriteLine("---------------------------------------------------------");

            Beverage beverage2 = new HouseBend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            Console.WriteLine("Description is: " + beverage2.getDescription());
            Console.WriteLine("Cost is: " + beverage2.cost());
        }
    }
}
