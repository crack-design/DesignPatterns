using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Adapter : INewSocket
    {
        private readonly OldSocket adaptee;
        public Adapter(OldSocket adaptee)
        {
            this.adaptee = adaptee;
        }
        public string MatchNewSocket()
        {
            return this.adaptee.MatchThinSocket();
        }
    }
}
