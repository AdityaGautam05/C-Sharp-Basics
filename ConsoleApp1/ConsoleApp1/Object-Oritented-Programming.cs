using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    internal class ObjectOritentedProgramming
    {
        // CSharp properties (Basically Getters and setters without defining a public method and exposing it)
        // There is even a short hand way of using CSharp Properties refer Microsoft docs for more info.
        // Properties can be auto-generated as well.
        // Virtual keyword is used to allow a method to be overriden.
        // base is used to add super constructor during inheritence.
        // Read about inheritence in CSharp from microsoft docs.
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Can Declare fields inside the class
        string name;
        string author;
        string pageCount;

        // Classes can have constructors
        ObjectOritentedProgramming(string _name, string _author, string _pageCount)
        {
            name = _name;
            author = _author;
            pageCount = _pageCount;
        }
        public static void Main(string[] args)
        {
            // Create objects of other classes in a class with main method and use the functions or the fields

            // Please check access modifiers once as well


            Console.WriteLine("OOPS!");
        }

        // Classes can have methods
        public void showDetails()
        {
            Console.WriteLine(author);
            Console.WriteLine(pageCount);
            Console.WriteLine(name);
        }
    }
}
