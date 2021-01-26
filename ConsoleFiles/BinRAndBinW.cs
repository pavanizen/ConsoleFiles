using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFiles
{
    class BinRAndBinW
    {
        static void Main()
        {
           
            

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(@"e:\mydata.txt", FileMode.Create)))
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            using (BinaryReader br = new BinaryReader(new FileStream(@"e:\mydata.txt", FileMode.Open)))
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            Console.ReadLine();
        }
    }
}
