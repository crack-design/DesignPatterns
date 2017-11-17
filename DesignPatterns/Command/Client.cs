using DesignPatterns.Command.Receivers;

namespace DesignPatterns.Command
{
    public class Client
    {
        private CalcReceiver calc = new CalcReceiver();
        private int current = 0;

        public void Compute(char Operator, int firstOperand, int secondOperand)
        {
            AbstractCommand command = new CalculatorCommand(calc, firstOperand, secondOperand, Operator);
            command.Execute();
        }
    }
}
