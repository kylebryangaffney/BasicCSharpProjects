
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionProject
{
    class Program
    {

        static void Main(string[] args)
        {
            // provide instructions to user
            // since the class is now static, the methods need to be called on the blueprint, not on an instance of the class
            Console.WriteLine(MathMachine.GetDescription());

            // get int value and divide it by two
            int userNumber = 0;
            GetUserInput(out userNumber);
            int result = 0;
            MathMachine.DivideByTwo(userNumber, out result);
            Console.WriteLine(userNumber + " / 2 = " + result);


            // double version and then divide that number by 2 as well
            double userDouble = 0.0;
            GetUserInput(out userDouble);
            double resultDouble = 0.0;
            MathMachine.DivideByTwo(userDouble, out resultDouble);
            Console.WriteLine(userDouble + " / 2.0 = " + resultDouble);

        }

        // functions to get user input as an int
        static void GetUserInput(out int result)
        {
            bool isValid = false;
            result = 0;
            Console.WriteLine("Please input a whole number to divide by 2: ");
            string userInput = Console.ReadLine();
            isValid = int.TryParse(userInput, out result);
            // check if the user value is within the array range
            while (!isValid || result <= 0)
            {
                Console.WriteLine("Input value must be a whole number greater than 0");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out result);
            }
        }

        // overload to get user input as a double
        static void GetUserInput(out double result)
        {
            bool isValid = false;
            result = 0.0;
            Console.WriteLine("Please input a decimal number to divide by 2.0: ");
            string userInput = Console.ReadLine();
            isValid = double.TryParse(userInput, out result);
            while (!isValid || result <= 0)
            {
                Console.WriteLine("Input value must be a decimal number greater than 0");
                userInput = Console.ReadLine();
                isValid = double.TryParse(userInput, out result);
            }
        }
    }
}