// ITHS Demokod 2020-10-06

using System;

namespace VauleTypeVsReferenceType_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            //ManipulateArray(my.Integers);
            my.Integers[0] = 10;
            Console.WriteLine(my.Integers[0]);
            ManipulateArray(my.Integers);

        }

        public static void ManipulateArray(int[] ints)
        {
            ints = new int[20];

            ints[0] = 20;
        }
    }

    class MyClass
    {
        public int[] Integers { get; private set; } = new int[] { 4, 78, 341, 690 };
    }
}
