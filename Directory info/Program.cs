using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_info
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\POMS");
            FileInfo[] arr = dir.GetFiles();

            foreach(FileInfo fi in arr) 
            {
                Console.WriteLine("{0}--------{1}-------{2}",fi.FullName,fi.CreationTime,fi.Directory);
            }

            Console.Read();

        }
    }
}
