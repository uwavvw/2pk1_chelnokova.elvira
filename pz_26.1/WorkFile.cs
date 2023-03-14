using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace pz_26._1
{
    static class WorkFile
    {
        static string path = @"C:\Users\эля\source\repos\2pk1_chelnokova.elvira\pz_26.1\data";
        public static void CreateFile()
        {
            
            File.Create(path);
        }
        public static void SaveFile()
        {

        }
        public static void OpenFile()
        {

        }
        public static void DeleteFile()
        {
            File.Delete(path);
        }
    }
}
