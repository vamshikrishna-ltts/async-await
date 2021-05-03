using System;
using System.Numerics;

namespace Factorial
{
    public class CalculateFactorial
    {

        public delegate void sendResult(BigInteger num);
        public event sendResult whereToSend;
        //5 => 5*4*3*2*1
        public  void Calculate(BigInteger num)
        {
            BigInteger result = num;

            for (BigInteger i =1; i<num; i++)
            {
                result = result * i;
                
            }
            whereToSend(result);
        }
    }
}
