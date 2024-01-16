using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_IO
{
    internal class Program
    {
        public void WriteData()
        {
            FileStream fs=new FileStream(@"D:\BinaryFormat.dat",FileMode.Create,FileAccess.Write);
            BinaryWriter bw=new BinaryWriter(fs);
            int num = 80;
            double d = 58.35;
            Boolean b=false;
            bw.Write(num);
            bw.Write(d);    
            bw.Write(b);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream(@"D:\BinaryFormat.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int num = br.ReadInt32();
            double d = br.ReadDouble();
            Boolean b = br.ReadBoolean();
            Console.WriteLine("{0} {1} {2}",num,d,b);
            br.Close();
            fs.Close();

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            // program.WriteData();
            program.ReadData();
            Console.Read();
        }
    }
}
