using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j, flag = 0;
            char[] arr;

            Console.WriteLine("Enter A String");
            arr=Console.ReadLine().ToCharArray();
            j=arr.Length-1;

            while(i<=j)
            {
                if (arr[i] == arr[j])
                {
                    i++;
                    j--;
                }

                else
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Entered String Is A Palindrome");

            }
            else
            {
                Console.WriteLine("Entered String Is Not A Palindrome");
            }
            Console.ReadLine(); 
        }
    }
}




