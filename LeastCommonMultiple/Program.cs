using System;

namespace LeastCommonMultiple
{
    class Program
    {
        static int GCD(int a, int b)
        {
            for(int t = b;b!=0;t = b)
            {
                b = a % b;
                a = t;
            }
            return a;
        }

        static int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Least Common Multiple of 6, 8 is: " + LeastCommonMultiple(6, 8));
        }
    }
}
