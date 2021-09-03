using System;
using System.IO;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllFiles(@"D:\\");
            Console.ReadLine();
        }

        private static void GetAllFiles(string sDir)
        {
            foreach (var dir in Directory.GetDirectories(sDir))
            {
                try
                {
                    foreach (var file in Directory.GetFiles(dir, "*.MP3" ))
                    {
                        string mp3File = Path.GetFileName(file);
                        Console.WriteLine(mp3File);
                    }
                    //Recursive
                    GetAllFiles(dir);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
