using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_Else_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter A Number");
            num=Convert.ToInt32(Console.ReadLine());

            if(num==10)
            {
                Console.WriteLine("GOOD");
            }
            else if(num==20)
            {
                Console.WriteLine("BETTER");
            }
            else if (num==30)
            {
                Console.WriteLine("GREAT");
            }
            else 
            {
                Console.WriteLine("INVALID");
            }
            Console.ReadLine();
        }
    }
}
