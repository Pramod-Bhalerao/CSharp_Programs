using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_Variable
{
    internal class Program
    {
        int Num1, Num2, Total;

        Program()  // Constructor 
        {
            Num1 = 250;
            Num2 = 150;
        }

        void Add()
        {
            Total = Num1 + Num2;
        }

        void Display()
        {
            Console.WriteLine("The Total is :{0}",Total);
        }

        static void Main(string[] args)
        {
            Program P1=new Program();
            P1.Add();
            P1.Display();
            Console.Read();
        }
        
    }
}
