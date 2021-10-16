using System;

namespace ConsoleAppStringClassDemo
{
    class StringClassDemo
    {
        public static string World { get; private set; }

        static void cloneMethodInStringClass()
        {
            string s1 = "GeeksForgeeks";

            // Cannot implicitly convert 
            // type object to the string.
            // So explicit conversion 
            // using Clone() method
            string s2 = (String)s1.Clone();

            // Displaying both the string
            Console.WriteLine("String : {0}", s1);
            Console.WriteLine("Clone String : {0}", s2);
        }

        static void compareToMethodInStringClass()
        {
            // string type
            String str = "GeeksforGeeks";
            String substr1 = "for";
            String substr2 = "For";

            // using String.Contains() Method
            Console.WriteLine(str.Contains(substr1));
  
            // Here case-sensitive comparison
            // And substr2 value is 'For'
            // So its return false
            Console.WriteLine(str.Contains(substr2));
        }

        static void manyOtherMethodOfStringClass()
        {
            // Concat()
            Console.WriteLine("Concat Method");
            string a = "Hello";
            string b = "World";
            Console.WriteLine(string.Concat(a, b));

            // Contains()
            Console.WriteLine("Contains Method");
            string c = "HelloWorld";
            string d = "World";
            Console.WriteLine(c.Contains(d));

            // Copy( )
            Console.WriteLine("Copy Method");
            string e = "Hello";
            string f = string.Copy(e);
            Console.WriteLine(f);

            // Equals( )
            Console.WriteLine("Copy Method");
            string g = "Hello";
            string h = "World";
            Console.WriteLine(g.Equals(h));

            // IndexOf()
            Console.WriteLine("IndexOf Method");
            string i = "Hello";
            int j = i.IndexOf('o');
            Console.WriteLine(j);

            // Insert()
            Console.WriteLine("Insert Method");
            string k = "Hello";
            string l = a.Insert(2, "_World_");
            Console.WriteLine(l);

            // Replace( )
            Console.WriteLine("Replace Method");
            string m = "Hello";
            string n = m.Replace("lo", "World");
            Console.WriteLine(n);

            // SubString( )
            Console.WriteLine("SubString Method");
            string o = "Hello";
            string p = o.Substring(2);
            Console.WriteLine(p);

            // Trim( )
            Console.WriteLine("Trim Method");
            string q = "    Hello ";
            string r = q.Trim();
            Console.WriteLine(r);
        }


        static void Main(string[] args)
        {

            /* C# program to demonstrate the creation
               of string using the constructor */
            char[] chars = { 'G', 'E', 'E', 'K', 'S' };

            // Create a string from a character array.
            string str1 = new string(chars);
            Console.WriteLine(str1);

            /* Create a string that consists of
              a character repeated 5 times. */
            string str2 = new string('E', 5);
            Console.WriteLine(str2);


            /* C# program to demonstrate the
               String Class Properties */
            string str = "GeeksforGeeks";

            // using Chars[Int32] & Length property
            for (int i = 0; i <= str.Length - 1; i++)
            {
                Console.Write("{0} ", str[i]);
            }

            /* C# program to illustrate the
               Equality and Inequality operator */
            string s1 = "WelcomeToGeeks";
            string s2 = "WelcomeToGeeks";
            bool result1, result2;

            // Equality operator return true
            // as both string are equal
            result1 = s1 == s2;

            // Inequality operator return false
            // as both string are equal
            result2 = s1 != s2;

            Console.WriteLine("\n"+result1);
            Console.WriteLine(result2);

            // Call Method cloneMethodInStringClass
            cloneMethodInStringClass();

            // Call Method compareToMethodInStringClass
            compareToMethodInStringClass();

            // Call Method manyOtherMethodOfStringClass
            manyOtherMethodOfStringClass();
        }

    }

}


