using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.SecondImplementation
{
    public class ConcreteCommand : ICommand
    {
        public string Name { get; set; }
        private Receiver receiver;
        public Receiver Receiver
        {
            get
            {
                return receiver;
            }
            set
            {
                receiver = value;
            }
        }

        public ConcreteCommand(Receiver receiver, string name)
        {
            this.Receiver = receiver;
            this.Name = name;
        }
        public void Execute()
        {
            receiver.Action(this.Name);
        }


        public void Unexecute()
        {
            throw new NotImplementedException();
        }
    }
}
