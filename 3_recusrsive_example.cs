using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class _3_recusrsive_example
    {

        //to read the files present in the directory and its sub directy and so on -----
        public static void FindFiles(string path)
        {
            foreach (string fileName in Directory.GetFiles("path"))
            {
                Console.WriteLine(fileName);            
            }
            foreach (string directory in Directory.GetDirectories("path"))
            {
                FindFiles(directory);
            }
        }
    }
}
