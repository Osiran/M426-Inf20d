using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiplication(int number, int factor)
        {
            return number * factor;
        }
        public int Division(int number, int factor)
        {
            if (factor != 0)
                return number / factor;

            throw new ArgumentException("Amount can't be 0");

        }
    }
}
