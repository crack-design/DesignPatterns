using DesignPatterns.Command.Receivers;

namespace DesignPatterns.Command
{
    public class Invoker
    {
        private CalcReceiver calcReceiver = new CalcReceiver();
        private AbstractCommand abstractCommand;
        private int sum = 0;

        public void SetCommand(AbstractCommand command)
        {
            this.abstractCommand = command;
        }

        public void DoStuff(char Operator, int firstOperand, int secondOperand)
        {
            AbstractCommand command = new CalculatorCommand(calcReceiver, firstOperand, secondOperand, Operator);
            command.Execute();
        }
    }
}
