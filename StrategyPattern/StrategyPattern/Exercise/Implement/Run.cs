using StrategyPattern.Exercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Exercise.Implement
{
    public class Run : ExerciseBehavior
    {
        public void Exercise()
        {
            Console.WriteLine("慢跑");
        }
    }
}
