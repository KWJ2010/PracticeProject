using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProblems
{
    /// <summary>
    /// This class holds examples and excercises from the book "Fundamentals of Computer Programming with C# by Nakov et al"
    /// </summary>
    class FundamentalsOfComputerProgramming
    {

        /* The goal of this project is to use this class to work through the examples and excercises in this book.
         * Yes some of these examples are very simple, but I figured it would be a neat record to have.
         * In light of that goal, I will be trying to delete as few methods and method calls as possible, 
         * which means there will likely be a lot of commented out calls to those methods.
         * I will also be using regions to isolate groups of methods respective to the chapter they were written for.
         * By the end of the 1000+ page book it will also be interesting to see how this project has changed.
         */

        static void Main(string[] args)
        {
            #region Chapter 1
            WriteHello();
            //ThrowError();
            PrintCurrentDate();
            SquareRootPrint();
            SequencePrint();
            AddTenYears();
            #endregion //Chapter 1

            Console.ReadKey(); //This is to keep the dialog from closing right away w/o using ctrl + F5
        }

        #region Chapter 1 Introduction to Programming
        /// <summary>
        /// The first program people are supposed to write according to many books...
        /// </summary>
        static void WriteHello()
        {
            Console.WriteLine("Hello C#!");
        }

        /// <summary>
        /// Example of an error message
        /// </summary>
        static void ThrowError()
        {
            throw new System.NotImplementedException("This is an intended exception.");
        }

        /// <summary>
        /// Ch. 1 #8
        /// </summary>
        static void PrintCurrentDate()
        {
            Console.WriteLine(DateTime.Now);
        }

        /// <summary>
        /// Ch. 1 #9
        /// </summary>
        static void SquareRootPrint()
        {
            Console.WriteLine("The Square root of 12345 is: " + Math.Sqrt(12345));
        }

        /// <summary>
        /// Ch. 1 #10
        /// </summary>
        static void SequencePrint()
        {
            //Print first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8
            //every even is positive, odds add a minus sign
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) { Console.Write(i + ", "); }
                else { Console.Write("-" + i + ", "); }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Ch. 1 #11
        /// </summary>
        static void AddTenYears()
        {
            int age = 0;
            Console.WriteLine("How old are you? ");
            try
            {
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("In ten years you will be " + (age + 10) + " years old!");
            }
            catch
            {
                Console.WriteLine("Numbers only please!!");
                AddTenYears();
            }
        }
        #endregion // Chapter 1 Introduction to Programming

    }
}
