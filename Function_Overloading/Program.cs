using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{ 
    internal class Program
    { 
        public int Sum(int x,int y )
        {
            Console.WriteLine("Function With Two Parameter");
            return(x + y);
        }
        public int Sum(int x, int y,int z)
        {
            Console.WriteLine("Function With Two Parameter");
            return (x + y + z);
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Sum(20,30);
            program.Sum(20, 30, 40);

            Console.Read();
        }
    }
}
