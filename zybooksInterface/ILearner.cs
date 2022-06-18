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
 * 1-B. Complete the ILearner interface from the 
 *      ZyBooks example.
 * *************************************************/

namespace zybooksInterface
{
    interface ILearner : IPerson
    {
        void Study(string topic);
    }

}
