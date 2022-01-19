using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    public class Client
    {
        public string firstName;
        public string secondName;
        private int accumulativeDiscount = 0;
        private int promoCodeDiscount = 0;
        private int defaultPrice = 1000;
        public int AccumulativeDiscount { get=>accumulativeDiscount; set=>accumulativeDiscount=value; }
        public void SetDiscount(int x)
        {
            promoCodeDiscount = x;
        }
        public int GetPrice()
        {
            var firstDiscount = defaultPrice - ((defaultPrice * accumulativeDiscount) / 100); 
            var result = firstDiscount - ((firstDiscount * promoCodeDiscount) / 100);
            return result;
        }
    }
}
