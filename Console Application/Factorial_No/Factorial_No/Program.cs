using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial_No
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, f, i;

            for (n = 1; n <= 10; n++)
            {
                f = 1;
                i = n;

                while (i >= 1)
                {
                    f = f * i;
                    i--;
                }

                Console.WriteLine("Fact = " + f);
                Console.ReadLine();
            }
        }
    }
}
