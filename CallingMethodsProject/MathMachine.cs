using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsProject
{
    // class to perform basic math functions recieving and returning an int value
    public class MathMachine
    {
        public int SubtractFive(int x)
        {
            return x - 5;
        }
        public int AddFive(int x)
        {
            return x + 5;
        }

        public int MultiplyFive(int x)
        {
            return x * 5;
        }

    }
}
