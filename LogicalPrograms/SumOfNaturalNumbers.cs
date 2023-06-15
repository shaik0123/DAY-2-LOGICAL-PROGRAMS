using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class SumOfNaturalNumbers
    {
        public static void sum()
        {
            int n = 5;
            int i = 0;
            int sum = 0;
            while (i <= n)
            {
                sum += i;
                i++;

            } 
            Console.WriteLine("sum : "+ sum);
        }
    }
}
