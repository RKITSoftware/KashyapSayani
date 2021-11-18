using System;

namespace ConsoleAppEnumerationDemo
{

    // making an enumerator 'month'
    public enum month
    {
        // following are the data members
        jan,
        feb,
        mar,
        apr,
        may
    }

    class Perimeter
    {
        // declaring enum
        public enum shapes
        {
            circle,
            square
        }

        public void peri(int val, shapes s1)
        {

            // checking for shape to be circle
            if (s1 == 0)
            {
                // Output the circumference
                Console.WriteLine("Circumference of the circle is " +
                                                      2 * 3.14 * val);
            }

            else
            {
                // else output the perimeter of the square
                Console.WriteLine("Perimeter of the square is " +
                                                         4 * val);
            }
        }
    }

    public enum color
    {

        // enum data members
        Red,
        Yellow,
        Blue,

        // assigning value yellow(1) + 5
        Green = Yellow + 5,
        Brown,

        // assigning value Green(6) + 3
        Black = Green + 3

    }

    public enum Color
    {
        RED, GREEN, BLUE
    };

    class Program
    {
        static void Main(string[] args)
        {
            // month enum
            // getting the integer values of data members..
            Console.WriteLine("The value of jan in month " +
                              "enum is " + (int)month.jan);
            Console.WriteLine("The value of feb in month " +
                              "enum is " + (int)month.feb);
            Console.WriteLine("The value of mar in month " +
                              "enum is " + (int)month.mar);
            Console.WriteLine("The value of apr in month " +
                              "enum is " + (int)month.apr);
            Console.WriteLine("The value of may in month " +
                              "enum is " + (int)month.may);

            // shapes enum
            Perimeter a1 = new Perimeter();
            a1.peri(3, Perimeter.shapes.circle);
            a1.peri(4, Perimeter.shapes.square);

        /*  color enum
            Now the use of special initialisation
            cases is demonstrated as expected Red
            will be assigned 0 value similarly
            yellow will be 1 and blue will be 2
            however, green will be assigned the
            value 1+5=6 similarly is the case
            with brown and black */

            Console.WriteLine("\nColor Enum");

            Console.WriteLine("Value of Red Color is " +
                                           (int)color.Red);
            Console.WriteLine("Value of Yellow Color is " +
                                         (int)color.Yellow);
            Console.WriteLine("Value of Blue Color is " +
                                          (int)color.Blue);
            Console.WriteLine("Value of Green Color is " +
                                          (int)color.Green);
            Console.WriteLine("Value of Brown Color is " +
                                          (int)color.Brown);
            Console.WriteLine("Value of Black Color is " +
                                          (int)color.Black);

            // CompareTo Method in enum

            Color c1 = Color.RED;
            Color c2 = Color.GREEN;
            Color c3 = Color.RED;
            Color c4 = Color.BLUE;

            Console.Write("Comparing {0} with {1} : ", c1, c2);

            // CompareTo method 
            Console.WriteLine(c1.CompareTo(c2));

            Console.Write("Comparing {0} with {1} : ", c1, c3);

            // CompareTo method 
            Console.WriteLine(c1.CompareTo(c3));

            Console.Write("Comparing {0} with {1} : ", c4, c2);

            // CompareTo method 
            Console.WriteLine(c4.CompareTo(c2));

            // Get HashCode 
            Console.WriteLine("Hash code Of c1 and c2 is :  " + c1.GetHashCode() + " : "+c2.GetHashCode());

            // Get TypeCode
            Console.WriteLine("Type Code of c4 is : {0}" , c1.GetTypeCode());
        }
    }
}