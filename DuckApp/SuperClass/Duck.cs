using DuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.SuperClass
{
    public abstract class Duck
    {
        #region Attributes
        protected IFlyable FlyingBehavior;
        protected IQuackable QuackingBehavior;
        #endregion

        #region Properties
        public void SetFlyingBehavior(IFlyable fb)
        {
            FlyingBehavior = fb;
        }

        public void SetQuackingBehavior(IQuackable qb)
        {
            QuackingBehavior = qb;
        }
        #endregion

        #region Constructor
        public Duck()
        {

        }
        #endregion


        #region Methods
        public abstract void Display();
        public void PerformFlying()
        {
            FlyingBehavior.fly();
        }

        public void PerformQuacking()
        {
            QuackingBehavior.quack();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
        #endregion

    }
}
