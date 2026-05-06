
using CallingMethodsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables 
            MathMachine mathMachine = new MathMachine();
            bool isValid = false;
            int userNumber = 0;
            int result = 0;

            // get user input
            Console.WriteLine("Please enter a whole number you would like to perform math functions on: ");
            string userInput = Console.ReadLine();

            // check if user input is a valid int
            isValid = int.TryParse(userInput, out userNumber);
            while (!isValid)
            {
                Console.WriteLine("Please enter a valid whole number as a digit ");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out userNumber);
            }

            // using the math machine to subtract, add, and multiply the user input value, then printing the result
            result = mathMachine.SubtractFive(userNumber);
            Console.WriteLine(userNumber + " - 5 = " + result);

            result = mathMachine.AddFive(userNumber);
            Console.WriteLine(userNumber + " + 5 = " + result);

            result = mathMachine.MultiplyFive(userNumber);
            Console.WriteLine(userNumber + " * 5 = " + result);
        }
    }
}
