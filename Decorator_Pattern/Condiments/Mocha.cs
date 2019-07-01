using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Condiments
{
    public class Mocha : Condiments
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return 2.0 + this.beverage.cost();
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + ", Mocha";
        }
    }
}
