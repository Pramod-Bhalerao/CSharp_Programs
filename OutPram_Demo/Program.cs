using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  OutParamDemo1
{
    internal class Program
    {
        void Demo(out int i)
        {
            i = 60;
        }
        static void Main(string[] args)
        {
            int i;
            Program D = new Program();
            D.Demo(out i);
            Console.WriteLine(i);
        }
    }
}
