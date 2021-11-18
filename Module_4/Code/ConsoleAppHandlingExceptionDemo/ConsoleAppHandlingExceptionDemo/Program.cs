using System;
using System.Collections.Generic;

namespace ConsoleAppHandlingExceptionDemo
{

    public class TempIsZeroException : Exception
    {
        //constructor for TempIsZeroException
        public TempIsZeroException(string message) : base(message)
        {
        }
    }

    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temprature Found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }

    class Program
    {
        // local variable
        int result;

        // constructor
        Program()
        {
            result = 0;
        }

        // method for division
        public void division(int num1, int num2)
        {
            // try block
            try
            {
                result = num1 / num2;
            }
            // catch block 
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }

            // finally block
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        // main mathod
        static void Main(string[] args)
        {
            // creating object to demostrate exception handling of class DivideByZeroException
            Program objPro = new Program();

            // call method name division
            objPro.division(25, 0);

            Console.WriteLine();

            //creating object to demostrate exception handling of user difine class TempIsZeroException
            Temperature temp = new Temperature();

            // try block
            try
            {
                // call method name showTemp
                temp.showTemp();
            }
            // catch block
            catch (TempIsZeroException e)
            {
                // write message to display exception message
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }

            Console.WriteLine();

            // C# program that throws KeyNotFoundException
            try
            {
                // Create new Dictionary with string key of "one"
                Dictionary<string, string> test = new Dictionary<string, string>();
                test.Add("one", "value");
                
                // Try to access key of "two"
                string value = test["two"];
            }
            catch (Exception ex)
            {
                // An exception will be thrown.
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
