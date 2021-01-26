using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFiles
{
    class UsingFiles
    {
        static void Main()
        {
            string data = null;
            string v = null;
            while (data != "!")
            {
                Console.WriteLine("Please Enter the contents of the file");
                data = Console.ReadLine();


                if (data != "!")
                {
                    v = v + data;
                }



            }
            using (FileStream fs= new FileStream("Pavani.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using(StreamWriter sw=new StreamWriter(fs))
                {
                    sw.WriteLine(v);
                    sw.WriteLine("Contents of the File in StreamWriter");
                    sw.WriteLine("Hello Everyone");

                }
            }
            using(FileStream fs1=new FileStream("Pavani.txt",FileMode.Open))
            {
                using(StreamReader sr=new StreamReader(fs1))
                {
                    Console.WriteLine("Displaying the contents of the File\n"+sr.ReadToEnd());
                }
            }

        }
    }
}
