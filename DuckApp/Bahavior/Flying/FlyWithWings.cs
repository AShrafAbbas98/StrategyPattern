using DuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Bahavior.Flying
{
    public class FlyWithWings : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I'm flying (=");
        }
    }
}
