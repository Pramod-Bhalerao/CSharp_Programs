using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_By_Demo_1
{
    internal class Program
    {
        
        void increment(ref int num)
        { 
            num++;
        }

        void DoSum(int n1,int n2,out int sum,out int division)
        {
            sum=n1+n2;
            division=n1-n2;
        }

        static void Main(string[] args) 
        {
            int num =40;
            Program n=new Program();
            n.increment(ref num);
            Console.WriteLine(num);
            Console.Read();

            int s, d;
            n.DoSum(50,55,out s,out d);
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.Read();

            Console.ReadLine();
        }
    }
}
