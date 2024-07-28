using DuckApp.SuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.SubClasses
{
    internal class ModelDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Model");
        }
    }
}
