using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Demo
{
    /*struct student
    {
        public string Name;
        public int rollNo;
        public int Age;
    }*/
    internal class Program
    {
        struct student
        {
            public string Name;
            public int rollNo;
            public int Age;
        }
        static void Main(string[] args)
        {
            student S= new student();
            S.Name = "MrPoms";
            S.rollNo = 5;
            S.Age = 22;

            Console.WriteLine(S.Name);
            Console.WriteLine(S.rollNo);
            Console.WriteLine(S.Age);

            Console.Read();
        }
    }
}
