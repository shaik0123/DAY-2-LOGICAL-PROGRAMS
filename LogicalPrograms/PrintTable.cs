using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class PrintTable
    {
        public static void Table()
        {
            Console.WriteLine("enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10 ; i++)
            {
                int x = i * n;
                Console.WriteLine(n+" * "+i+" = " +x);
            }
        }
    }
}
