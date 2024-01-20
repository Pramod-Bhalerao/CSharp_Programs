using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, mchoice, r;
            char ynchoice;

            do
            {
                Console.WriteLine("Enter The First Number");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Second Number");
                n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1: +");
                Console.WriteLine("2: -");
                Console.WriteLine("3: /");
                Console.WriteLine("4: *");
                Console.WriteLine("5: %");
                Console.WriteLine("6: EXIT");
                Console.WriteLine("Enter Your Choice From 1 TO 6");

                mchoice = Convert.ToInt32(Console.ReadLine());
                if (mchoice == 6)
                {
                    break;
                }
                else
                {
                    switch (mchoice)
                    {
                        case 1:
                            r = n1 + n2;
                            Console.WriteLine("Addition Is : {0}", r);
                            break;

                        case 2:
                            r = n1 - n2;
                            Console.WriteLine("Subtraction Is : {0}", r);
                            break;

                        case 3:
                            r = n1 / n2;
                            Console.WriteLine("Division Is : {0}", r);
                            break;

                        case 4:
                            r = n1 * n2;
                            Console.WriteLine("Multiplication Is : {0}", r);
                            break;

                        case 5:
                            r = n1 % n2;
                            Console.WriteLine("Remainder Is : {0}", r);
                            break;

                        default:
                            Console.WriteLine("Invalid Number Is Entered");
                            break;
                    }
                }
                Console.WriteLine("Do You Want To Continue..? (Y/N)");
                ynchoice = Convert.ToChar(Console.ReadLine());
            } while (ynchoice == 'Y' || ynchoice == 'Y');
        }
    }
}



