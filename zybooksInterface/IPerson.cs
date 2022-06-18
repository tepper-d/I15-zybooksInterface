using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* **************************************************
 * CIS123: Introduction to Object-oriented Programming
 * Interface Assignment (Individual)
 * Dominique Tepper, 17JUN2022
 * 
 * 1-A. Complete the IPerson interface from the 
 *      ZyBooks example.
 * *************************************************/

namespace zybooksInterface
{
    public interface IPerson
    {
        public string Name { get; set; }

        public void SayHello();

        public void SayGoodbye();

    }
}
