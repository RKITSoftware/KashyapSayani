using System;

namespace ConsoleAppScopAndAccessibilityModifiersDemo
{
    class AccessModifiers
    {
        // Constructor For AccessModifier Class
        public AccessModifiers(int number1,int number2,int number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
            // Calling Sum Method
            sum();
        }

        // public -> There are no restrictions on accessing public members.
        public int number1;

        // private -> Access is limited to within the class definition. This is the default access modifier type if none is formally specified.
        private int number2;

        // protected -> Access is limited to within the class definition and any class that inherits from the class.
        protected int number3;

        // Method For Addition Of Three Numbers
        public void sum()
        {
            // Adding Three Numbers
            int sum = number1 + number2 + number3;
            // Print Sum Of Three Numbers
            Console.WriteLine("Sum Is : {0} ",sum);
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Object Of AccessModifier Class
            AccessModifiers objAccess = new AccessModifiers(34,56,12);

            // Printing number1
            Console.WriteLine("Number 1 : "+objAccess.number1);

            /* We Can Not Access number2 variable outside the class
               Console.WriteLine(objAccess.number2);
               We Can Not Access number2 variable outside the class or without inheritance
               Console.WriteLine(objAccess.number3); 
            */
        }
    }
}