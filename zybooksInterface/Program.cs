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
 * 5. Instantiate each of the classes
 * *************************************************/

// Employee
var employee1 = new Employee {};
employee1.SayHello();
employee1.SayGoodbye();

Employee employee2 = new Employee ();
employee2.Title = "Public Relations Officer";
employee2.Bye = "Sayonara!";
employee2.SayHello();
employee2.SayGoodbye();


//Student
Student student1 = new Student();
student1.Name = "Alexis Mateo";
student1.Major = "Textile Design";
student1.CatchPhrase = "BAM!";
student1.SayHello();
student1.Study("");
student1.SayGoodbye();

Student student2 = new Student();
student2.Name = "Bob T. D. Queen";
student2.Major = "Film and Theater Science";
student2.CatchPhrase = "Purse First!";
student2.SayHello();
student2.Study("");
student2.SayGoodbye();

var student3 = new Student { };
student3.SayHello();
student3.Study("");
student3.SayGoodbye();
