using System;
using System.IO;

namespace ConsoleAppBasicFileOperationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\91940\Desktop\RKIT\Module-4\ConsoleAppBasicFileOperationDemo\File.txt";
            string destinationFile = @"C:\Users\91940\Desktop\RKIT\Module-4\ConsoleAppBasicFileOperationDemo\FileCopy.txt";
            string MovedPath = @"C:\Users\91940\Desktop\RKIT\Module-4\ConsoleAppBasicFileOperationDemo\ConsoleAppBasicFileOperationDemo\obj\FileCopy.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Geeks");
                    sw.WriteLine("For");
                    sw.WriteLine("Geeks");
                }
            }

            //Append new string to the file
            //Environment.NewLine is used to add newline
            string appendText = "This is the best website." + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                //check availability of file
                if (File.Exists(path))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist!");
                }
            }

            // Copy Operation
            try
            {
                File.Copy(path, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            // Move Operation
            try
            {
                // Moving the file file.txt to location C:\gfg.txt
                File.Move(path, MovedPath);
                Console.WriteLine("Moved");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

            // Delete Operation
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(MovedPath))
                {
                    // If file found, delete it    
                    File.Delete(MovedPath);
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
 
        }
    }
}