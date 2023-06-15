using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class Factorial
    {
        public static void FactorialNumber() {
            Console.WriteLine("enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for(int i = 1; i <= x; i++)
            {
                fact = fact * i;
                Console.WriteLine(fact);
                
            }
        }
    }
}
