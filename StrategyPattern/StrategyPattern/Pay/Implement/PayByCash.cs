using StrategyPattern.Pay.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Pay.Implement
{
    public class PayByCash : Paybehavior
    {
        public void Pay()
        {
            Console.WriteLine("現金支付");
        }
    }
}
