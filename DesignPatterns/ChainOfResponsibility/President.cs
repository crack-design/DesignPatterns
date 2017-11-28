using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine($"{this.GetType().Name} approved request # {purchase.Number}");
            }
            else
            {
                Console.WriteLine("Unable to handle this");
            }
        }
    }
}
