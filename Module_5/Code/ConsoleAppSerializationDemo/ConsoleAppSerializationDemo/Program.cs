using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppSerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path of file
            string path = @"C:\Users\91940\Desktop\RKIT\Module-5\serial.txt";

            // Create a object of student class
            Student objStudent = new Student(1, "Kashyap");

            // Making or Opening a file 
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            // Create a object of BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Do Serialization
            formatter.Serialize(stream, objStudent);
            stream.Close();

            // Print the messege
            Console.WriteLine("File Saved In : " + path);
            Console.ReadLine();

            /*//Making or Opening a file 
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //Create a object of BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            //Do Desrerialization
            Student stus = (Student)formatter.Deserialize(stream);

            //Print the messege
            Console.WriteLine("Id : " + stus.id);
            Console.WriteLine("Name : " + stus.name);*/


        }
    }
}
