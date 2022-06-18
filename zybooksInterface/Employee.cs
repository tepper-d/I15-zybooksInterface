using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zybooksInterface;

/* **************************************************
 * CIS123: Introduction to Object-oriented Programming
 * Interface Assignment (Individual)
 * Dominique Tepper, 17JUN2022
 * 
 * 2-B. Add an Employee class 
 * 3-B.   Instantiate the Employee class
 * 4.   Call and print 
 *          a. SayHello()
 *          b. SayGoodbye()
 * *************************************************/

namespace zybooksInterface
{
    public class Employee : IPerson
    {
        public string Name { get; set; } = "Snoop Tepper";

        public string Title { get; set; } = "Chief Security Officer";
        public string Bye { get; set; } = "Toodles!";

        public void SayHello()
        {
            Console.WriteLine($"How's it going! I'm {Name} the {Title}. How can I help?");
        }

        public void SayGoodbye()
        {
            Console.WriteLine($"{Bye}");
        }
    }
}
