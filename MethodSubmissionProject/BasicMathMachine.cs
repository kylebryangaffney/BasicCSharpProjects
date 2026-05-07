using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// class to add two int values and return an int, if the user only enters 1 value, then the default adds 10
namespace MethodSubmissionProject
{
    public class BasicMathMachine
    {
        public int AddNumbers(int x, int y = 10)
        {
            return x + y;
        }
    }
}
