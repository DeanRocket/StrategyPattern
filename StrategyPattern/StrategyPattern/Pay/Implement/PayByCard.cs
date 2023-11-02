using StrategyPattern.Pay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Pay.Implement
{
    public class PayByCard : Paybehavior
    {
        public void Pay()
        {
            Console.WriteLine("信用卡付款");
        }
    }
}
