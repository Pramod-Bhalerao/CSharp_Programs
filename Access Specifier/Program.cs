using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifier
{
    internal class Program
    {
        int num;
        static int cnt;

        /*public static void Add()
        {
            cnt++;
        }*/

        void increment()
        {
            num++;
            cnt++;
            cnt++;
        }
        void display()
        {
            Console.WriteLine("num={0}   cnt={1}", num, cnt);
        }

        static void Main(string[] args)
        {
            Program Y1=new Program();
            Y1.increment();
            Y1.display();

            Program Y2 = new Program();
            Y2.increment();
            Y2.display();

            // Add();
            

            Console.Read();
        }
    }
}
