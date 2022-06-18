// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
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
 * 6. Initialize each of the classes
 * *************************************************/

namespace zyboooksInterface
{
    public class Program
    {
        public static void Main()
        {
            var student = new Student { Name = "Maria" };
            student.SayHello();
            student.Study("C#");
        }
    }
}
