using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "M", "R", "P", "O", "M", "S" };
            int i = 5;

            Console.Write("The Reverse Of String Is: ");
            while (i >= 0)
            {
                Console.Write("{0} ", arr[i]);
                i--;
            }
            Console.Read();
        }
    }
}
