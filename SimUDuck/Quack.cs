using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Interface;

namespace SimUDuck
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("I am quaking");
        }
    }
}
