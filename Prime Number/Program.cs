using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0,num = 1, flag = 0;
            while (cnt < 10)
            {
                num++;
                flag = 0;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("{0}  ", num);
                    cnt++;
                }
                Console.ReadLine();
            }
        }
    }
}


