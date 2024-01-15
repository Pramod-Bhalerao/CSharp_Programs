using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Methods Of ArrayList :- 
                    1 Add
                    2 Remove
                    3 Clear
                    4 Insert
                    5 TrimToSize
                    6 Sort
                    7 Reverse*/

            ArrayList array = new ArrayList();
            array.Add(121);
            array.Add("Mr Poms");
            array.Add(255.30);
            array.Add('A');
            array.Add("EDUCATION IS IMPORTANT");

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            array.Remove("Mr Poms");

            Console.WriteLine("_________________________");

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            array.Clear();
            Console.Read();
        }
    }
}
