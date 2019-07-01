using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Coffees
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "this is espresso";
        }
        public override double cost()
        {
            return 20.0;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
