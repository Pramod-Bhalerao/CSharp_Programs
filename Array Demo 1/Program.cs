using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write A Program To Print Sum Of 10 Numbers From User And Print Those Numbers (ARRAY)

namespace Array_Demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            int sum = 0;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Enter A Number");
                arr[i]=Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }

            for(int i=0;i<10;i++)
            {
                Console.Write("  {0}", arr[i]);

            }
            Console.WriteLine("  / The Sum Of Array Elements Is : {0}",sum);
            Console.ReadLine();



        }
    }
}
