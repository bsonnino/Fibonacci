using System;

namespace Fibonacci
{
    public class Fib
    {
        public Int64 Fibonacci(int n)
        {
            Int64 a = 0;
            Int64 b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                Int64 temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}