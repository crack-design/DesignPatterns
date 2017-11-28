using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.StockNotifier
{
    public class Investor : IInvestor
    {

        private string name;
        public Stock Stock { get; set; }
        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine($"Notification for {name} of {stock.Symbol} change to {stock.Price:C}");
        }
    }
}
