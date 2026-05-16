using System;

using System.IO;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // get current time
            DateTime currentDateTime = DateTime.Now;
            // Print current time to console
            Console.WriteLine("It is currently {0}.", currentDateTime);
            // Prompt user for input
            Console.WriteLine("Please enter a number of hours to add to the current time: ");
            // convert the user input to a double to add to the current time
            string userInput = Console.ReadLine();
            double hoursToAdd;

            if (double.TryParse(userInput, out hoursToAdd))
            {
                // print out the time + user input
                Console.WriteLine("In {0} hours it will be: {1}", hoursToAdd, currentDateTime.AddHours(hoursToAdd));

            }
            else
            {
                // tell the user they provided in adequate input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}


