﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Person
{
    public class Taiwanese : Person
    {
        public override void Display()
        {
            Console.WriteLine("我是台灣人");
        }
    }
}
