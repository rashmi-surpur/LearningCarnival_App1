using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// The main entry point for the console application. This class contains the `Main` method that is executed first when the program is run. 
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            //Create a object of Student class from Student.cs file and print details of the student
            Student student = new Student();
            student.PrintDetails();


            Console.ReadLine();
        }


        //Code Starts here

        public int AddAndPrint(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"El resultado de sumar {num1} y {num2} es: {result}");
            return result;
        }
       







        public void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i < 5)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i + 1);

            }
        }
    }
}




