using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=25; i++) 
            { 
                if(i%2==0)
                {
                    Console.WriteLine(i + "-Even");
                    continue;
                }
                /*else
                    Console.WriteLine(i);*/
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + "-Odd");
                    continue;
                }
            }
           
              Console.ReadLine();
        }
    }
}
