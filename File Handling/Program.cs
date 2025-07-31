using System.Text;

namespace File_Handling
{
    internal class Program
    {
        //public static void Main()
        //{
        //    string path = @"C:\Users\velmo\source\repos\MVC_Learn\File Handling\MyTest.txt";

        //    // Delete the file if it exists.
        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //    }

        //    //Create the file.
        //    using (FileStream fs = File.Create(path))
        //    {
        //        AddText(fs, "This is some text");
        //        AddText(fs, "This is some more text,");
        //        AddText(fs, "\r\nand this is on a new line");
        //        AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

        //        for (int i = 1; i < 120; i++)
        //        {
        //            AddText(fs, Convert.ToChar(i).ToString());
        //        }
        //    }

        //    //Open the stream and read it back.
        //    using (FileStream fs = File.OpenRead(path))
        //    {
        //        byte[] b = new byte[1024];
        //        UTF8Encoding temp = new UTF8Encoding(true);
        //        int readLen;
        //        while ((readLen = fs.Read(b, 0, b.Length)) > 0)
        //        {
        //            Console.WriteLine(temp.GetString(b, 0, readLen));
        //        }
        //    }
        //    Console.ReadKey();
        //}
        //private static void AddText(FileStream fs, string value)
        //{
        //    byte[] info = new UTF8Encoding(true).GetBytes(value);
        //    fs.Write(info, 0, info.Length);
        //}

        public static void Main(string[] args)
        {
            //using FileStream filetest = new FileStream(@"C:\Users\velmo\source\repos\MVC_Learn\File Handling\MyTest.txt", FileMode.OpenOrCreate);
            ////filetest.SetLength(100);
            //Console.WriteLine($"Can write into the file : {filetest.CanWrite}");
            //Console.WriteLine($"Can read the file : {filetest.CanRead}");
            //Console.WriteLine($"Length : {filetest.Length}");
            //Console.WriteLine($"Pointer Position : { filetest.Position}");
            //Console.WriteLine((char)filetest.ReadByte());
            //filetest.Seek(0, SeekOrigin.End);
            //Console.WriteLine($"Pointer Position : { filetest.Position}");
            //Console.WriteLine((char)filetest.ReadByte());
            //filetest.Seek(-3, SeekOrigin.End);
            //filetest.WriteByte(96);
            //Console.WriteLine($"Can write into the file : {filetest.CanWrite}");
            //filetest.Seek(0, SeekOrigin.End);
            //UnicodeEncoding uni = new UnicodeEncoding();
            //string str = "\r\nThis is the test line to write into the file";
            //filetest.Write(uni.GetBytes(str), 10, uni.GetByteCount(str)-10);
            //while (filetest.Position < filetest.Length)
            //{
            //    int ch = filetest.ReadByte();
            //Console.Write((char)ch);
            //}
            //Console.WriteLine("position");
            //Console.WriteLine(filetest.Position);
            //filetest.Position = 0;
            //Console.WriteLine(filetest.Position);
            FileTest ts = new FileTest();
            ts.Test2Write();
            //ts.Test2Read();
            Console.ReadKey();
        }
        
    }
}
