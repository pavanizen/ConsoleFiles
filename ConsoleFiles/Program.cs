using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            string data=null;
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
                FileStream fs = new FileStream(@"e:\Example.txt",FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
               // StreamWriter sw1 = File.AppendText(data);
               
                try
                {
                    sw.WriteLine(v);
                    sw.WriteLine("We are writing in Example.txt using stream writer");
                    sw.WriteLine("Streamwriter is used to write stream data");

                    
                    


                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file cannot be found");

                }
                finally
                {
                    
                    sw.Close();
                    fs.Close();


                }

                FileStream fs1 = new FileStream(@"e:\Example.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs1);
                try
                {
                    Console.WriteLine("Reading Contents of Example.txt \n" + sr.ReadToEnd());
                Console.WriteLine("Completed Reading the file Contents");

                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File nOt found");
                }
                finally
                {

                    sr.Close();
                    fs1.Close();
                }
            
        }
    }
}
