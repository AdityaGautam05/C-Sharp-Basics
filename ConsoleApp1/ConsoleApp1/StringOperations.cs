using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Overview
{
    internal class StringOperations
    {
        public static void Main(string[] args)
        {
            // Declare Strings
            string s = "Swift is the best language!";

            // Getting length
            Console.WriteLine(s.Length);

            // Getting Individual Chars
            Console.WriteLine(s[2]);

            // Decalring String Array
            string[] strArray = { "one", "two", "three", "four", "five" };

            // String Concatination
            Console.WriteLine(string.Concat(strArray));

            // String Join with Character literal
            Console.WriteLine(string.Join(".", strArray));

            // String Join with String literal
            Console.WriteLine(string.Join(".#.", strArray));

            // String Formatting

            // N (Number), G(General), F(Fixed-Point), E(Exponential), D(Decimal), P(Percent), X(Hexadecimal), C(Currency)
            int value = 1234;
            decimal decimalValue = 1234.5678m;
            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", value);
            Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", decimalValue);

            // Specify Precision
            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", value);

            // String Interpolation 
            // (Using the $ sign to make a string out of variables, a better way than string formatting)

            string make = "Mercedez-Benz";
            string model = "G-Wagon";
            string year = "2022";
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            Console.WriteLine($"This SUV is a {year} {make} {model}, with {miles} miles and costs {price}");

            // Inline Experessions

            Console.WriteLine($"This SUV is a {year} {make} {model}, with {miles * 1.6:F2} KMs and costs {price}");

            // String Builder

            StringBuilder sb = new StringBuilder("Started String", 200);

            // Basic operations with String Builder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // Append String
            sb.Append("Quick Append");
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // Append Line
            sb.AppendLine();
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // Can read about append Join, Replace, Inserting content at any index (Quite self explanatory)
            // If your Program required many string operations use StringBuilder

            // Parsing into String
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            // Good idea to parse inside a try block as can catch an exception

            // To INT
            Console.WriteLine(int.Parse(numStr1));

            // To INT from floating Point
            Console.WriteLine(int.Parse(numStr2, NumberStyles.Float));

            // With Thousand Markers
            Console.WriteLine(int.Parse(numStr3, NumberStyles.AllowThousands));

            // Joining two styles Float and Thousands
            Console.WriteLine(int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands));

            // Parsing Boolean
            Console.WriteLine($"{bool.Parse("True")}");

            // Parsing Float
            Console.WriteLine($"{float.Parse("1.625"):F2}");
        }

    }

}
