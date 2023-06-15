using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class ReverseWord
    {
        public static void Reverce()
        {
            Console.WriteLine("enter the word");
            String s = Console.ReadLine();

            for (int i = s.Length-1; i >= 0; i--)
            {
                
                Console.WriteLine(s[i]);
               
            }
        }
    }
}
