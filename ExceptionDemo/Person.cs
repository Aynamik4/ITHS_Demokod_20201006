using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionDemo
{
    class Person
    {
        public int Name { get; set; }

        private int age;
        private int maximumAge;

        public Person(int maxAge)
        {
            maximumAge = maxAge;
        }

        /// <summary>
        /// Exceptions: OverflowException
        /// </summary>
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= maximumAge)
                    age = value;
                else
                    throw new OverflowException($"Exception: Age > {maximumAge}");
            }
        }

    }
}
