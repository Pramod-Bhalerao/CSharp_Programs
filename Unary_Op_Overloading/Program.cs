using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_Op_Overloading
{
    internal class Program
    {
        int num;

        public Program(int n) 
        {
            num = n;
        }    
        public void Dispaly()
        {
            Console.WriteLine(num);
        }
        public static Program operator ++(Program obj)
        {
            obj.num=
        
        }



        static void Main(string[] args)
        {
            Program P1 = new Program();
            Program P2 = P1++;
        }
    }
}
