using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users";
            string subpath = @"эля\source\repos\2pk1_chelnokova.elvira\pz_15\pz_15\bin\Debug\new";
            string s;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            using (StreamReader sr = new StreamReader(@"C:\Users\эля\source\repos\2pk1_chelnokova.elvira\pz_15\pz_15\bin\Debug\f1.txt"))
            {
                s = sr.ReadToEnd();
            }
            using (StreamWriter sw = new StreamWriter(@"C:\Users\эля\source\repos\2pk1_chelnokova.elvira\pz_15\pz_15\bin\Debug\new\f2.txt", false, Encoding.Default))
            {
                sw.WriteLineAsync(s);
            }
             Console.ReadKey();
        }
    }
}
