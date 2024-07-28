using DuckApp.Bahavior.Flying;
using DuckApp.Bahavior.Qucking;
using DuckApp.SuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.SubClasses
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyingBehavior = new FlyNoWay();
            QuackingBehavior = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Looks Rubber");
        }
    }
}
