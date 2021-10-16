using System;

namespace ConsoleAppLoopsDemo
{
    class LoopsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---For Loop---");
            // print a pattern using for loop
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n---While Loop---");
            // reverse a number using while loop
            int number = 231,temp;

            while(number!=0)
            {
                temp = number % 10;
                Console.Write(temp);
                number = number / 10;
            }

            Console.WriteLine("\n\n---Do While Loop---");
            // do while loop
            do
            {
                Console.WriteLine("Hello World!!!");
            } while (number!=0);


            // foreach loop
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // foreach loop begin
            // it will run till the
            // last element of the array
            Console.WriteLine("\n---Foreach Loop---");
            foreach (int items in a_array)
            {
                Console.Write(items + " " );
            }

            // Demo for Break and Continue 

            // WAP to find that given number is prime or not.
            int num = 7;
            Boolean flag = true;
            Console.WriteLine("\n\n---Use Of Break---");
            if (num != 1)
            {
                if (num > 1)
                {
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.WriteLine("The given number is not a prime number...");
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        Console.WriteLine("The given number is a prime number...");
                    }
                }
                else
                {
                    Console.WriteLine("Negative Number Is Not Allowed...");
                }   
            }
            else
            {
                Console.WriteLine("The given number is not a prime number...");
            }

            // WAP to print numbers alternatively
            Console.WriteLine("\n---Use Of Continue---");
            for (int i=0;i<10;i++)
            {
                if(i%2==0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}