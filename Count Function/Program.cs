using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Function
{
    public class Program
    {
        public static int count = 1;
        public static void CountFunction()
        {
            count++;
            Console.WriteLine("The Main Method Call {0} Times",count);
        }
        static void Main(string[] args)
        {
            for (int var = 0; var < 10; var++);
            {
                Program.CountFunction();
            }
                Console.Read();
        }
    }
}
