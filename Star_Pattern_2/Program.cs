using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Pattern_Design2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;
            Console.WriteLine("Enter No Of Rows");
            rows=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                   
            }
            Console.ReadLine();
        }
    }
}
