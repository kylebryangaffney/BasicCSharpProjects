using System;

namespace BranchingStatements
{
    class Program
    {
        static void Main()
        {
            // Initialize variables
            double weight = 0;
            double width = 0;
            double height = 0;
            double length = 0;
            double volume = 0;
            double costToShip = 0;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get Package weight from user
            string strWeight = "";
            while (true) // Loop until a valid numeric input is received
            {
                Console.WriteLine("Please enter the weight of the package: ");
                strWeight = Console.ReadLine();

                // Convert string to double
                if (double.TryParse(strWeight, out weight))
                {
                    break; // Exit the while loop if input is valid
                }
                Console.WriteLine("Value entered must be a valid decimal value for package weight");
            }

            // Check if weight exceeds the maximum limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Get package width from user
            string strWidth = "";
            while (true)
            {
                Console.WriteLine("Please enter the width of the package: ");
                strWidth = Console.ReadLine();

                if (double.TryParse(strWidth, out width))
                {
                    break;
                }
                Console.WriteLine("Value entered must be a valid decimal value for package width");
            }

            // Get package height from user
            string strHeight = "";
            while (true)
            {
                Console.WriteLine("Please enter the height of the package: ");
                strHeight = Console.ReadLine();

                if (double.TryParse(strHeight, out height))
                {
                    break;
                }
                Console.WriteLine("Value entered must be a valid decimal value for package height");
            }

            // Get package length From user
            string strLength = "";
            while (true)
            {
                Console.WriteLine("Please enter the length of the package: ");
                strLength = Console.ReadLine();

                if (double.TryParse(strLength, out length))
                {
                    break;
                }
                Console.WriteLine("Value entered must be a valid decimal value for package length");
            }

            // Calculate package dimentions
            // Check if the sum of dimensions exceeds the limit
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                return; // Exit program immediately
            }

            // Calculate size and shipping costs
            // Calculate package volume
            volume = width * height * length;

            // Calculate shipping cost
            costToShip = (volume * weight) / 100;

            // Print results
            // .ToString("C") formats the double as a local currency string
            Console.WriteLine("Your estimated total for shipping this package is: " + costToShip.ToString("C"));
            Console.WriteLine("Thank you!");
        }
    }
}

