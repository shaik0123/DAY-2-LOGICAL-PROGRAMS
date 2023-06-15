using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class FlipCoin
    {
        public static void Coin()
        {
            int head = 1;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;
            while (headcount < 20 && tailcount < 20)
            {
                Random random = new Random();
                int x = random.Next(0, 2);
                Console.WriteLine(x);
                if (x == 0)
                {
                    tailcount++;
                    Console.WriteLine("tail count" + tailcount);
                }
                else
                {
                    headcount++;
                    Console.WriteLine("head count" + headcount);
                }
            }
           
        }
    }
}