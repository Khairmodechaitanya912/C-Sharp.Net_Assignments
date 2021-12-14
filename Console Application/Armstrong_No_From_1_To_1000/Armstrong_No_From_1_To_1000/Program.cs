using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong_No_From_1_To_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Sum, R, N1, N2;

            for (N = 1; N <= 1000; N++)
            {
                N1 = N;
                N2 = N;
                Sum = 0;

                while (N2 > 0)
                {
                    R = N2 % 10;
                    Sum = Sum + (R * R * R);
                    N2 = N2 / 10;
                }

                if (N1 == Sum)
                {
                    Console.WriteLine(N1);
                }

            }

            Console.ReadLine();
        }
    }
}
