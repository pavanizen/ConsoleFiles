using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
namespace ConsoleFiles
{
    class MemStreamApp
    {
        static void Main()
        {
            var t1 = Stopwatch.StartNew();
            // Use MemoryStream directly with no buffering.
            using (MemoryStream memory = new MemoryStream())
            {
                // Write a byte 5 million times.
                for (int i = 0; i < 5000000; i++)
                {
                    memory.WriteByte(5);
                }
            }
            t1.Stop();
            Console.WriteLine("MEMORYSTREAM TIME: " + t1.Elapsed.TotalMilliseconds);
        }
    }
}
