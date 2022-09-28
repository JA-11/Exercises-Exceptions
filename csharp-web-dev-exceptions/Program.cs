using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercises for the Exceptions Chapter

namespace Exercises_Exceptions.csharp_web_dev_exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName", "No work was submitted!");
            }
            else
            {
                if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                double x = 86.4;
                double y = 0.0;

                Divide(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            students.Add("John", "Temp");
            students.Add("Kelly","");

            foreach(var student in students)
            {
                
                try
                {
                    CheckFileExtension(student.Value);
                    Console.WriteLine(CheckFileExtension(student.Value));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
    }
}
