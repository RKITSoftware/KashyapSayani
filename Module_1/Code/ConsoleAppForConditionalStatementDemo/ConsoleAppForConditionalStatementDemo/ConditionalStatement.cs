using System;

namespace ConsoleAppForConditionalStatementDemo
{
    class ConditionalStatement
    {
		static void Main()
		{
			// local variable declaration
			int i = 10, j = 20;

			// check if i is greater than j or not
			if (i > j)
			{
				Console.WriteLine("i is greater than j");
			}

			// if i is less than j or not
			if (i < j)
			{
				Console.WriteLine("i is less than j");
			}

			// check if i and j both are equal or not
			if (i == j)
			{
				Console.WriteLine("i is equal to j");
			}
		}
	}
}