// ITHS Demokod 2020-10-06!

using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(19);

            try
            {
                p.Age = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Programmet fortsätter...");


            bool done = false;

            do
            {
                Console.Write("Vänligen mata in ett tal att dividera med: ");

                try
                {
                    string input = Console.ReadLine();
                    int denominator = 0;
                    denominator = int.Parse(input);

                    done = true;

                    if (denominator != 0)
                        Console.WriteLine($"10 / {denominator} = {10 / denominator}");
                    else
                    {
                        Console.WriteLine("Du kan inte mata i 0 eftersom det skulle generera ett undantagsfel.");
                        done = false;
                    }
                }

                //catch (OverflowException dbz)
                //{
                //    Console.WriteLine("Du har inte matat in ett för stort heltal");
                //}
                //catch (FormatException dbz)
                //{
                //    Console.WriteLine("Du har inte matat in ett heltal");
                //}
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //done = false;
                }
            } while (!done);


            Console.WriteLine("Programmet slut.");
        }
    }
}
