using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{
    class AgeNotAllowed:Exception
    {
        public AgeNotAllowed(string s):base(s)
        {

        }
    }
    internal class Program
    {
        public void AcceptAge()
        {
            String Name;
            int Age;

            Console.WriteLine("** REGISTRATION **");

            Console.Write("Enter Your Name : ");
            Name= Console.ReadLine();   
            Console.Write("Enter Your Age : ");
            Age = Convert.ToInt32(Console.ReadLine());

            if(Age<20 ||  Age>40)
            {
                AgeNotAllowed Exp=new AgeNotAllowed("Age Between 20 & 40 is only allowed");
                throw Exp;
            }
            else
            {
                Console.WriteLine("Welcome");    
            }

        }
         
        static void Main(string[] args)
        {
            Program G = new Program();
            try
            {
                G.AcceptAge();
            }
            catch (AgeNotAllowed ex) 
            {
                Console.WriteLine("ex.message");
            }

            Console.Read();
            
        }
    }
}
