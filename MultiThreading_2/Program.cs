using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_1
{
    internal class Program
    {
        public void Display1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Good Morning", i);
                Thread.Sleep(2000);
            }
        }

        public void Display2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Good Night", i);
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Program K = new Program();
            ThreadStart ts1 = new ThreadStart(K.Display1);
            Thread Th1 = new Thread(ts1);

            ThreadStart ts2 = new ThreadStart(K.Display2);
            Thread Th2 = new Thread(ts2);

            Th1.Start();
            Th2.Start();

            Console.Read();
        }
    }
}
