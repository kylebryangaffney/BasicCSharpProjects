using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    internal interface IQuittable
    {
        // i deliberately chose to use the employee instead of a person, because employees need to be able to quit a job.
        // I would make a different interface for a different way to quit something else
        public void Quit();
    }
}
