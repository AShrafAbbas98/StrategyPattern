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
    internal class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyingBehavior = new FlyWithWings();
            QuackingBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("Looks Red headed");
        }
    }
}
