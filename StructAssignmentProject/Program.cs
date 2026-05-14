
using System;
using System.Collections.Generic;


namespace StructAssignmentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a number struct 
            Number sixtyTwo = new Number(62);
            // get the correct attribute of the Number struct, and then print it to the console
            Console.WriteLine(sixtyTwo.Amount.ToString());
        }


    }

    // define the struct
    struct Number
    {
        // public constructor to simplify the process of actually using the struct
        public Number(decimal value)
        {
            Amount = value;
        }
        // single attribute for storing the desired value
        public decimal Amount { get; set; }

    }
}
