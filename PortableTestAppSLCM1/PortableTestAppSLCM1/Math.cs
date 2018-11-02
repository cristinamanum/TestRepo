using System;

namespace PortableTestAppSLCM1
{
    public class Math
    {
        public static long Factorial(int x)
        {
            if (x <= 1)
            {
                return 1;
            }

            return x * Factorial(x - 1);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
