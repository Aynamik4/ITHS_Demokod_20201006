// ITHS Demokod 2020-10-06

using System;

namespace CastDemo
{
    class Animal
    {
        public int Weight { get; set; }
    }

    class Dog : Animal
    {
        public string DogName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double d = 3.94;
            int j = (int)d;
            Console.WriteLine(j);

            //string myStringAge = "58";
            //i = (int)myStringAge;

            Animal a = new Dog();
            ((Dog)a).DogName = "Fido";
            Console.WriteLine(((Dog)a).DogName);
        }
    }
}
