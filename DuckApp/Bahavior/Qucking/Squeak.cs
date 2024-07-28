using DuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Bahavior.Qucking
{
    internal class Squeak : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
