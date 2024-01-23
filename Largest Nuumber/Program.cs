
// accept three number from user and find the largest one

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Nuumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("{0} is the Largest", a);
            }
            else if (b>c && b>a)
            {
                Console.WriteLine("{0} is the largest", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("{0} is the largest", c);
            }
            else 
            {
                Console.WriteLine("All numbers are equal");
            }
            Console.ReadLine(); 
        }
    }
}
