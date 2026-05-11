using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    class Program
    {

        static void Main(string[] args)
        {
            // instantiate a new iquittable object
            IQuittable newGuy = new Employee() { FirstName = "New", LastName = "Guy", Id = 2 };
            // call the quit method
            newGuy.Quit();

        }
    }
}
