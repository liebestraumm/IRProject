using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IR_project
{
    class FileReader
    {
        public void t()
        {
            string path =  @"C:\temp\TextFiles\Activity5\AlicePara.txt";
            // SOLUTION 2
            System.IO.TextReader reader2 = new System.IO.StreamReader(path);
            string line = "";
            while ((line = reader2.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }
            reader2.Close();

            System.Console.WriteLine(Console.ReadLine());

        }


        public string ReadFile(string path) {
            System.IO.TextReader reader = new System.IO.StreamReader(path);
            return reader.ReadToEnd();
        }

        public System.IO.FileInfo[] GetDirFiles(string path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;

            // First, process all the files directly under this folder 
            try
            {
                files = root.GetFiles("*.*");
            }

            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            return files;
        }
    }
}
