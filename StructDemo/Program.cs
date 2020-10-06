// ITHS Demokod 2020-10-06

using System;

namespace StructDemo
{
    struct PersonStruct
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
    }

    class Program
    {
        static int i;
        static PersonStruct ps1;

        static void Main(string[] args)
        {
            int j = i;
            Console.WriteLine(j);

            PersonStruct ps2 = ps1;
            ps2.Name = "Håkan";
            ps2.BirthYear = 1962;
            Console.WriteLine(ps2.Name);
        }
    }
}
