using System;

namespace BooleanComparison
{

    class Program
    {
        // Function that is only called once, but It compares the user guess against the correct answer '6'
        static bool CheckValue(int value)
        {
            return value == 6;
        }
        static void Main()
        {
            // initial variable declaration and first interaction with user
            bool isGuessed = false;
            int intGuess = 0;
            string userGuess = null;

            Console.WriteLine("Welcome to the number guessing game 9000");

            Console.WriteLine("Please guess a number between 1 and 10: ");
            userGuess = Console.ReadLine();
            intGuess = Convert.ToInt32(userGuess);

            // initial while loop to prompt the user to guess inside the range only if needed
            while (intGuess < 1 || intGuess > 10)
            {
                Console.WriteLine("Guess Out of range. Please guess a value from 1 to 10");
                userGuess = Console.ReadLine();
                intGuess = Convert.ToInt32(userGuess);

            }

            // do while to keep prompting the user until they guess correctly
            do
            {
                switch (intGuess)
                {
                    // user correctly guesses
                    case 6:
                        Console.WriteLine("Correct You typed " + intGuess);
                        isGuessed = CheckValue(intGuess);
                        break;
                    
                    // user did not correctly guess 
                    default:
                        Console.WriteLine(intGuess + " is not a correct guess.");
                        userGuess = Console.ReadLine();
                        intGuess = Convert.ToInt32(userGuess);
                        break;
                }
            }
            while (!isGuessed);
        }
    }
}
