using System;

namespace ConsoleAppForPractice
{
    class Box
    {
        public double length; //Length Of A Box
        public double breath; //Breadth Of A Box
        public double height; //Height Of A Box
    }
    class ClassDemo
    {
        static void Main(String[] args)
        {
            Box box1 = new Box(); //Declare Box1 of type Box
            Box box2 = new Box(); //Declare Box2 of type Box
            double volume = 0.0; //Store the value of a box here

            //box 1 specification
            box1.height = 5.0;
            box1.length = 6.0;
            box1.breath = 7.0;

            //box 2 specification
            box2.height = 10.0;
            box2.length = 12.0;
            box2.breath = 13.0;

            //Volume of box 1
            volume = box1.height * box1.length * box1.breath;
            Console.WriteLine("Volume Of Box 1 : {0}", volume);

            //Volume of box 2
            volume = box2.height * box2.length * box2.breath;
            Console.WriteLine("Volume Of Box 2 : {0}", volume);
        }
    }
}
