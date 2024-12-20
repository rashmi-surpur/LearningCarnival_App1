using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //define the class Student with Rollno, Name , Semister, Address as filelds , include 
    //default constructor to initalize all fields to default values
    public class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public string Address { get; set; }

        //Default constructor
        public Student()
        {
            Rollno = 100;
            Name = "Student1";
            Semester = 1;
            Address = "";
        }

        //write a function to print details os a student

        public void PrintDetails()
        {
            Console.WriteLine($"Roll number: {Rollno}\nName: {Name}\nSemester: {Semester}\nAddress: {Address}");
        }
    }


}

