using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class AdapterConsumer
    {
        public static void Charge(INewSocket newSocket)
        {
            Console.WriteLine(newSocket.MatchNewSocket());
        }

        public static void ChargeViaOldSocket(IOldSocket oldSocket)
        {
            Console.WriteLine(oldSocket.MatchOldSocket());
        }
    }
}
