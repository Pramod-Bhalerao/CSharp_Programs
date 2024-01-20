using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    internal class Program
    {
        String name,email;
        int phoneno;

        void Assign()
        {
            Console.WriteLine("Enter Your Name");
            name= Console.ReadLine();
            Console.WriteLine("Enter Your Email");
            email= Console.ReadLine();
            Console.WriteLine("Enter Your Contact Details");
            phoneno=Convert.ToInt32(Console.ReadLine());
        }
        void Print()
        {
            Console.WriteLine("{0}",name);
            Console.WriteLine("{0}", email);
            Console.WriteLine("{0}", phoneno);
        }
        static void Main(string[] args)
        {
            Program Poms = new Program();
            Poms.Assign();
            Poms.Print();
            Console.Read();
        }
    }
}


