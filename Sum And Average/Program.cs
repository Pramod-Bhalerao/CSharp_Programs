using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_And_Average
{
    internal class Program
    {
        public int i;
        public void add(int b) { 
            int res =  b+b;
        }
        public void avg(int b)
        {
            int res = b + b;
        }
        public void print() { 
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;

            Console.WriteLine("Enter First Number");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fourth Number");
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fifth Number");
            n5 = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.add(n1);
            p.add(n2);
            p.avg();
            p.print();
            int s = n1 + n2 + n3 + n4 + n5;
            float avg = s / 5;

            Console.WriteLine("The Sum is: {0}",  s);
            Console.WriteLine("The Average is: {0}", avg);

            Console.ReadLine();

        }
    }
}