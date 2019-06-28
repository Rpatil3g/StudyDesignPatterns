using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Interface;

namespace SimUDuck
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        public Duck()
        {

        }

        public abstract void display();

        public abstract void quack();

        public abstract void swim();

        public void fly()
        {
            flyBehavior.fly();
        }
    }
}
