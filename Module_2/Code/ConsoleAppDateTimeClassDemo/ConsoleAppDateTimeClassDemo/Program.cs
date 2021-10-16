using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDateTimeClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local Variable Declaration
            int days = 0;
            int ret = 0;
            bool flag = false;

            // Days
            days = DateTime.DaysInMonth(2016, 2);

            Console.WriteLine("Day in Month : " + days);

            // Check for leap year
            flag = DateTime.IsLeapYear(2016);

            if (flag == true)
                Console.WriteLine("\nGiven year is leap year");

            else
                Console.WriteLine("\nGiven year is not leap year");

            Console.WriteLine("Current DateTime :" + DateTime.Now.ToString());

            DateTime d1 = new DateTime(2017, 6, 10);
            DateTime d2 = new DateTime(2017, 6, 11);

            flag = DateTime.Equals(d1, d2);

            // Check that both the dates are equal or not
            if (flag == true)
            {
                Console.WriteLine("Given dates are equal");
            }
            else
            {
                Console.WriteLine("Given dates are not equal");
            }

            ret = DateTime.Compare(d1, d2);

            // Check that which date is greater than another
            if (ret > 0)
            {
                Console.WriteLine("First date is greater");
            }
            else if (ret < 0)
            {
                Console.WriteLine("Second date is greater");
            }
            else
            {
                Console.WriteLine("Given dates are equal");
            }
        }
    }
}