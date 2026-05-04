
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // initialize variables
        int userIndex = 0;
        string strUserIndex = null;
        bool isValid = false;

        // build out string array
        string[] nameArray = new string[] 
        { 
            "Dexter Gordon", "Charlie Parker", "John Coltrane", "Sonny Rollins", 
            "Cannonball Adderley", "Lester Young", "Wayne Shorter", "Ornette Coleman",
            "Michael Brecker", "Stanley Turrentine"
        };

        // build out int array
        int[] numArray = new int[10];

        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = i * 16;
        }

        // build out string list
        List<string> nameList = new List<string>()
            {
                
                "Thelonious Monk","Art Tatum","Oscar Peterson","Herbie Hancock",
                "Chick Corea","Bud Powell","McCoy Tyner",
                "Duke Ellington", "Ahmad Jamal","Red Garland"
             };


        // prompt user for an index to get the string at the selected index of the string array
        Console.WriteLine("Please select an index value from 1 - 10 to see the name of a famous saxophone player: ");
        strUserIndex = Console.ReadLine();
        // check if the user entered a valid int
        isValid = int.TryParse(strUserIndex, out userIndex);
        // check if the user value is within the array range
        while (!isValid || userIndex < 1 || userIndex > nameArray.Length)
        {
            Console.WriteLine("Index value must be a whole number between 1 - 10 to see the name of a famous saxophone player: ");
            strUserIndex = Console.ReadLine();
            isValid = int.TryParse(strUserIndex, out userIndex);
        }
        // print out the string at the user's index
        Console.WriteLine(nameArray[userIndex - 1] + " was a great saxophone player who has died.");


        // get another index value from the user to print out an element from the int array.
        Console.WriteLine("Please select an index value from 0 - 9 to see the number in the numbers array that sits at the selected index ");
        strUserIndex = Console.ReadLine();
        isValid = int.TryParse(strUserIndex, out userIndex);
        
        while (!isValid || userIndex < 0 || userIndex > numArray.Length - 1)
        {
            Console.WriteLine("Index value must be a whole number between 0 - 9 to see a number stored in the array ");
            strUserIndex = Console.ReadLine();
            isValid = int.TryParse(strUserIndex, out userIndex);
        }

        // print out the number at the selected index of the int array
        Console.WriteLine(numArray[userIndex] + " is currently stored at the index of " + userIndex);

        // get an index from the user to print out an element from the string list
        Console.WriteLine("Please select an index value from 1 - 10 to see the name of a famous piano player: ");
        strUserIndex = Console.ReadLine();
        isValid = int.TryParse(strUserIndex, out userIndex);

        while (!isValid || userIndex < 1 || userIndex > nameList.Count)
        {
            Console.WriteLine("Index value must be a whole number between 1 - 10 to see the name of a famous piano player: ");
            strUserIndex = Console.ReadLine();
            isValid = int.TryParse(strUserIndex, out userIndex);

        }
        // print out the string at the index the user selected in the string list
        Console.WriteLine(nameList[userIndex - 1] + " was a great piano player who has died.");

    }
}