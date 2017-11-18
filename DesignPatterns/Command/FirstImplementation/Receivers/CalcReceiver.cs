namespace DesignPatterns.Command.Receivers
{
    public class CalcReceiver
    {
        private int sum = 0;
        public void Count(char Operator, int firstOperand, int secondOperand)
        {
            switch (Operator)
            {
                case '+': sum = firstOperand + secondOperand;
                    break;
                case '-':
                    sum = firstOperand - secondOperand;
                    break;
                case '*':
                    sum = firstOperand * secondOperand;
                    break;
                case '/':
                    sum = firstOperand / secondOperand;
                    break;
            }
            System.Console.WriteLine($"Value = {sum,3}");
        }
    }
}
