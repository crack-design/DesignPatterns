using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Command.Receivers;

namespace DesignPatterns.Command
{
    public class CalculatorCommand : AbstractCommand
    {
        private CalcReceiver calcReceiver;
        public char Operator { get; set; }
        public int FirstOperand { get; set; }
        public int SecondOperand { get; set; }
        public CalculatorCommand(CalcReceiver calcReceiver, int firstOperand, int secondOperand, char actionOperator)
        {
            this.calcReceiver = calcReceiver;
            this.FirstOperand = firstOperand;
            this.SecondOperand = secondOperand;
            this.Operator = actionOperator;
        }

        public override void Execute()
        {
            calcReceiver.Count(Operator, FirstOperand, SecondOperand);
        }
    }
}
