using System;
using Factorial;
using System.Threading;
using System.Numerics;
using System.Threading.Tasks;
namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //async await
            Method();
            Console.WriteLine("Main Thread");
            

            //threading
            var cal = new CalculateFactorial();


            Console.WriteLine("Starting");

            Thread t1 = new Thread(() => cal.Calculate(5));
            t1.Start();
            cal.whereToSend += DisplayFactorial;
            cal.whereToSend += DisplayFactorialMoreThan10k;
           

            Console.WriteLine("Finished");


            Console.ReadLine();
            
        }

        //async await
      public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");

        }

       public static void LongTask()
        {
            Thread.Sleep(2000);
        }


        //threading

       public static void DisplayFactorial(BigInteger value)
        {
            Console.WriteLine(value);
        }
       public static void DisplayFactorialMoreThan10k(BigInteger value)
        {
            if (value > 10000)
            {
                Console.WriteLine("Big value");
            }
            else
            {
                Console.WriteLine("Small value");
            }
        }

    }
}
