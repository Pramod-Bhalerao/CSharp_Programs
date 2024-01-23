using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj_LifeCycle
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor Called");
        }
        ~Program()
        {
            Console.WriteLine("Destructor Called");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Program P1 = new Program();
            {
                Console.WriteLine("Block started");
                Program P2 = new Program();
                Console.WriteLine("Block Ended");
            }
            Console.WriteLine("Main Ended");
            Console.Read();
        }

            
    }
}
