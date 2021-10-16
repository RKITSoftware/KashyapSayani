using System;
using System.IO;

namespace ConsoleAppOperatorsAndExpressions
{
    class ArithmeticOperatorsDemo
    {
        // Constructor Of Class ArithmeticOperatorsDemo
        public ArithmeticOperatorsDemo()
        {
            calculator();
        }

        // Method For Calculations
        void calculator()
        {
            // local variables
            double addition, substraction, multiplication, division, modulus;
            double value1, value2;

            // take value for calculation
            Console.WriteLine("Enter Value One : ");
            value1 = (double)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Value Two : ");
            value2 = (double)Convert.ToDecimal(Console.ReadLine());

            // do calculation
            addition = value1 + value2;
            substraction = value1 - value2;
            multiplication = value1 * value2;
            division = value1 / value2;
            modulus = value1 % value2;

            // display results
            Console.WriteLine("Addition Is : " + addition);
            Console.WriteLine("Substraction Is : " + substraction);
            Console.WriteLine("Multiplication Is : " + multiplication);
            Console.WriteLine("Division Is : " + division);
        }
    }

    class RelationalOperatorsDemo
    {
        // Constructor Of Class RelationalOperatorsDemo
        public RelationalOperatorsDemo()
        {
            RelationalOperators();
        }

        // Method For Relational Operators Demo
        void RelationalOperators()
        {
            // local variables
            int value1 = 13, value2 = 25;

            // check if both are equal or not
            if (value1 == value2)
            {
                Console.WriteLine("Value1 and Value2 both are Same.");
            }
            // check if value one is greater than value2 or not
            else if (value1 > value2)
            {
                Console.WriteLine("Value1 is greater than Value2.");
            }
            // check if value one is lower than value2 or not
            else
            {
                Console.WriteLine("Value1 is lower than Value2.");
            }
        }
    }

    class LogicalOperatorDemo
    {
        // Constructor Of Class LogicalOperatorDemo
        public LogicalOperatorDemo()
        {
            LogicalOperators();
        }

        // Method For Logical Operators Demo
        void LogicalOperators()
        {
            // Local variables
            int value1=12, value2=32;

            // Check if value1 is greater than 10 or value2 is greater than 10
            if(value1>10 || value2>10)
            {
                Console.WriteLine("Both Or One Of Them Are True");
            }

            // Check if value1 is greater than 10 and value2 is less than 50
            if (value1>10 && value2<50)
            {
                Console.WriteLine("Both Are True");
            }
        }
    }

    class BitwiseOperatorDemo
    {
        // Constructor Of Class LogicalOperatorDemo
        public BitwiseOperatorDemo()
        {
            BitwiseOperators();
        }
            
        void BitwiseOperators()
        {
            /*
                BitWise And
                12 = 00001100 (In Binary)
                25 = 00011001 (In Binary)

                Bit Operation of 12 and 25
                  00001100
                & 00011001
                  ________
                  00001000  = 8 (In decimal)
             */

            // Local Variables
            int a = 12, b = 25;

            Console.WriteLine("BitWise And : " + (a & b));

            /*
            BitWise Or 
            12 = 00001100 (In Binary)
            25 = 00011001 (In Binary)

            Bitwise OR Operation of 12 and 25
                00001100
            | 00011001
                ________
                00011101  = 29 (In decimal)
            */

            Console.WriteLine("BitWise Or : " + (a | b));

            /* 
            BitWise XOR
            12 = 00001100 (In Binary)
            25 = 00011001 (In Binary)

            Bitwise XOR Operation of 12 and 25
              00001100
            ^ 00011001
              ________
              00010101  = 21 (In decimal)
             */

            Console.WriteLine("BitWise XOR : " + (a ^ b));

            /* 
            BitWise Complement
            35 = 00100011 (In Binary)
            Bitwise complement Operation of 35
            ~ 00100011 
              ________
              11011100  = 220 (In decimal)
             */
            Console.WriteLine("BitWise Complement : " + ~35 );

            /*
            Right Sift
            212 = 11010100 (In binary)
            212>>2 = 00110101 (In binary) [Right shift by two bits]
            212>>7 = 00000001 (In binary)
            212>>8 = 00000000 
            212>>0 = 11010100 (No Shift)

            Left Sift
            212 = 11010100 (In binary)
            212<<1 = 110101000 (In binary) [Left shift by one bit]
            212<<0 = 11010100 (Shift by 0)
            212<<4 = 110101000000 (In binary) =3392(In decimal)
             */

            // Local Variables
            int num = 212, i;

            Console.WriteLine("\n");

            for (i = 0; i <= 2; ++i)
                Console.WriteLine("Right shift by {0} : {1}", i, num >> i);

            Console.WriteLine("\n");

            for (i = 0; i <= 2; ++i)
                Console.WriteLine("Left shift by {0}: {1}", i, num << i);

        }
    }

    class MiscellaneousOperatorsDemo
    {
        public MiscellaneousOperatorsDemo()
        {
            MiscellaneousOperators();
        }

        unsafe void MiscellaneousOperators()
        {
            // sizeof()
            Console.WriteLine("Size Of Int : " + sizeof(int));

            // typeof()
            Console.WriteLine("Type Of : " + typeof(MiscellaneousOperatorsDemo));

            // & -> Returns the address of an variable , * -> Pointer to a variable
            int a = 10;
            int* ptr = &a;
            Console.WriteLine("Address Of Variable 'a' Is :  " + (long)ptr);

            // Ternary Operator
            int x = 20, y = 10;

            // Check that x is greater than y or not
            var result = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(result);

            // is -> Determines whether an object is of a certain type
            String str = new String("Kashyap Sayani");

            if(str is String)
            {
                Console.WriteLine("Yes, str is object of String Class");
            }

            //as -> Cast without raising an exception if the cast fails.
            Object obj = new StringReader("Hello");
        }
    }

    // Main Class For Execution Of Program
    class OperatorsAndExpressions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Demo Of Arithmetic Operators---\n");
            // make object of class ArithmeticOperatorsDemo
            ArithmeticOperatorsDemo objArithmeticOperators = new ArithmeticOperatorsDemo();

            Console.WriteLine("\n---Demo Of Relational Operators---\n");
            // make object of class RelationalOperators
            RelationalOperatorsDemo objRelationalOperators = new RelationalOperatorsDemo();

            Console.WriteLine("\n---Demo Of Logical Operators---\n");
            // make object of class RelationalOperators
            LogicalOperatorDemo objLogicalOperators = new LogicalOperatorDemo();

            Console.WriteLine("\n---Demo Of Bitwise Operators---\n");
            // make object of class RelationalOperators
            BitwiseOperatorDemo objBitwiseOperators = new BitwiseOperatorDemo();

            Console.WriteLine("\n---Demo Of Miscellaneous Operators---\n");
            // make object of class RelationalOperators
            MiscellaneousOperatorsDemo objMiscellaneousOperators = new MiscellaneousOperatorsDemo();
        }
    }
}