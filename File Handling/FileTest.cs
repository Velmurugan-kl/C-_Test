using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class FileTest
    {
        public static void RunTest1()
        {
            using FileStream filetest = new FileStream(@"C:\Users\velmo\source\repos\MVC_Learn\File Handling\MyTest.txt", FileMode.OpenOrCreate);
            //using var filetest = FileTest.filetest;
            List<String> list = new List<String> { "qwe", "qedwdwr", "qzwefd", " qwec35g3w4gkf vv;oibj;osrijgwl4iuutf" };
            Console.WriteLine($"Can write into the file : {filetest.CanWrite}");
            Console.WriteLine($"Can read the file : {filetest.CanRead}");
            Console.WriteLine($"Length : {filetest.Length}");

            filetest.Seek(0, SeekOrigin.End);
            UnicodeEncoding uni = new UnicodeEncoding();
            string str = "\r\nThis is the testw line to write into the file";
            filetest.Write(uni.GetBytes(str), 10, uni.GetByteCount(str) - 10);
            //filetest.Write(list);

            //filetest.SetLength(100);
            //Console.WriteLine($"Pointer Position : { filetest.Position}");
            //Console.WriteLine((char)filetest.ReadByte());
            //filetest.Seek(0, SeekOrigin.End);
            //Console.WriteLine($"Pointer Position : { filetest.Position}");
            //Console.WriteLine((char)filetest.ReadByte());
            //filetest.Seek(-3, SeekOrigin.End);
            //filetest.WriteByte(96);
            //Console.WriteLine($"Can write into the file : {filetest.CanWrite}");
            //while (filetest.Position < filetest.Length)
            //{
            //    int ch = filetest.ReadByte();
            //Console.Write((char)ch);
            //}
            //Console.WriteLine("position");
            //Console.WriteLine(filetest.Position);
            //filetest.Position = 0;
            //Console.WriteLine(filetest.Position);
            //Console.ReadKey();
        }
        public void Test2Write()
        {
            List<List<string>> li = new List<List<string>> { 
            new List<string>{"asd","fgh","qwe"},
            new List<string>{"123","456","789"}
            };
            FileStream fs = new FileStream(@"C:\Users\velmo\source\repos\MVC_Learn\File Handling\MyTest.csv", FileMode.OpenOrCreate);
            using StreamWriter testw = new StreamWriter(fs);
            foreach (List<string> li2 in li)
            {
                string str = string.Join(",", li2);
                testw.WriteLine(str);
                //Console.WriteLine(str);
            }

            

        }
        public void Test2Read()
        {
            List<List<string>> list = new List<List<string>>();
            FileStream fs = new FileStream(@"C:\Users\velmo\source\repos\MVC_Learn\File Handling\MyTest.txt", FileMode.OpenOrCreate);
            
            using StreamReader testr = new StreamReader(fs);
            Console.WriteLine("File content");
            while (testr.Peek() != -1)
            {
                string str = testr.ReadLine();
                List<string> li = new List<string>(str.Split(","));
                list.Add(li);
                Console.WriteLine(str);
            }
            foreach(List<string> li in list)
            {
                foreach(string str in li)
                {
                    Console.Write($"{str} ");
                }
                Console.WriteLine();
            }
        }

    }
}
