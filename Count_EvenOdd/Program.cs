using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, ecnt = 0, ocnt = 0;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("Enter A Number");
                num=Convert.ToInt32(Console.ReadLine());
                if(num%2==0)
                {
                    ecnt++;

                }
                else
                {
                    ocnt++;
                }
            }
            Console.WriteLine("Count Of Even Is: {0}  Count OF Odd Is: {1}", ecnt, ocnt);
            Console.ReadLine();
        }
    }
}
