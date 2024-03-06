using System;

namespace PowTwoUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            Power2Until15();
        }

        private static void Power2Until15()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
