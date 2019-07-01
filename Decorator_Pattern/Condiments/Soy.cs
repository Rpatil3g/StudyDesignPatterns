using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Condiments
{
    public class Soy : Condiments
    {
        Beverage beverage;

        public Soy()
        {

        }
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return 1.0 + this.beverage.cost();
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + ", Soy";
        }
    }
}
