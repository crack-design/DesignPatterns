using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int MathOperation(int a, int b);
    delegate long DurableMathOperation(int a, int b); 
    class Program
    {
        public static void NotifyOperationCompleted(IAsyncResult result)
        {
            Console.WriteLine("Operation is completed");
            Console.WriteLine($"{result.AsyncState}");
            var mathTwo = new MathOperation(Math.Divide);
            Console.WriteLine($"Following Call: {mathTwo.Invoke(10,3)}");
        }
        static void Main(string[] args)
        {
            #region BaseDelegate

            AsyncCallback callBack = new AsyncCallback(NotifyOperationCompleted);
            MathOperation mathOperationDelegate = new MathOperation(Math.Add);

            int result = mathOperationDelegate(100, 200);
            Console.WriteLine(result);

            mathOperationDelegate = new MathOperation(Math.Divide);
            result = mathOperationDelegate(200, 100);
            Console.WriteLine(result);

            result = mathOperationDelegate.Invoke(50, 10);

            var mathOne = new DurableMathOperation(Math.DurableMultiply);

            var resultObject = mathOne.BeginInvoke(450545450, 2, callBack, "Async Call Completed");

            resultObject.AsyncWaitHandle.WaitOne();
            Console.WriteLine($"Called first: {mathOne.EndInvoke(resultObject)}");
            resultObject.AsyncWaitHandle.Close();

            Console.ReadLine();
#endregion
        }
    }
}
