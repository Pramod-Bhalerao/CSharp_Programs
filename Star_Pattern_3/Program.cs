using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Pattern_Design3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <=10; rows++)
            {
                for (int cols = 1; cols<=rows; cols++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
          
            for (int rows = 10; rows >= 1; rows--)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
