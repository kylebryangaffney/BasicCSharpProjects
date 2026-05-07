using MainMethodProject;
using System;
using System.Collections.Generic;


namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables 
            AdvancedMathMachine mathMachine = new AdvancedMathMachine();
            int result = 0;
            
            bool isValid = false;

            // get user input for int overload
            Console.WriteLine("Please enter a whole number you would like to perform addition functions on: ");
            string userInput = Console.ReadLine();

            // check if user input is a valid int
            int userNumber = 0;
            isValid = int.TryParse(userInput, out userNumber);
            while (!isValid)
            {
                Console.WriteLine("Please enter a valid whole number as a digit ");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out userNumber);
            }

            // using the math machine to add then printing the result
            result = mathMachine.AddFive(userNumber);
            Console.WriteLine(userNumber + " + 5 = " + result);

            // block for double overload

            Console.WriteLine("Please enter a decimal number you would like to perform addition on: ");
            userInput = Console.ReadLine();

            // check if user input is a valid int
            double userDouble = 0.0;
            isValid = double.TryParse(userInput, out userDouble);
            while (!isValid)
            {
                Console.WriteLine("Please enter a valid decimal number");
                userInput = Console.ReadLine();
                isValid = double.TryParse(userInput, out userDouble);
            }

            // using the math machine to add then printing the result
            result = mathMachine.AddFive(userDouble);
            Console.WriteLine(userDouble + " + 5 = " + result);

            // block for string overload 
            Console.WriteLine("Please enter another whole number you would like to perform addition on: ");
            userInput = Console.ReadLine();

            // using the math machine to add then printing the result
            try
            {
                result = mathMachine.AddFive(userInput);
                Console.WriteLine(userInput + " + 5 = " + result);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }

        }
    }
}