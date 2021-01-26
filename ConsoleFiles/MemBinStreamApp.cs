using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConsoleFiles
{
    class MemBinStreamApp
    {
        static void Main()
        {
            var t1 = Stopwatch.StartNew();
            // Use BufferedStream to buffer writes to a MemoryStream.
            using (MemoryStream memory = new MemoryStream())
            using (BufferedStream stream = new BufferedStream(memory))
            {
                // Write a byte 5 million times.
                for (int i = 0; i < 5000000; i++)
                {
                    stream.WriteByte(5);
                }
            }
            t1.Stop();
            Console.WriteLine("BUFFEREDSTREAM TIME: " + t1.Elapsed.TotalMilliseconds);
        }
    }
}
    

