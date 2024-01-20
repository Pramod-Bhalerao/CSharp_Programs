using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_By_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter A Number");
            Num=Convert.ToInt32(Console.ReadLine());

            if (Num % 3 == 0)
            {
                Console.WriteLine("Entered Number Is Divisible By 3");
            }
            else
            {
                Console.WriteLine("Entered Number Is Not Divisible By 3");
            }
                Console.ReadLine();
        }
    }
}
