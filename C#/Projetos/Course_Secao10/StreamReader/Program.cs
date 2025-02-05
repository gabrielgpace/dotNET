﻿using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string path = @"c:\temp\file1.txt";
        FileStream fs= null;
        StreamReader sr = null;
        try{
            fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
            sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch(IOException e) {
            Console.WriteLine("Anerroroccurred");
            Console.WriteLine(e.Message);
        }
        finally {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
    }
}