using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class SumOfSquares
    {
        public static void Squares()
        {
            int sum = 0;
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                int x = n * i;
                Console.WriteLine(x);
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
