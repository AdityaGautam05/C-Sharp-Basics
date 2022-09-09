using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    internal class Functions
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lets study Functions !");

            // Calling Functions
            Console.WriteLine($"Result is {MilesToKm(8.0f)}");

            // Default Parameters in Functions
            PrintWithPrefix("Hello C#!");
            PrintWithPrefix("Hello C#", "Swift is the Best ! LOL ");

            // Named Parameters
            PrintWithPrefix(prefix: "Hello C# ",theString: "Swift is the Best ! LOL ");

            // Reference Parameters
            int km = 500;
            // Does not update the actual KM
            ChangeTheKM(km);
            Console.WriteLine(km);

            // Updates the actual KM
            // ref indicates the compiler that the object is passed as a reference and not a copy.
            ChangeTheKMWithRef(ref km);
            Console.WriteLine(km);

            // Out Paramters
            // Out assigns the output parameters to sum and product
            int sum, product;
            PlusTimes(50, 62, out sum, out product);
            Console.WriteLine(sum + " " + product);

            // Tuples in C#
            (int a, int b) tupple1 = (5, 10);
            // OR
            var tupple2 = ("Some Text", 10.5f);

            // Accessing elements of a tupple
            Console.WriteLine(tupple1.a + " " + tupple1.b);

            // OR C# Automatically assigns the name for case 2
            Console.WriteLine(tupple2.Item1+ " " + tupple2.Item2);

            // Returning Multiple Values from a function (Other way from using Out Parameters)
            (int, int) result = PlusTimesWithTupple(50, 62);
            Console.WriteLine(result.Item1 + " " + result.Item2);
        }

            static float MilesToKm(float miles)
        {
            return miles * 1.6f;
        }

        // Default Parameters
        static void PrintWithPrefix(string theString, string prefix = "")
        {
            Console.WriteLine(prefix + theString);
        }

        // Reference Parameters
        // Lets say we update the function parameter and we want the actually reference to get updated as well from inside the function. We can use ref Params
        static void ChangeTheKMWithRef(ref int km)
        {
            km = 10;
        }

        static void ChangeTheKM(int km)
        {
            km = 10;
        }

        // Out Parameters
        static void PlusTimes(int arg1, int arg2, out int sum, out int product)
        {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        static (int, int) PlusTimesWithTupple(int a, int b)
        {
            return (a + b, a * b);
        }

    }
}
