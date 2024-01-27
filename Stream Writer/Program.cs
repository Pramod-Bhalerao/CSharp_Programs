using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Writer
{
    internal class Program
    {
        public void WriteData()
        {
            FileStream fs = new FileStream(@"D:\Kai Pan.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(" Me : Hello How Are You");
            sw.WriteLine(" Bhau : Fine.. & You?");
            sw.WriteLine(" Me : I'm Just Practising coding");
            sw.WriteLine(" Bhau : Nice..");
            sw.WriteLine("End");
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            Program KO = new Program();
            KO.WriteData();

            Console.Read();
        }
    }
}
