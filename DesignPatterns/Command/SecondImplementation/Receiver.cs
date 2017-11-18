using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.SecondImplementation
{
    public class Receiver
    {
        public void Action(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                Console.WriteLine($"Hi cool guy {userName}, I am called from the command");

            }
        }
    }
}
