using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        // build a string array of dog breeds 
        string[] dogArray = new string[]
        {
            "Labrador Retriever",
            "German Shepherd",
            "Golden Retriever",
            "French Bulldog",
            "Beagle",
            "Poodle",
            "Rottweiler",
            "Dachshund",
            "Pembroke Welsh Corgi",
            "Siberian Husky"
        };
        // declare the user input variable
        string userInput = null;

        // get user input as a string
        Console.WriteLine("Please input a name for a dog: ");
        userInput = Console.ReadLine();

        // iterate through the array and append the user input to the end of each string element in the dog breed array
        for (int i = 0; i < dogArray.Length; i++)
        {
            dogArray[i] = dogArray[i] + " named: " + userInput;
        }

        // iterate through the string array and print out each element
        foreach (string breed in dogArray)
        {
            Console.WriteLine(breed);
        }

        // iterate through while loop checking if we have exceeded the length of the array and print the element to the console
        int j = 0;
        while (j < dogArray.Length)
        {
            Console.WriteLine("The " + j + " index in the array has: " + dogArray[j]);
            j++;
        }

        // iterate through the array and remove the user's string from the end of the array
        for (int k = 0; k <= dogArray.Length - 1; k++)
        {
            dogArray[k] = dogArray[k].Remove(dogArray[k].Length - (userInput.Length + 9));
        }
        // print updated array elements
        foreach (string breed in dogArray)
        {
            Console.WriteLine(breed);
        }


        // build a list of strings
        List<string> saxophoneList = new List<string>() {"soprano", "alto", "tenor", "baritone"};
        // prompt the user to input a saxophone type name
        Console.WriteLine("Please input the name of a saxophone type (\"soprano\", \"alto\", \"tenor\", \"baritone\"): ");
        // get user input
        userInput = Console.ReadLine().ToLower();
        // boolean flag for telling the user if their input was not in the list
        bool isFound = false;

        for (int i = 0; i < saxophoneList.Count; i++)
        {
            if (saxophoneList[i] == userInput)
            {
                // print out the index of the user input
                Console.WriteLine("You selected a saxophone type at index: " + saxophoneList.IndexOf(userInput));
                isFound = true;
                break;
            }
        }    
        // if the user input was not in the list, then tell them
        if (!isFound)
        {
            Console.WriteLine("You did not provide a saxophone type on the list.");
        }

        // build out list with 2 identical string entries
        isFound = false;
        List<string> instrumentList = new List<string>()
        {
            "saxophone",
            "trumpet",
            "trombone",
            "piano",
            "bass",
            "drums",
            "guitar",
            "bass"
        };

        // get input from user
        Console.WriteLine("Please input the name of a common jazz instrument: ");
        userInput = Console.ReadLine().ToLower();
        // iterate through each element in the list, and check if it matches the user intput
        for (int i = 0; i < instrumentList.Count; i++)
        {
            if (instrumentList[i] == userInput)
            {
                // print out the index of the user input
                Console.WriteLine("You selected a " + userInput + " which is at index: " + i);
                isFound = true;
            }
        }
        // tell the user if their input was not on the list
        if (!isFound)
        {
            Console.WriteLine("You did not provide an instrument type on the list.");
        }

        // list of strings with a pair of duplicates
        List<string> genreList = new List<string>()
        {
            "jazz",
            "classical",
            "hip hop",
            "electronic",
            "rock",
            "reggae",
            "folk",
            "rock",
            "country",
            "funk"
        };

        // for each loop to iterate through string list
        foreach (string genre in genreList)
        {
            // iterate through the list again with the Count method and tally how many times the current genre is in the list
            if (genreList.Count(g => g == genre) > 1)
            {
                Console.WriteLine(genre + " is a duplicate in the list");
            }
            else 
            {
                Console.WriteLine(genre + " is unique in the list");
            }
        }

    }
}


