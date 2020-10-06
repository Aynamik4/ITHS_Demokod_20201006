// ITHS Demokod 2020-10-06

using System;

namespace ValueTypeVsReferenceType
{
    struct MyDataType
    {
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDataType my = /*default;*/ new MyDataType();
            my.Age = 58;
            MyDataType my2 = my;
            Console.WriteLine(my.Age); // 58
            DoubleAge(my);
            Console.WriteLine(my.Age); // 116
        }

        private static void DoubleAge(MyDataType myParameter)
        {
            myParameter.Age *= 2;
            Console.WriteLine($"myParameter = {myParameter.Age}");
        }
    }
}
