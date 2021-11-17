using System;
using System.IO;

namespace assignment5 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string writeText = "Have a wonderful day ( ͡❛ ͜ʖ ͡❛) ᕙ(`▿´)ᕗ "; //if old version is same as new, it will look the same. Change text.
            File.WriteAllText("D:\\testfile.txt", writeText);

            if (File.Exists("testfile.txt"))
            {
                File.Delete("D:\\testfile.txt");
            }

            string readText = File.ReadAllText("D:\\testfile.txt");
            Console.Write(readText);
            Console.WriteLine("\n");
            Console.WriteLine("Testfile worked, its under testfile.txt ");
         
            Console.ReadKey();

        }
    }
}