using System;

namespace ConsoleAppMethodDemo
{
    class MethodDemo
    {
        String MethodName = "";

        // Default Parameter Value Or Optional Parameter
        static void MyMethod1(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        // Multiple Parameters & Passing Value Type Variables
        static void MyMethod2(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // Method With Return Values & Passing Value Type Variables
        static int MyMethod3(int x)
        {
            return 5 + x;
        }


        // Method With Refrence Type Argument
        static void ChangeReferenceType(MethodDemo method)
        {
            method.MethodName = "MyMthod1";
        }

        static void Main(string[] args)
        {
            // Call MyMethod1
            Console.WriteLine("Call Method1\n");
            MyMethod1("Sweden");
            MyMethod1("India");
            MyMethod1();
            MyMethod1("USA");

            // Call MyMethod2
            Console.WriteLine("\nCall Method2\n");
            MyMethod2("Liam", 5);
            MyMethod2("Jenny", 8);
            MyMethod2("Anja", 31);

            // Call MyMethod3
            Console.WriteLine("\nCall Method3\n");
            Console.WriteLine("Addition IS : " + MyMethod3(3));

            // Call MyMethod4
            Console.WriteLine("\nCall Method4\n");
            MethodDemo objStd1 = new MethodDemo();
            objStd1.MethodName = "XyzMethod";

            ChangeReferenceType(objStd1);

            Console.WriteLine("Method Name : " + objStd1.MethodName);
        }
    }
}