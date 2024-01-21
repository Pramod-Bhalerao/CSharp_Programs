using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 2, 1, 0, -1, -2, -3, -4 };
            Console.WriteLine("The Content Of array");

            foreach(int i in numbers) 
            {
                Console.Write("{0} ",i);
            }
            Console.ReadLine();
        }
    }
}
