using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.SecondImplementation
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
        Receiver Receiver { get; set; }
    }
}
