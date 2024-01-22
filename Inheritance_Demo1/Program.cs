using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo1
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Constructor Of Animal");
        }
        ~Animal()
        {
            Console.WriteLine("Destructor Of Animal");
        }
    }
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Constructor Of cat");
        }
        ~Cat() 
        {
            Console.WriteLine("Destructor Of cat");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Obj=new Cat();
            Console.Read();


        }
    }
}
