using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw20
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------1
            Console.WriteLine("//--------1");
            string folderName = @"c:\temp";

            string pathString1 = Path.Combine(folderName, "K1");
            string pathString2 = Path.Combine(folderName, "K2");
            Directory.CreateDirectory(pathString1);
            Directory.CreateDirectory(pathString2);
            //--------2
            Console.WriteLine("\n\n//--------2");
            string fileName1 = "t1.txt";
            string fileName2 = "t2.txt";
            string fileName3 = "t3.txt";

            string text1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов";
            string text2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";

            string fullPathToFile1 = Path.Combine(pathString1, fileName1);
            string fullPathToFile2 = Path.Combine(pathString1, fileName2);
            string fullPathToFile3 = Path.Combine(pathString2, fileName3);
            File.WriteAllText(fullPathToFile1, text1);

            StreamWriter file2 = new StreamWriter(fullPathToFile2);
            file2.WriteLine(text2);
            file2.Close();

            //--------3
            Console.WriteLine("\n\n//--------3");
            StreamReader file3read = new StreamReader(fullPathToFile1);
            StreamReader file3read2 = new StreamReader(fullPathToFile2);
            StreamWriter file3write = new StreamWriter(fullPathToFile3);
            file3write.WriteLine(file3read.ReadLine());
            file3read.Close();
            file3write.WriteLine(file3read2.ReadLine());
            file3read2.Close();
            file3write.Close();

            //--------4
            Console.WriteLine("\n\n//--------4");
            FileInfo fileInfo1 = new FileInfo(fullPathToFile1);
            Console.WriteLine("FullName: " + fileInfo1.FullName);
            Console.WriteLine("Length: " + fileInfo1.Length);
            Console.WriteLine("Name: " + fileInfo1.Name);
            Console.WriteLine("DirectoryName: " + fileInfo1.DirectoryName);
            Console.WriteLine("CreationTime: " + fileInfo1.CreationTime);
            Console.WriteLine("-------------------------------------------");

            FileInfo fileInfo2 = new FileInfo(fullPathToFile2);
            Console.WriteLine("FullName: " + fileInfo2.FullName);
            Console.WriteLine("Length: " + fileInfo2.Length);
            Console.WriteLine("Name: " + fileInfo2.Name);
            Console.WriteLine("DirectoryName: " + fileInfo2.DirectoryName);
            Console.WriteLine("CreationTime: " + fileInfo2.CreationTime);
            Console.WriteLine("-------------------------------------------");

            FileInfo fileInfo3 = new FileInfo(fullPathToFile3);
            Console.WriteLine("FullName: " + fileInfo3.FullName);
            Console.WriteLine("Length: " + fileInfo3.Length);
            Console.WriteLine("Name: " + fileInfo3.Name);
            Console.WriteLine("DirectoryName: " + fileInfo3.DirectoryName);
            Console.WriteLine("CreationTime: " + fileInfo3.CreationTime);
            Console.WriteLine("-------------------------------------------");

            DirectoryInfo dInfo1 = new DirectoryInfo(pathString1);
            Console.WriteLine("FullName: " + dInfo1.FullName);
            Console.WriteLine("Name: " + dInfo1.Name);
            Console.WriteLine("Parent: " + dInfo1.Parent);
            Console.WriteLine("Exists: " + dInfo1.Exists);
            Console.WriteLine("Attributes: " + dInfo1.Attributes);
            Console.WriteLine("Root: " + dInfo1.Root);
            Console.WriteLine("CreationTime: " + dInfo1.CreationTime);
            Console.WriteLine("-------------------------------------------");

            DirectoryInfo dInfo2 = new DirectoryInfo(pathString2);
            Console.WriteLine("FullName: " + dInfo2.FullName);
            Console.WriteLine("Name: " + dInfo2.Name);
            Console.WriteLine("Parent: " + dInfo2.Parent);
            Console.WriteLine("Exists: " + dInfo2.Exists);
            Console.WriteLine("Attributes: " + dInfo2.Attributes);
            Console.WriteLine("Root: " + dInfo2.Root);
            Console.WriteLine("CreationTime: " + dInfo2.CreationTime);
            //Console.WriteLine("CreationTime: " + dInfo2.EnumerateFiles);
            Console.WriteLine("-------------------------------------------");

            //--------5
            Console.WriteLine("\n\n//--------5");
            fileInfo2.MoveTo((pathString2 + "\\" + fileName2));

            //--------6
            Console.WriteLine("\n\n//--------6");
            fileInfo1.CopyTo(pathString2 + "\\" + fileName1);

            //--------7
            Console.WriteLine("\n\n//--------7");
            string newPath = Path.Combine(folderName, "ALL");
            if (dInfo2.Exists && Directory.Exists(newPath) == false)
            {
                dInfo2.MoveTo(newPath);
            }

            FileInfo F1 = new FileInfo(fullPathToFile1);
            F1.Delete();
            dInfo1.Delete();

            //--------8
            Console.WriteLine("\n\n//--------8");
            DirectoryInfo all = new DirectoryInfo(newPath);
            var allFile = all.GetFiles();
            foreach (var item in allFile)
            {
                Console.WriteLine("FullName: " + item.FullName);
                Console.WriteLine("Length: " + item.Length);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("DirectoryName: " + item.DirectoryName);
                Console.WriteLine("CreationTime: " + item.CreationTime);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
