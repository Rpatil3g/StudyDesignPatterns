using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Coffees
{
    public class HouseBend:Beverage
    {
        public HouseBend()
        {
            description = "this is houseBend coffee";
        }

        public override double cost()
        {
           return 10.0;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
