using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParamDemo2
{
    internal class Program
    {
        void Swap(ref int x,ref int y)
        {
            /*int temp;
            temp = x;
            x = y;
            y = temp;
            *//*Console.WriteLine("Initial Value of x : " +x);
            Console.WriteLine("Initial value of y : " + y);
            int temp;
            temp = x;
            x = y;
            y = temp;

            Console.WriteLine("After Swap x value "+x);
            Console.WriteLine("After Swap Y value "+y);*/
            
        }
        void Display(params int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();    // Creating Object P
           
            /*p.Swap(12, 20);
            p.Swap(16, 80);
            p.Swap(112, 90);
            p.Swap(128, 200);
            p.Swap(1152, 2005);
            p.Swap(162, 2650);
            p.Swap(1792, 20586);
            Console.Read();*/

            /*int x = 213, y = 321;
            Console.WriteLine("Before Swapping X is : {0}", x);
            Console.WriteLine("Before Swapping Y is : {0}", y);
            Program p= new Program();
            p.Swap(ref x,ref y);
            Console.WriteLine("After Swapping X is : {0}", x);
            Console.WriteLine("After Swapping Y is : {0}", y);
            Console.ReadLine();*/

            int[] Number= { 187, 2555, 583 };       // Using Array 
            int[] Number2 = { 45454, 5454, 21, 5454, 4, 2121, 88, };
            p.Display(Number);
            p.Display(Number2);
            Console.WriteLine();
            p.Display(12, 23, 2, 3, 5, 58, 78);     // Calling main method using params In Parameter
            Console.Read();
        }
    }
}
