using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if (i>j || i==j) 
                    {
                        Console.Write(i+" "+i);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();     
        }
       
    }
}
