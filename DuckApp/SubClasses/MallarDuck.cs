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
    internal class MallarDuck : Duck
    {
        public MallarDuck()
        {
            FlyingBehavior = new FlyWithWings();
            QuackingBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("Looks Like Mallared");
        }
    }
}
