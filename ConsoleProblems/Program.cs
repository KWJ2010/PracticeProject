using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        #region Variables for Chapter 10
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static long[] numbers;
        #endregion // Variables for Chapter 10

        static void Main(string[] args)
        {
            #region Chapter 1
            // WriteHello();
            //// ThrowError();
            // PrintCurrentDate();
            //SquareRootPrint();
            // SequencePrint();
            // AddTenYears();
            #endregion //Chapter 1

            #region Chapter 2
            //PrintPrimitives();
            //Ch2Example2();
            //Ch2Example3();
            //PrintingCharacters();
            //NullableTypes();
            //CompareTwoRealNumbers();
            //InitilizeAndDeclareDifferentTytpes();
            //PrintHeartShape();
            //PrintTriangle();
            #endregion //Chapter 2

            #region Chapter 3
            // ArithmeticalOperators();
            // LogicalOperators();
            // BitwiseOperators();
            // CompoundOperators();
            // ExplicitTypeConversion();
            // Expressions();
            // Ch3Exercise();
            #endregion //Chapter 3

            #region Chapter 4
            //skipped for now
            #endregion //Chapter 4

            /* Skipped ahead a bit to Recursion in chapter 10*/

            #region Chapter 10
            //FactoralExample1();
            //FactoralExample2();
            // RecursiveNestedLoopExample();
            // IterativeNestedLoopExample();
            //BadFibonacciExample();
            //FibonacciEfficentRecursionExample();
            #endregion // Chapter 10


            // FindMultiplesInRange();
            //  CallBubbleSort();
            //  CodilityPracticeQuestion();
            CallCodilityRealQuestion1();
           // CallCodilityRealQuestion2();

            Console.ReadKey(); //This is to keep the dialog from closing right away w/o using ctrl + F5
        }
        static void CallCodilityRealQuestion1()
        {

        }












        static void CallCodilityRealQuestion2()
        {

        }






        static void CallBubbleSort()
        {
            Console.WriteLine("list of integers to be sorted");
            int[] a = { 99, 50, 96, 770, 89, 1000, 357, 821, 362, 322, 632, 716, 513, 297, 944, 81, 84, 234, 400, 840, 902, 238, 782, 760, 910, 74, 174, 833, 570, 580, 862, 519, 127, 831, 248, 245, 49, 549, 183, 628, 891, 685, 51, 463, 339, 710, 546, 736, 517, 957, 120, 787, 650, 361, 464, 483, 982, 275, 348, 929, 753, 524, 810, 184, 825, 861, 888, 512, 54, 969, 715, 29, 541, 758, 707, 553, 748, 898, 279, 158, 783, 427, 593, 866, 934, 930, 651, 909, 318, 175, 631, 460, 409, 663, 603, 83, 590, 814, 966, 634, 70, 280, 989, 401, 368, 596, 287, 242, 893, 978, 124, 610, 435, 147, 224, 237, 913, 332, 99, 198, 817, 273, 809, 820, 996, 722, 611, 518, 257, 34, 281, 725, 143, 37, 867, 578, 653, 447, 637, 166, 599, 5, 601, 161, 87, 231, 640, 232, 494, 849, 14, 859, 884, 379, 378, 829, 420, 365, 873, 548, 904, 933, 958, 467, 167, 501, 298, 720, 680, 258, 602, 747, 735, 871, 459, 687, 403, 82, 566, 728, 269, 514, 543, 142, 612, 848, 921, 104, 836, 85, 103, 790, 42, 223, 396, 564, 417, 90, 236, 61, 705, 792, 837, 994, 803, 619, 528, 752, 717, 333, 308, 567, 647, 779, 550, 731, 565, 471, 381, 679, 105, 260, 504, 613, 807, 134, 744, 887, 138, 300, 979, 310, 438, 561, 48, 53, 487, 511, 493, 589, 244, 903, 520, 360, 697, 31, 122, 765, 552, 328 };
            BubbleSort(a);
        }
        static void BubbleSort<T>(IList<T> list)
        {
            BubbleSort<T>(list, Comparer<T>.Default);
        }

        static void BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            bool stillGoing = true;
            while (stillGoing)
            {
                stillGoing = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    T x = list[i];
                    T y = list[i + 1];
                    if (comparer.Compare(x, y) > 0)
                    {
                        list[i] = y;
                        list[i + 1] = x;
                        stillGoing = true;
                    }
                }
            }
        }
        //static void BubbleSort(int[] A)
        //{
        //    IComparer<T> comparer;
        //    bool StillSorting = true;
        //    while (StillSorting)
        //    {
        //        StillSorting = false;
        //        for (int i = 0; i < A.Length-1; i++)
        //        {
        //            int x = A[i];
        //            int y = A[i + 1];
        //            if (comparer.Compare(x, y) > 0)
        //            {
        //                A[i] = y;
        //                A[i + 1] = x;
        //                StillSorting = true;
        //            }
        //        }
        //    }

        //}

        static void CodilityPracticeQuestion()
        {
            BinaryGap(456546);
        }

        static int BinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);
            Regex regex = new Regex("1(.*)1");
            Match chars = regex.Match(binary);
            string binaryAfterRegex = chars.Value;
            string[] gaps = binaryAfterRegex.Split('1');
            int t = 0;
            foreach (string txt in gaps)
            {
                if ((string.IsNullOrEmpty(txt)) == false)
                {
                    while (txt.Length > t)
                    {
                        t = txt.Length;
                    }
                }
            }
            return t;
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
        static bool IsDevideableBy5and7(int _int)
        {
            //Option 1
            // if (_int % 5 == 0 && _int % 7 == 0) { return true; }
            // else return false;

            // Option 2
            if (_int % 35 == 0) { return true; }
            else return false;
        }
        static bool IsThirdDigit7(int _int)
        {
            int firstStep = _int / 100;
            if (firstStep % 10 == 7) { return true; }
            else return false;
        }
        static void CheckDigitLocation()
        {
            Console.WriteLine("Enter number to be check if the third digit (right to left) is 7");
            int CheckDigits = 0;
            try { CheckDigits = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); }
            Console.WriteLine(IsThirdDigit7(CheckDigits));
            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void CheckDigitBit()
        {
            Console.WriteLine("Enter number to be check if the third bit is 0 or 1");
            int CheckBits = 0;
            try { CheckBits = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); }
            bool IsBit3 = (CheckBits & 8) != 0;
            if (IsBit3) { Console.WriteLine("The third bit of " + CheckBits + " is 1"); }
            else Console.WriteLine("The third bit of " + CheckBits + " is 0");
            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void CalculateAreaOfTrapizoid()
        {
            Console.WriteLine("Enter number for length of side a");
            int _a = 0;
            try { _a = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CalculateAreaOfTrapizoid(); }

            Console.WriteLine("Enter number for length of side b");
            int _b = 0;
            try { _b = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CalculateAreaOfTrapizoid(); }

            Console.WriteLine("Enter number for height of side h");
            int _h = 0;
            try { _h = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CalculateAreaOfTrapizoid(); }

            Console.WriteLine("The area is: " + ((_a + _b) * _h / 2));

            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void CalculatePrimeterAndAreaRectangle()
        {
            Console.WriteLine("Enter number for length of side a");
            int _a = 0;
            try { _a = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CalculatePrimeterAndAreaRectangle(); }

            Console.WriteLine("Enter number for length of side b");
            int _b = 0;
            try { _b = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CalculatePrimeterAndAreaRectangle(); }

            int perimeter = (_a * 2) + (_b * 2);
            int area = _a * _b;
            Console.WriteLine("the perimeter is: " + perimeter + ", The area is: " + area);

            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void CalculatMoonGravity()
        {
            Console.WriteLine("Enter weight for human on Earth");
            int _mass = 0;
            try { _mass = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CalculatMoonGravity(); }
            Console.WriteLine("The humans weight on the moon would be " + (_mass * 0.17));
            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void CircleCheck(bool isRectangleToo)
        {
            Console.WriteLine("Enter x coordinate");
            int _x = 0;
            try { _x = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); Ch3Exercise(); }

            Console.WriteLine("Enter y coordinate");
            int _y = 0;
            try { _y = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); Ch3Exercise(); }
            if (((_x * _x) + (_y * _y)) <= 5 * 5)
            {
                Console.WriteLine("the point  (" + _x + "," + _y + ") is within the circle of R = 5");
                if (isRectangleToo)
                {
                    if (_x >= -1 && _x <= 5 && _y >= 1 && _y <= 5)
                    {
                        Console.WriteLine("the point  (" + _x + "," + _y + ") is within the rectangle [{ -1, 1}, { 5, 5}] ");
                    }
                    else Console.WriteLine("the point  (" + _x + "," + _y + ") is outside the rectangle [{ -1, 1}, { 5, 5}] ");
                }
            }
            else
            {
                Console.WriteLine("the point  (" + _x + "," + _y + ") is outside the circle of R = 5");
                if (isRectangleToo)
                {
                    if (_x >= -1 && _x <= 5 && _y >= 1 && _y <= 5)
                    {
                        Console.WriteLine("the point  (" + _x + "," + _y + ") is within the rectangle [{ -1, 1}, { 5, 5}] ");
                    }
                    else Console.WriteLine("the point  (" + _x + "," + _y + ") is outside the rectangle [{ -1, 1}, { 5, 5}] ");
                }
            }

            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void Chapter3Problem10()
        {
            Console.WriteLine("Enter a 4 digit number");
            int _fourDigits = 0;
            try { _fourDigits = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type a four digit integer"); Chapter3Problem10(); }
            int a = _fourDigits % 10;
            int b = (_fourDigits / 10) % 10;
            int c = (_fourDigits / 100) % 10;
            int d = (_fourDigits / 1000) % 10;
            int sum = a + b + c + d;
            Console.WriteLine("The sum of the digits is " + sum);
            Console.WriteLine(d.ToString() + c.ToString() + b.ToString() + a.ToString());
            Console.WriteLine(d.ToString() + a.ToString() + b.ToString() + c.ToString());
            Console.WriteLine(a.ToString() + c.ToString() + b.ToString() + d.ToString());
            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void Chapter3Problem11()
        {
            Console.WriteLine("Enter a number");
            int _n = 0;
            try { _n = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); Chapter3Problem11(); }
            Console.WriteLine("Enter a position");
            int _p = 0;
            try { _p = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); Chapter3Problem11(); }

            int i = 1; // 00000001
            int mask = i << _p; // Move the 1-st bit left by p positions 
            // If i & mask are positive then the p-th bit of n is 1
            Console.WriteLine((_n & mask) != 0 ? 1 : 0);
            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static void Chapter3Problem12()
        {
            Console.WriteLine("Enter a number");
            int _n = 0;
            try { _n = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); Chapter3Problem12(); }
            Console.WriteLine("Enter a position");
            int _p = 0;
            try { _p = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); Chapter3Problem12(); }

            if (IsbitPofV0(_n, _p)) { Console.WriteLine("The bit on position " + _p + " is 0"); }
            else { Console.WriteLine("The bit on position " + _p + " is 1"); }
            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static bool IsbitPofV0(int v, int p)
        {
            int i = 1; // 00000001
            int mask = i << p; // Move the 1-st bit left by p positions 
            // If i & mask are positive then the p-th bit of n is 1
            if (v == 0 && i == 0) return true;
            else return false;
        }
        static void Chapter3Problem13()
        {

        }
        static void CheckIfPrime()
        {
            Console.WriteLine("Enter a number between 1 and 100 to check if it is prime");
            int _n = 0;
            try { _n = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Please type an integer"); CheckIfPrime(); }
            bool IsPrime = CheckIsPrime(_n);
            if (IsPrime) Console.WriteLine(_n + " is a prime number");
            else Console.WriteLine(_n + " is not a prime number");

            if (IsContinueThisProgram()) Ch3Exercise();
        }
        static bool CheckIsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        /// <summary>
        /// Excercises 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
        /// </summary>
        static void Ch3Exercise()
        {
            // 1.Write an expression that checks whether an integer is odd or even.
            //Console.WriteLine(IsOdd(5));

            //2.Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
            //Console.WriteLine("Enter number to be check if divisible by both 5 and 7");
            //int devideme = 0;
            //try { devideme = int.Parse(Console.ReadLine()); }
            //catch { Console.WriteLine("Please type an Integer"); }
            //Console.WriteLine(IsDevideableBy5and7(devideme));
            //Ch3Exercise();

            // 3.Write an expression that looks for a given integer if its third digit (right to left) is 7.
            // CheckDigitLocation();


            //4.Write an expression that checks whether the third bit in a given integer is 1 or 0.
            //CheckDigitBit();

            //5.Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
            //CalculateAreaOfTrapizoid();

            //6.Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            //CalculatePrimeterAndAreaRectangle();

            //7.The gravitational field of the Moon is approximately 17 % of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
            //CalculatMoonGravity();

            //8.Write an expression that checks for a given point { x, y}
            // if it is within the circle K({ 0, 0}, R = 5). Explanation: the point { 0, 0} is the center of the circle and 5 is the radius.
            // CircleCheck(false);

            //9.Write an expression that checks for given point { x, y}
            // if it is within the circle K({ 0, 0}, R = 5) and out of the rectangle[{ -1, 1}, { 5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
            //CircleCheck(true);

            //10.Write a program that takes as input a four - digit number in format abcd(e.g. 2011) and performs the following actions:
            //-Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
            //- Prints on the console the number in reversed order: dcba(in our example 1102).
            //- Puts the last digit in the first position: dabc(in our example 1201).
            //- Exchanges the second and the third digits: acbd(in our example 2101).
            //Chapter3Problem10();

            //11.We are given a number n and a position p.Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n = 35, p = 5-> 1.Another example: n = 35, p = 6-> 0.
            //Chapter3Problem11();

            //12.Write a Boolean expression that checks if the bit on position p in the integer v has the value 1.Example v = 5, p = 1-> false.
            //Chapter3Problem12();


            //13.We are given the number n, the value v(v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v.
            //Example: n = 35, p = 5, v = 0->n = 3.Another example: n = 35, p = 2, v = 1->n = 39.
            //skipped //TODO: this problem

            //14.Write a program that checks if a given number n(1 < n < 100) is a prime number (i.e.it is divisible without remainder only to itself and 1).
            //CheckIfPrime();

            //15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32 - bit unsigned integer.
            //skipped //TODO: this problem

            //16. * Write a program that exchanges bits { p, p + 1, …, p + k - 1}
            //            with bits { q, q + 1, …, q + k - 1}
            //            of a given 32 - bit unsigned integer.
            //skipped //TODO: this problem

        }
        #endregion //Chapter 3 Operators and Expressions

        #region Chapter 4 Console Input and Output

        #endregion //Chapter 4 Console Input and Output

        #region Chapter 10 Recursion
        static decimal FactorialRecursion(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n * FactorialRecursion(n - 1);
            }
        }
        static decimal FactorialIteration(int n)
        {
            decimal result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
        static void FactoralExample1()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = FactorialRecursion(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
            if (IsContinueThisProgram()) FactoralExample1();
        }
        static void FactoralExample2()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = FactorialIteration(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
            if (IsContinueThisProgram()) FactoralExample2();
        }
        static void RecursiveNestedLoopExample()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoopsRecursive(0);
        }

        static void NestedLoopsRecursive(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoopsRecursive(currentLoop + 1);
            }
        }
        static void IterativeNestedLoopExample()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoopsIterative();
        }
        static void NestedLoopsIterative()
        {
            InitLoops();
            int currentPosition;
            while (true)
            {
                PrintLoops();
                currentPosition = numberOfLoops - 1;
                loops[currentPosition] = loops[currentPosition] + 1;
                while (loops[currentPosition] > numberOfIterations)
                {
                    loops[currentPosition] = 1;
                    currentPosition--;
                    if (currentPosition < 0)
                    {
                        return;
                    }
                    loops[currentPosition] = loops[currentPosition] + 1;
                }
            }
        }
        static void InitLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                loops[i] = 1;
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
        static void BadFibonacciExample()
        {
            //O^n
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            long result = FibBad(n);
            Console.WriteLine("fib({0}) = {1}", n, result);
        }
        static void FibonacciEfficentRecursionExample()
        {
            //O+n 
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;
            long result = Fib(n);
            Console.WriteLine("fib({0}) = {1}", n, result);
        }
        static long FibBad(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return FibBad(n - 1) + FibBad(n - 2);
        }
        static long Fib(int n)
        {
            if (0 == numbers[n])
            {
                numbers[n] = Fib(n - 1) + Fib(n - 2);
            }
            return numbers[n];
        }
        #endregion // Chapter 10 Recursion

        static bool IsContinueThisProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Do you wish to repeat this program? (y or n)");
            string _Answer = "";
            try { _Answer = Console.ReadLine(); Console.WriteLine();}
            catch { Console.WriteLine("Please type a y or n"); IsContinueThisProgram(); }
            if (_Answer == "y" || _Answer == "Y" || _Answer == "yes" || _Answer == "Yes") return true;
            else return false;
        }


        static void FindMultiplesInRange()
        {
            Console.WriteLine("Return the number of integers within the range [A..B] that are divisible by K.");
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int count = solution(a,b,k);

            Console.WriteLine("Within the range[" + a.ToString() + ".." + b.ToString() + "] There are " + count.ToString() + " that are divisible by " + k.ToString() + ".");
            if (IsContinueThisProgram()) FindMultiplesInRange();
        }

        /// <summary>
        /// Return the number of integers within the range [A..B] that are divisible by K.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        static int solution(int A, int B, int K)
        {
            int count = (B / K - A / K) + (A % K == 0 ? 1 : 0);
            return count;
        }

    }
}
