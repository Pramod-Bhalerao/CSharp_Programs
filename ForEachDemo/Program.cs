using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch;
            Console.WriteLine("ENTER ANY STRING");
            ch=Console.ReadLine().ToCharArray();

            foreach (char item in ch)
            {
                Console.WriteLine("{0}  ",item);
            }
            Console.ReadLine();    
        }
    }
}


