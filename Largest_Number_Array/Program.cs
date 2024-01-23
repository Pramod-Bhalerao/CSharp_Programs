using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int max = arr[0], i = 1;

            while(i<=4)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                i++;
            }
            Console.WriteLine("The Largest Number In The Array IS: {0} ", max);
            Console.Read();
        }
    }
}

