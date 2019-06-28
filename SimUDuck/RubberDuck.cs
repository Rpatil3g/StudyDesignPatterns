using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new NoFly();
        }
        public override void display()
        {
            Console.WriteLine("I am rubber duck");
        }

        public override void quack()
        {
            Console.WriteLine("I am not quacking");
        }

        public override void swim()
        {
            Console.WriteLine("I can swimming");
        }

       
    }
}
