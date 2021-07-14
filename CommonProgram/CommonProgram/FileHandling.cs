using System;
using System.IO;
using System.Text;

public class FileHandling
{
    public static string path = "D:\\Temp\\MyFile";

    public FileHandling()
    {
        Console.WriteLine("cuns call");
    }

    public void CreateDir()
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory created on path " + path);
        }
        else
        {
            Console.WriteLine("Directory already exists " + path);
        }
    }

    public void CreateFile()
    {
        string filepath = path + "\\data.txt";

        using (FileStream fs = File.Create(filepath))
        {
            byte[] info = new UTF8Encoding(true).GetBytes("My name is vishal singh");
            fs.Write(info);
        }

       using(StreamReader sr = File.OpenText(filepath))
        {
            string s = "";

            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
