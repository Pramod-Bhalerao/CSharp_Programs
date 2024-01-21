using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");

            int num1, num2,r,Index;
            Console.WriteLine("Enter First Number");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Index Number");
            Index = Convert.ToInt32(Console.ReadLine());

            int[] arr=new int[8];
            try
            {
                r = num1 / num2;
                Console.WriteLine(r);
                arr[Index] = 50;
                Console.WriteLine(arr[Index]);
            }
            catch(DivideByZeroException e) 
            {
                Console.WriteLine("Can Not Divide By Zero");
            } 
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Number Is Not Correct");    
            }
            catch (Exception e) 
            {
                Console.WriteLine("Array Index");
            }
            Console.WriteLine("Main Ended");

            Console.ReadLine();
        }
    }
}

                
