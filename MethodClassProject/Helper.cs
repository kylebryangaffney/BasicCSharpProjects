using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// helper class to add 1 to a value and modify it, then print out the second value
// I chose to pass the first value in by reference in order to actually do anything to the first value AND maintain a void function. 
// I normally would have returned an int value instead of passing by reference
namespace MethodClassProject
{
    public class Helper
    {
        public void AddShow(ref int x, int y )
        {
            x = x + 1;
            Console.WriteLine("The second parameter is: " + y);
        }
    }
}
