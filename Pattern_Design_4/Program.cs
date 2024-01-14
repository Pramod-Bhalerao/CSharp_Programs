using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
