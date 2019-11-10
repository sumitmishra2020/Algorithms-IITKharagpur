using System;

namespace GCD
{
    class Program
    {
        static int GCD(int a, int b)
        {
            while(b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The GCD of 56, 24 is: " + GCD(56, 24));
        }
    }
}
