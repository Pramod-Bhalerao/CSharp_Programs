using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Desending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];


            for(int i=0;i<5;i++)
            {   
                Console.WriteLine("Enter A number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<4; i++)
            {
                for(int j=i+1; j<5; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Read();

        }
    }
}
