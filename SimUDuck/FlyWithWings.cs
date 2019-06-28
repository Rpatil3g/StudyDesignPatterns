using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Interface;

namespace SimUDuck
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am Flying");
        }
    }
}
