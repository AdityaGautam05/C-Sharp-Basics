using System;

namespace Overview
{
    // Program Flow
    internal class ProgramFlow
    {
        static void Main(string[] args)
        {
            // Conditionals if 
            int value = 1;
            if (value == 1)
            {
                Console.WriteLine("Swift is GOAT !");
            } else if (value == 0)
            {
                Console.WriteLine("JS is GOAT !");
            } else
            {
                Console.WriteLine("C# is GOAT !");
            }


            // Ternary Operaters
            Console.WriteLine(value < -5 ? "Swift is GOAT !" : "C# is GOAT !");

            // Switch Statements
            switch(value)
            {
                case 0:
                    Console.WriteLine("Swift is GOAT !");
                    break;
                case 1:
                    Console.WriteLine("JS is GOAT !");
                    break;
                default:
                    Console.WriteLine("C# is GOAT !");
                    break;
            }

            // Loops

            // For Loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Swift is GOAT !");
            }

            // ForEach Loop
            int[] array = new int[10];
            foreach(int element in array)
            {
                Console.WriteLine("C# is GOAT ! :P");
            }

            // While Loop
            int length = array.Length;
            while (length > 0)
            {
                Console.WriteLine("Swift is GOAT !");
                length--;
            }

            // Do-While Loop
            do
            {
                Console.WriteLine("C# is GOAT ! :P");
            } while (length > 0);

            // Exceptions
            int x = 100;
            int y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Arithemetic Exception");
                Console.WriteLine("From Arguement : " + e.Message);
            }
            finally
            {
                Console.WriteLine("This is always run, No matter what !");
            }
        }

    }
}
