//program to check even number from 1 to 10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n=10;
      
            Console.WriteLine("The even numbrs from 1 to 10 are:");
            
               for (i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                      
                        Console.WriteLine(i);
                    }
                }
            
            Console.ReadLine();
        }
    }
}
