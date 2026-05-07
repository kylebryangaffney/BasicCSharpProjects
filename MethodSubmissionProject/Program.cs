using MethodSubmissionProject;
using System;
using System.Collections.Generic;


namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicMathMachine machine = new BasicMathMachine();
            int valueOne = 0;
            int valueTwo = 0;
            int result = 0;
            bool isValid = false;

            // get first number
            Console.WriteLine("Please enter a whole number you would like to add to another whole number: ");
            string userInput = Console.ReadLine();

            isValid = int.TryParse(userInput, out valueOne);
            while (!isValid)
            {
                Console.WriteLine("Please enter a valid whole number as a digit ");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out valueOne);
            }

            // get second number which is optional
            Console.WriteLine("Please enter another whole number to add, or leave empty to use default value of 10: ");
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                // user skipped — call with one argument, default kicks in
                result = machine.AddNumbers(valueOne);
                Console.WriteLine(valueOne + " + 10 (default) = " + result);
            }
            else
            {
                // user entered something — validate it
                isValid = int.TryParse(userInput, out valueTwo);
                while (!isValid)
                {
                    Console.WriteLine("Please enter a valid whole number as a digit ");
                    userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out valueTwo);
                }

                // call with both arguments
                result = machine.AddNumbers(valueOne, valueTwo);
                Console.WriteLine(valueOne + " + " + valueTwo + " = " + result);
            }
        }

    }
}