using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Duck rubber = new RubberDuck();
            mallard.display();
            mallard.quack();
            mallard.swim();
            mallard.fly();

            rubber.display();
            rubber.quack();
            rubber.swim();
            rubber.fly();
        }
    }
}
