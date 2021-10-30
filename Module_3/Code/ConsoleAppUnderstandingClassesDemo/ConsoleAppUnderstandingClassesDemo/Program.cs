using System;

namespace ConsoleAppUnderstandingClassesDemo
{

    //
    class Event
    {
        //Raising an Event
        public delegate void Notify();  // delegate

        public class ProcessBusinessLogic
        {
            public event Notify ProcessCompleted; // event

            public void StartProcess()
            {
                Console.WriteLine("Process Started!");
                // some code here..
                OnProcessCompleted();
            }

            protected virtual void OnProcessCompleted() //protected virtual method
            {
                //if ProcessCompleted is not null then call delegate
                ProcessCompleted?.Invoke();
            }
        }
    }

    // Non Static Class Demo
    class Customer
    {
        // Local Variables
        string firstName;
        string lastName;

        // No Arg Constructor
        public Customer() : this("No FirstName Provided", "No LastName Provided")
        {
        }

        // All Arg Constructor
        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            printCustomerName();
        }

        // Method For Printing Customer Name
        public void printCustomerName()
        {
            Console.WriteLine("Full Name : {0}", firstName + " " + lastName );
        }
    }

    // Static Class Demo
    static class StaticVariables
    {
        // Static Local Variable Declaration
        public static float PI;

        // Constructor for initializing static variables
        static StaticVariables()
        {
            StaticVariables.PI = 3.14F;
        }

        // Method For Printing Static Variable
        public static void printStaticVariables()
        {
            Console.WriteLine("Value Of PI Is " + StaticVariables.PI);
        }
    }

    class Circle
    {
        // Local Variable
        int radius;

        // Constructor for initializing non static variable
        public Circle(int radius)
        {
            this.radius = radius;
        }

        // Method for calculating area of cirle
        public float CalculateArea()
        {
            return StaticVariables.PI * radius * radius;
        }
    }

    /* Sealed Class Demo
    In the following code,
    I create a sealed class SealedClass and use it from Class1.
    If you run this code, it will work just fine.
    But if you try to derive a class from the SealedClass, you will get an error.
    
    class Class1
    {
        static void Main(string[] args)
        {
            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
    // Sealed class  
    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    */

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }


    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Create Object Of Class Customer Without Parameter
            Customer objCustomer1 = new Customer();

            // Create Object Of Class Customer With Parameter
            Customer objCustomer2 = new Customer("Kashyap" ,"Sayani");

            // Call static method
            StaticVariables.printStaticVariables();

            // Create Object Of Class Circle With Parameter
            Circle circle1 = new Circle(10);

            // Find the area of circle
            float area1 = circle1.CalculateArea();

            // Print the area of circle
            Console.WriteLine("Area = {0} ",area1);

            // Create Object Of Class Circle With Parameter
            Circle circle2 = new Circle(5);

            // Find the area of circle
            float area2 = circle2.CalculateArea();

            // Print the area of circle
            Console.WriteLine("Area = {0} ", area2);

            // Create a Pig object
            Pig myPig = new Pig();

            // Call the abstract method
            myPig.animalSound();

            // Call the regular method
            myPig.sleep();  
        }
    }
}