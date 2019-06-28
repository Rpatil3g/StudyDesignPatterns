using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("I am Mallard duck");
        }

        public override void quack()
        {
            Console.WriteLine("I am quacking");
        }

        public override void swim()
        {
            Console.WriteLine("I am swimming");
        }
    }
}
