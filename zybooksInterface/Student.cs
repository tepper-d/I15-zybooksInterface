﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* **************************************************
 * CIS123: Introduction to Object-oriented Programming
 * Interface Assignment (Individual)
 * Dominique Tepper, 17JUN2022
 * 
 * 2-A. Add a Student class 
 * 3-A. Instantiate the Student class
 * 4.   Call and print 
 *          a. SayHello()
 *          b. Study()
 *          c. SayGoodbye()
 * *************************************************/

namespace zybooksInterface
{
    class Student : ILearner
    {
        public string Name { get; set; } = "John Doe";

        public void SayHello()
        {
            Console.WriteLine($"Hi! I'm {Name}!");
        }

        public void Study(string topic)
        {
            Console.WriteLine($"I'm studying {topic}.");
        }
    }
}
