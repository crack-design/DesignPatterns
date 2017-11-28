using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.StockNotifier
{
    public class Facebook : Stock
    {
        public Facebook(string symbol, double price):base(symbol,price)
        {
        }
    }
}
