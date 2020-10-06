// ITHS Demokod 2020-10-06

using System;

namespace CodeAlongStruct2
{
    class Program
    {
        static void Main(string[] args)
        {
            User userOne = default;
            userOne.Name = "Musse Pigg";
            userOne.Location = "Ankeborg";
            userOne.Age = 91;

            Console.WriteLine($"{userOne.Name} bor i {userOne.Location} och är {userOne.Age} år gammal.");

            // Alternativt
            User userTwo = default;
            userTwo.Name = "Långben";
            userTwo.Location = "Ankeborg";
            userTwo.Age = 88;

            Console.WriteLine($"{userTwo.Name} bor i {userTwo.Location} och är {userTwo.Age} år gammal.");

            // Declare variable using the new Keyword, that is calling the constructor.
            SpecialUser userThree = new SpecialUser("Stockholm", 31);
            Console.WriteLine($"Name: {SpecialUser.Name}, Location: {userThree.Location}, Age: {userThree.Age}");

            // Declare variable without using the new Keyword.
            //SpecialUser userFour = /*default;*/new SpecialUser() /*{ Location = "Göteborg", Age = 32 }*/;
            SpecialUser userFour = new SpecialUser("Göteborg", 32); /*{ Location = "Göteborg", Age = 32 }*/
            //userFour.Location = "Göteborg";
            //userFour.Age = 32;
            Console.WriteLine($"Name: {SpecialUser.Name}, Location: {userFour.Location}, Age: {userFour.Age}");
        }
    }
}
