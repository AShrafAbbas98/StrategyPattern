﻿using DuckApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Bahavior.Flying
{
    internal class FlyNoWay : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I can't fly ):");
        }
    }
}
