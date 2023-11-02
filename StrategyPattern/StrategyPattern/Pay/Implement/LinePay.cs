using StrategyPattern.Pay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Pay.Implement
{
    public class LinePay : Paybehavior
    {
        public void Pay()
        {
            Console.WriteLine("LinePay");
        }
    }
}
