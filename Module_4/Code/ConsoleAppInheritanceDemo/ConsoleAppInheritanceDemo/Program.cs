using System;

namespace ConsoleAppInheritanceDemo
{
    public class Animal
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }

    // Dog inherit Animal Class
    public class Dog : Animal
    {
        public void bark() { Console.WriteLine("Barking..."); }
    }

    // BabyDog inherit Dog Class
    public class BabyDog : Dog
    {
        public void weep() { Console.WriteLine("Weeping..."); }
    }

    // Main Class
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating object of BabyDog class
            BabyDog d1 = new BabyDog();
            // calling eat method of class Animal using BabyDog class
            d1.eat();
            // calling bark method of class Dog using BabyDog class
            d1.bark();
            // calling eat method of class BabyDog
            d1.weep();
        }
    }
}
