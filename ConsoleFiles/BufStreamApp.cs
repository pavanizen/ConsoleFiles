using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFiles
{
    class BufStreamApp
    {
        static void Main()
        {
            using (FileStream fs = new FileStream("Hoo.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    Console.WriteLine("Length: {0}\tPosition: {1}", bs.Length, bs.Position);

                    for (int i = 0; i < 65; i++)
                    {
                        bs.WriteByte((byte)i);
                    }
                    Console.WriteLine("Length: {0}\tPosition: {1}", bs.Length, bs.Position);
                    byte[] ba = new byte[bs.Length];
                    bs.Position = 0;
                    
                    bs.Read(ba, 0, (int)bs.Length);
                    foreach (byte b in ba)
                    {
                        Console.Write("{0,-3}", b);
                    }

                    string s = "Foo";
                    for (int i = 0; i < 3; i++)
                    {
                        bs.WriteByte((byte)s[i]);
                    }
                    Console.WriteLine("\nLength: {0}\tPosition: {1}\t", bs.Length, bs.Position);

                    for (int i = 0; i < (256 - 67) + 1; i++)
                    {
                        bs.WriteByte((byte)i);
                    }
                    //byte[] bb = new byte[bs.Length];
                    //bs.Position = 0;
                    //bs.Read(bb, 0, (int)bs.Length);
                    //foreach (byte b in bb)
                    //{
                    //    Console.Write("{0,-3}", b);
                    //}

                    Console.WriteLine("\nLength: {0}\tPosition: {1}\t", bs.Length, bs.Position);
                }
            }
        }
    }
}
