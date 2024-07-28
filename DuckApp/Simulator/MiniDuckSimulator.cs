using DuckApp.Bahavior.Flying;
using DuckApp.Bahavior.Qucking;
using DuckApp.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp
{
    internal class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            //Programm based on Interface not implemnatation
            var mallar = new MallarDuck();
            mallar.PerformFlying();
            mallar.PerformQuacking();

            //Set behavior dynamically
            var model = new ModelDuck();
            model.SetFlyingBehavior(new FlyNoWay());
            model.SetQuackingBehavior(new Quack());
        }
    }
}
