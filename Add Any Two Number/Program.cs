using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Any_Two_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter The First Number");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum=num1+num2;

            Console.WriteLine("Addition is : {0}", sum);

            Console.ReadLine();
        }
    }
}
