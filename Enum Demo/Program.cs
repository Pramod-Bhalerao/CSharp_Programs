using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Demo
{
    internal class Program
    {
        enum Week{ Monday=91,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}  // Value Start With 0 
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", (int)Week.Monday);
            Console.WriteLine("{0}", (int)Week.Tuesday);
            Console.WriteLine("{0}", (int)Week.Wednesday);
            Console.WriteLine("{0}", (int)Week.Thursday);
            Console.WriteLine("{0}", (int)Week.Friday);
            Console.WriteLine("{0}", (int)Week.Saturday);
            Console.WriteLine("{0}", (int)Week.Sunday);
            Console.Read();
        }
    }
}
