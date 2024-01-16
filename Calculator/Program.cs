using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        int Num1;
        int Num2;
        int Result;

        void Add()
        {
            Result=Num1+Num2;   
            Console.WriteLine(Result);
            Console.Read();
        }

        void Substract()
        {
            Result = Num1 - Num2;
            Console.WriteLine(Result);
            Console.Read();
        }
        void Multiplication()
        {
            Result = Num1 * Num2;
            Console.WriteLine(Result);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.Num1 = 45;
            obj.Num2 = 80;
            obj.Add();
            obj.Substract();
            obj.Multiplication();
            Console.Read();
        }
    }
}
            
