using System;

namespace ConsoleAppInterfaceDemo
{

    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig objMyPig = new Pig();  // Create a Pig object
            objMyPig.animalSound();

            Dog objMyDog = new Dog();  // Create a Pig object
            objMyDog.animalSound();
        }
    }
}
