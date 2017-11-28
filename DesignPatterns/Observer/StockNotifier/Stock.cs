using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.StockNotifier
{
    public abstract class Stock
    {
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();
        public string Symbol { get; set; }

        public double Price
        {
            get { return price; }
            set { price = value;
                Notify();
            }
        }
        public Stock(string symbol, double price)
        {
            this.Symbol = symbol;
            this.Price = price;
        }

        public void Subscribe(IInvestor investor)
        {
            if (!investors.Contains(investor))
            {
                investors.Add(investor);
            }
        }

        public void Unsubscribe(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("");
        }
    }
}
