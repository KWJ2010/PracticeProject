﻿using System;
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
            // WriteHello();
            // ThrowError();
            // PrintCurrentDate();
            // SquareRootPrint();
            // SequencePrint();
            // AddTenYears();
            #endregion //Chapter 1

            #region Chapter 2
            // PrintPrimitives();
            // Ch2Example2();
            // Ch2Example3();
            // PrintingCharacters();
            // NullableTypes();
            // CompareTwoRealNumbers();
            // InitilizeAndDeclareDifferentTytpes();
            // PrintHeartShape();
            // PrintTriangle();
            #endregion //Chapter 2

            #region Chapter 3
            // ArithmeticalOperators();
            // LogicalOperators();
            // BitwiseOperators();
            // CompoundOperators();
            // ExplicitTypeConversion();
            // Expressions();

            #endregion //Chapter 3

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

        #region  Chapter 2 Primitive Types and Variables
        /// <summary>
        /// Print the minimum and maximum value for each primitive other than bool, object, and string
        /// </summary>
        static void PrintPrimitives()
        {
            Console.WriteLine("sbyte min = " + sbyte.MinValue + " sbyte max = " + sbyte.MaxValue);
            Console.WriteLine("byte min = " + byte.MinValue + " byte max = " + byte.MaxValue);
            Console.WriteLine("short min = " + short.MinValue + " short max = " + short.MaxValue);
            Console.WriteLine("ushort min = " + ushort.MinValue + " ushort max = " + ushort.MaxValue);
            Console.WriteLine("int min = " + int.MinValue + " int max = " + int.MaxValue);
            Console.WriteLine("uint min = " + uint.MinValue + " uint max = " + uint.MaxValue);
            Console.WriteLine("long min = " + long.MinValue + " long max = " + long.MaxValue);
            Console.WriteLine("ulong min = " + ulong.MinValue + " ulong max = " + ulong.MaxValue);
            Console.WriteLine("float min = " + float.MinValue + " float max = " + float.MaxValue);
            Console.WriteLine("float min = " + float.MinValue + " float max = " + float.MaxValue);
            Console.WriteLine("double min = " + double.MinValue + " double max = " + double.MaxValue);
            Console.WriteLine("decimal min = " + decimal.MinValue + " decimal max = " + decimal.MaxValue);
            Console.WriteLine(@"char min (\u0000) = " + char.MinValue + @" char max (\uffff) = " + char.MaxValue);
        }
        static void Ch2Example2()
        {
            //Page 114
            // Declare some variables 
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            // Print the result on the console
            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours.");
        }
        static void Ch2Example3()
        {
            float floatPI = 3.14f;
            Console.WriteLine(floatPI);// 3.14 
            double doublePI = 3.14;
            Console.WriteLine(doublePI); // 3.14 
            double nan = Double.NaN; Console.WriteLine(nan);// NaN 
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity); // Infinity

            ///
            floatPI = 3.141592653589793238f;
            doublePI = 3.141592653589793238;
            Console.WriteLine("Float PI is: " + floatPI);
            Console.WriteLine("Double PI is: " + doublePI);
            Console.WriteLine("Double PI is: " + Math.PI);

            ///
            float f = 0.1f;
            Console.WriteLine(f); // 0.1 (correct due to rounding) 
            double d = 0.1f;
            Console.WriteLine(d); // 0.100000001490116 (incorrect)
            float ff = 1.0f / 3;
            Console.WriteLine(ff); // 0.3333333 (correct due to rounding)
            double dd = ff;
            Console.WriteLine(dd); // 0.333333343267441 (incorrect)
        }
        static void PrintingCharacters()
        {
            // Declare a variable
            char ch = 'a';
            // Print the results on the console 
            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            ch = 'b';
            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';
            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            // Console output:
            // The code of 'a' is: 97 
            // The code of 'b' is: 98 
            // The code of 'A' is: 65

            // An ordinary character
            char character = 'a';
            Console.WriteLine(character);
            // Unicode character code in a hexadecimal format
            character = '\u003A';
            Console.WriteLine(character);
            // Assigning the single quotiation character (escaped as \') 
            character = '\'';
            Console.WriteLine(character);
            // Assigning the backslash character (escaped as \\)
            character = '\\';
            Console.WriteLine(character);
            // Console output: // a // : // ' // \

            Console.WriteLine("type a character to see its int representation:");
            try
            {
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            }
            catch
            {
                Console.WriteLine("Characters only please!!");
                PrintingCharacters();
            }
        }
        static void NullableTypes()
        {
            int i = 5;
            int? ni = i;
            Console.WriteLine(ni); // 5
            // i = ni; 
            // this will fail to compile 
            Console.WriteLine(ni.HasValue);// True
            i = ni.Value;
            Console.WriteLine(i); // 5
            ni = null;
            Console.WriteLine(ni.HasValue);// False 
            //i = ni.Value; // System.InvalidOperationException 
            i = ni.GetValueOrDefault();
            Console.WriteLine(i); // 0
        }

        /// <summary>
        /// Ch. 2 #3
        /// </summary>
        static void CompareTwoRealNumbers()
        {
            //Compare correctly two real numbers with accuracy to at lest 0.000001 
            float number1 = 0f;
            float number2 = 0f;
            //Get numbers to compare
            Console.WriteLine("enter first number to compare: ");
            try { number1 = float.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Real numbers only please!!"); }
            Console.WriteLine("enter second number to compare: ");
            try { number2 = float.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Real numbers only please!!"); }

            //Compare if they are "equal" to the accuracy stated by the question requirements and display the result
            bool equal = Math.Abs(number1 - number2) < 0.000001;
            if (equal) Console.WriteLine(number1 + "Is equal to " + number2);
            else Console.WriteLine(number1 + "Is NOT equal to " + number2);
        }

        /// <summary>
        /// Ch. 2 # 4,5,6,7,8,13
        /// </summary>
        static void InitilizeAndDeclareDifferentTytpes()
        {
            //4 Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
            int _int = 0x64;
            Console.WriteLine(_int);

            //5 Declare a variable of type char and assign it as a value the character, which has Unicode code, 72(use the Windows calculator in order to find hexadecimal representation of 72).
            char _char = (char)0x48;// = h //or 0x72 = r question is not clear
            Console.WriteLine(_char);

            //6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
            bool isMale = true;

            //7. Declare two variables of type string with values "Hello" and "World". 
            //Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. 
            //Print the variable of type object.
            string H = "Hello";
            string W = "World";

            object o = H + " " + W;
            Console.WriteLine(o);

            //8. Declare two variables of type string and give them values "Hello" and "World". 
            //Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. 
            //Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).

            //Using H, W, and o above...
            string s = (string)o;
            Console.WriteLine(s);

            //13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them
            int _int1 = 5;
            int _int2 = 10;
            Console.WriteLine(_int1 + ", " + _int2);
            int temp = _int1;
            _int1 = _int2;
            _int2 = temp;
            Console.WriteLine(_int1 + ", " + _int2);

            //Alternate version w/o temporary variable
            int _int3 = 5;
            int _int4 = 10;
            Console.WriteLine(_int3 + ", " + _int4);
            _int3 = _int3 + _int4;
            _int4 = _int3 - _int4;
            _int3 = _int3 - _int4;
            Console.WriteLine(_int3 + ", " + _int4);

            //XOR swap 1
            int x = 5;
            int y = 10;
            Console.WriteLine(x + ", " + y);
            x ^= y;
            y ^= x;
            x ^= y;
            Console.WriteLine(x + ", " + y);

            //XOR swap 2
            x = 5;
            y = 10;
            Console.WriteLine(x + ", " + y);
            x ^= y ^ (y = x);
            Console.WriteLine(x + ", " + y);

        }

        /// <summary>
        /// Ch. 2 #10
        /// </summary>
        static void PrintHeartShape()
        {
            //10. Write a program to print a figure in the shape of a heart by the sign "o".
            char degreeSign = (char)176;
            Console.WriteLine();
            Console.WriteLine("  " + degreeSign + degreeSign + "  " + degreeSign + degreeSign);
            Console.WriteLine(" " + degreeSign + degreeSign + degreeSign + degreeSign + degreeSign + degreeSign + degreeSign + degreeSign);
            Console.WriteLine("  " + degreeSign + degreeSign + degreeSign + degreeSign + degreeSign + degreeSign);
            Console.WriteLine("   " + degreeSign + degreeSign + degreeSign + degreeSign);
            Console.WriteLine("    " + degreeSign + degreeSign);
            Console.WriteLine("     " + degreeSign);
            Console.WriteLine();
        }

        /// <summary>
        /// Ch. 2 #11
        /// </summary>
        static void PrintTriangle()
        {
            //11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            char CopyrightSign = '©';
            Console.WriteLine();
            Console.WriteLine("     " + CopyrightSign);
            Console.WriteLine("    " + CopyrightSign + CopyrightSign + CopyrightSign);
            Console.WriteLine("   " + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign);
            Console.WriteLine("  " + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign);
            Console.WriteLine(" " + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign);
            Console.WriteLine("" + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign + CopyrightSign);
            Console.WriteLine();
        }
        #endregion //Chapter 2 PRimitive Types and Variables

        #region Chapter 3 Operators and Expressions
        /// <summary>
        /// Page 143
        /// </summary>
        static void ArithmeticalOperators()
        {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide); // 4.25
            Console.WriteLine(squareArea); // 18.0625
            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // 9
            Console.WriteLine(a + (b++)); // 9
            Console.WriteLine(a + b); // 10
            Console.WriteLine(a + (++b)); // 11
            Console.WriteLine(a + b); // 11
            Console.WriteLine(14 / a); // 2
            Console.WriteLine(14 % a); // 4
            int one = 1;
            int zero = 0;
            // Console.WriteLine(one / zero); // DivideByZeroException
            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero); // -Infinity
            Console.WriteLine(one / dZero); // Infinity
        }
        /// <summary>
        /// Page 144
        /// </summary>
        static void LogicalOperators()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b); // False
            Console.WriteLine(a || b); // True
            Console.WriteLine(!b); // True
            Console.WriteLine(b || true); // True
            Console.WriteLine((5 > 7) ^ (a == b)); // False

            // Laws of De Morgan
            // !(a && b) == (!a || !b)
            // !(a || b) == (!a && !b)
        }
        /// <summary>
        /// Page 147
        /// </summary>
        static void BitwiseOperators()
        {
            byte a = 3; // 0000 0011 = 3 
            byte b = 5; // 0000 0101 = 5 
            Console.WriteLine(a | b); // 0000 0111 = 7
            Console.WriteLine(a & b); // 0000 0001 = 1 
            Console.WriteLine(a ^ b); // 0000 0110 = 6
            Console.WriteLine(~a & b); // 0000 0100 = 4 
            Console.WriteLine(a << 1); // 0000 0110 = 6 
            Console.WriteLine(a << 2); // 0000 1100 = 12
            Console.WriteLine(a >> 1); // 0000 0001 = 1
        }
        /// <summary>
        /// Page 150
        /// </summary>
        static void CompoundOperators()
        {
            int x = 6;
            int y = 4;
            Console.WriteLine(y *= 2); // 8 
            int z = y = 3; // y=3 and z=3 
            Console.WriteLine(z); // 3 
            Console.WriteLine(x |= 1); // 7  // x = 6 |= 1
            Console.WriteLine(x += 3); // 10 // x = 7+3
            Console.WriteLine(x /= 2); // 5  // x = x/2
        }
        /// <summary>
        /// Page 155
        /// </summary>
        static void ExplicitTypeConversion()
        {
            double myDouble = 5.1d;
            Console.WriteLine(myDouble); // 5.1 
            long myLong = (long)myDouble;
            Console.WriteLine(myLong); // 5 
            myDouble = 5e9d; // 5 * 10^9
            Console.WriteLine(myDouble); // 5000000000 
            int myInt = (int)myDouble;
            Console.WriteLine(myInt); // -2147483648 
            Console.WriteLine(int.MinValue); // -2147483648

            myLong = long.MaxValue;
            myInt = (int)myLong;
            Console.WriteLine(myLong); // 9223372036854775807 
            Console.WriteLine(myInt); // -1

            float heightInMeters = 1.74f; // Explicit conversion 
            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double)heightInMeters; // Explicit 
            float actualHeight = (float)maxHeight; // Explicit 
                                                   // float maxHeightFloat = maxHeight; // Compilation error!
        }
        /// <summary>
        /// Page 158
        /// </summary>
        static void Expressions()
        {
            int r = (150 - 20) / 2 + 5;
            // Expression for calculating the surface of the circle
            double surface = Math.PI * r * r;

            // Expression for calculating the perimeter of the circle 
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine(r);
            Console.WriteLine(surface);
            Console.WriteLine(perimeter);

            int a = 5;
            int b = ++a;
            Console.WriteLine(a); // 6
            Console.WriteLine(b); // 6

            // First example 
            double d = 1 / 2;
            Console.WriteLine(d); // 0, not 0.5 

            // Second example
            double half = (double)1 / 2;
            Console.WriteLine(half); // 0.5
        }
        /// <summary>
        /// Checks if input integer is odd or even and returns true if odd
        /// </summary>
        /// <returns></returns>
        static bool IsOdd(int _integer)
        {
            if (_integer % 2 == 0)
            {
                return false;
            }
            else return true;

        }
        /// <summary>
        /// Excercises 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
        /// </summary>
        static void Ch3Exercise()
        {
            // 1.Write an expression that checks whether an integer is odd or even.
            Console.WriteLine(IsOdd(5));

            //2.Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.


            // 3.Write an expression that looks for a given integer if its third digit (right to left) is 7.


            //4.Write an expression that checks whether the third bit in a given integer is 1 or 0.


            //5.Write an expression that calculates the area of a trapezoid by given sides a, b and height h.


            //6.Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.


            //7.The gravitational field of the Moon is approximately 17 % of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


            //8.Write an expression that checks for a given point { x, y}
            // if it is within the circle K({ 0, 0}, R = 5). Explanation: the point { 0, 0} is the center of the circle and 5 is the radius.


            //9.Write an expression that checks for given point { x, y}
            // if it is within the circle K({ 0, 0}, R = 5) and out of the rectangle[{ -1, 1}, { 5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.


            //10.Write a program that takes as input a four - digit number in format abcd(e.g. 2011) and performs the following actions:
            //-Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
            //- Prints on the console the number in reversed order: dcba(in our example 1102).
            //- Puts the last digit in the first position: dabc(in our example 1201).
            //- Exchanges the second and the third digits: acbd(in our example 2101).

            //11.We are given a number n and a position p.Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n = 35, p = 5-> 1.Another example: n = 35, p = 6-> 0.
            
            
            //12.Write a Boolean expression that checks if the bit on position p in the integer v has the value 1.Example v = 5, p = 1-> false.
            
            
            //13.We are given the number n, the value v(v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n = 35, p = 5, v = 0->n = 3.Another example: n = 35, p = 2, v = 1->n = 39.
            
            
            //14.Write a program that checks if a given number n(1 < n < 100) is a prime number (i.e.it is divisible without remainder only to itself and 1).
           
            
            //15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32 - bit unsigned integer.
           
            
            //16. * Write a program that exchanges bits { p, p + 1, …, p + k - 1}
            //            with bits { q, q + 1, …, q + k - 1}
            //            of a given 32 - bit unsigned integer.
        }


        #endregion //Chapter 3 Operators and Expressions
    }
}
