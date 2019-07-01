using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public string description = "unknown Desccription";

        public abstract double cost();

        public abstract string getDescription();
       
    }
}
