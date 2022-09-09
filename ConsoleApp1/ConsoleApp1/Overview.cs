using System;

namespace HelloWorld
{
    // Input & Output, Primitive datatypes
    class Overview
    {
        public static void Main(string[] args)
        {
            // Input Output
            Console.WriteLine("Hey ! Which is the best programming language in the world !");
            string str = Console.ReadLine();
            if (str.ToLower().Equals("swift"))
            {
                Console.WriteLine("That's correct !");
            }
            else
            {
                Console.WriteLine("Nah !");
            }

            // Datatypes
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            int[] a = new int[5];
            a[0] = 1;
            a[1] = 4;
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a[0]);


            //Operators
            Console.WriteLine(2 + 3);
            Console.WriteLine("Hello"+" World!");

            // Null coalescing
            string nullString = null;

            // Assignment can also be used
            nullString ??= "Null String";
            Console.WriteLine(nullString ?? "String is Null !");
        }
    }
}
