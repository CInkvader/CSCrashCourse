﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class Program
    {
        static void ConsoleMethods()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }

        static void NumberFormatting()
        {
            Console.WriteLine("Currency : {0:c}", 23.455);
            // TURN TO CURRENCY 2 DECIMALS

            Console.WriteLine("Currency : {0:d2}", 23);
            // ADD 0's TO THE FRONT d(x)

            Console.WriteLine("Currency : {0:f2}", 23.455);
            // ROUND TO DECIMAL PLACES f(x)

            Console.WriteLine("Currency : {0:n2}", 230000.657456);
            // ADD COMMAS AND ROUND TO DECIMAL PLACES n(x)
        }
        
        static void StringFuncitons()
        {
            string sample_string = "This is a sample string";

            Console.WriteLine("{0} : {1}", sample_string, sample_string.Length);
            // Checks string length
            
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Contains("sample"));
            // Returns true if string contains value
            
            Console.WriteLine("{0} : {1}", sample_string, sample_string.IndexOf("a"));
            // Returns index of first occurence of value
            
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Remove(5, 3));
            // Removes 'y' characters from set index 'x' (x, y)
            
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Insert(10, "nice "));
            // Inserts a string next to the set index
            
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Replace("a sample", "an example"));
            // Replaces the first occurence specified to the new value

            Console.WriteLine("{0} : {1}", sample_string, sample_string.CompareTo("This is a sample string"));
            // Compare current string variable to another string
            
            Console.WriteLine("{0} : {1}", sample_string, String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            // Compare two different string by calling 'String'
            // COMPARISON RESULTS:
            // 1 - First string is bigger
            // 0 - Strings are equal
            // -1 - First string is smaller

            Console.WriteLine("{0} : {1}", sample_string, sample_string.Equals("This is another sample string", StringComparison.OrdinalIgnoreCase));
            // Returns either true or false
            
            Console.WriteLine("{0} : {1}", sample_string, sample_string.PadLeft(25, '.'));
            // Pad value must be greater than string length to apply

            Console.WriteLine("{0} : {1}", sample_string, sample_string.PadRight(25, '.'));
            // Same as PadLeft. Character set is the padding character

            Console.WriteLine("{0} : {1}", sample_string, sample_string.Trim());
            // Removes all whitespaces before and after the string

            Console.WriteLine("{0} : {1}", sample_string, sample_string.ToUpper());
            // Whole string to uppercase

            Console.WriteLine("{0} : {1}", sample_string, sample_string.ToLower());
            // Whole string to lowercase

            Console.WriteLine("{0} : {1}", sample_string, String.Format("{0} is a very {1} girl", "Celeste", "creative"));
            // Create a string from set values

            Console.Write("\t\t" + sample_string + '\n');
            // You can concatenate strings

            Console.WriteLine(@"This is a sample string\n\n");
            // @ to not apply special characters such as '\n'
        }

        static void StringBuilder()
        {
            StringBuilder string_1 = new StringBuilder("This is a stringbuilder text ");
            StringBuilder string_2 = new StringBuilder("and is another stringbuilder text", 256);

            Console.WriteLine(string_1.Capacity);
            Console.WriteLine(string_1.Length);
            Console.WriteLine(string_2.Capacity);
            Console.WriteLine(string_2.Length);

            string_1.AppendLine(string_2.ToString());
            // Requires the argument to be a string and adds a newline at the end
            string_1.Append(string_2);
            // Works the same as AppendLine except it does not add a newline at the end
            Console.WriteLine(string_1);

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string customer = "Celeste Diane";

            string_2.Clear();
            // Clears the string
            string_2.Insert(0, "x is a new customer in Dunkin Donuts");
            // At the specified index, insert this value
            string_2.AppendFormat(enUS, " buying her favourite coffee");
            string_2.Replace("x", customer);

            Console.WriteLine(string_2);
            string_2.Remove(48, 28);
            Console.WriteLine(string_2);
        }

        static void TernaryOperator()
        {
            int age = 16;
            string is_legal_age;

            is_legal_age = age > 18 ? "True" : "False";
            // Resulting values must be assigned to a variable
            bool is_below_18 = age < 18 ? true : false;
            // Can be used directly on variable intialization

            Console.WriteLine("Is age above 18? " + is_legal_age);
            Console.WriteLine("Is age below 18? " + is_below_18);
        }

        static void ForeachLoop()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }
            // var can be explicitly the proper datatype (e.g. int, string, float, etc.,)
        }

        static void ExceptionHandling()
        {
            int var_1 = 5;
            int var_2 = 0;

            try
            {
                Console.WriteLine(var_1 / var_2);
            }
            catch (DivideByZeroException exception)
            {
                // exception argument stores the system error thrown
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine($"{exception.GetType().Name}\n{exception.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error occured on calculation");
                Console.WriteLine($"{exception.GetType().Name}\n{exception.Message}");
            }
            finally
            {
                // Will always trigger whether try is successful or catch is triggered
                Console.WriteLine("Cleaning up...");
            }
        }

        static void Arrays()
        {
            // SINGLE DIMENSION ARRAYS //

            int[] my_array = new int[3];
            // Declared similar to C++ dynamic arrays
            my_array[0] = 10;
            my_array[1] = 20;
            my_array[2] = 30;

            int[] my_array_2 = { 2, 1, 4, 3, 5 };
            // To declare and initialize

            Array.Sort(my_array_2);
            Array.Reverse(my_array_2);

            Console.WriteLine($"Old my_array length: {my_array.Length}");
            Array.Resize(ref my_array, 5);
            my_array.SetValue(40, 3);
            my_array.SetValue(50, 4);

            Console.WriteLine($"New my_array length: {my_array.Length}");
            Console.WriteLine($"Index of the first 40 in my_array: {Array.IndexOf(my_array, 40)}");

            int first_element = Array.Find(my_array, p => p > 20);
            // Finding a value greater than 25 and assigning it to the variable 'first_element'

            Console.WriteLine($"Value greater than 25 in my_array: {first_element}");
            // Finding a value greater than 25 with the use of lambda expression

            Console.WriteLine($"Value greater than 25 in my_array: {Array.Find(my_array, p => p > 25)}");
            // Finding a value greater than 25 with the use of lambda expression

            Console.Write("\nContents of my_array: ");
            for (int i = 0; i < my_array.Length; ++i)
            {
                Console.Write(my_array[i] + " ");
            }

            Console.Write("\nmy_array_2 contents sorted and reversed: ");
            for (int i = 0; i < my_array_2.Length; ++i)
            {
                Console.Write(my_array_2[i] + " ");
            }

            Array.Copy(my_array, 0, my_array_2, 2, 3);
            // Copy from the index 0 of my_array to my_array_2 starting at the index 2, 3 elements from my_array

            Array.Copy(my_array, my_array_2, 5);
            // Copy contents from my_array to my_array_2, 5 elements from my_array

            Console.Write("\nmy_array contents copied to my_array_2: ");
            for (int i = 0; i < my_array_2.Length; ++i)
            {
                Console.Write(my_array_2[i] + " ");
            }

            Array my_array_3 = Array.CreateInstance(typeof(int), 10);
            my_array.CopyTo(my_array_3, 5);
            // Copy contents of my_array to my_array_3, paste elemenets to my_array_3 starting from index 5 of my_array_3

            Console.Write("\nmy_array contents copied to my_array_3: ");
            foreach (int element in my_array_3)
            {
                Console.Write(element + " ");
            }

            // MULTIDIMENSIONAL ARRAYS //

            int[,] my_multi_array = new int[3, 3];
            // A 3x3 multidimensional array
            int[,] my_multi_array_2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // To declare and initialize

            Console.Write("\n\nContents of my_multi_array_2: ");
            for (int i = 0; i < my_multi_array_2.GetLength(0); ++i)
            {
                for (int j = 0; j < my_multi_array_2.GetLength(1); ++j)
                {
                    Console.Write(my_multi_array_2[i, j] + " ");
                }
            }

            // JAGGED ARRAYS //

            int[][] my_jagged_array = new int[3][];
            int[][] my_jagged_array_2 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 }, new int[] { 8, 9, 10, 11, 12 } };

            Console.Write("\n\nContents of my_jagged_array_2:");
            for (int i = 0; i < my_jagged_array_2.Length; ++i)
            {
                Console.WriteLine($"\nRow {i} length - {my_jagged_array_2[i].Length}:");
                for (int j = 0; j < my_jagged_array_2[i].Length; ++j)
                {
                    Console.Write(my_jagged_array_2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ObjectDatatype()
        {
            int x = 55;
            object my_object = "55.55";
            // Boxing to an object

            object my_object_2 = x + 5;
            // Boxing to an object

            // Unboxing objects to their proper datatype
            Console.WriteLine($"my_object_1 and my_object_2 added together: {float.Parse(my_object.ToString()) + (int)my_object_2}");
            Console.WriteLine($"my_object_2 as string and concatenated: {my_object_2.ToString() + 'a'}");

            object[] object_array = { x, my_object, my_object_2, "20.45" };
            Console.WriteLine("\nObject array length: " + object_array.Length);

            Console.WriteLine("\nObject array contents:");
            for (int i = 0; i < object_array.Length; ++i)
            {
                Console.WriteLine(object_array[i]);
            }
        }

        static void AddMultipleParams(params int[] numbers)
        {
            // Using params keyword allows you to add as much arguments as you want in the function call
            // and these params will be put inside the int[] array
            // A function can only contain one params parameter, and must be placed as the rightmost or last parameter

            int sum = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of all numbers: {sum}");
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> REF PARAMETER >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        void Swap(ref int var_1, ref int var_2)
        {
            // Unlike in C++, passing by reference requires you to use the keyword 'ref' and not the ampersand

            int temporary_var = var_1;
            var_1 = var_2;
            var_2 = temporary_var;
        }
        
        static void PassByReference()
        {
            Program program = new Program();
            int var_1 = 5;
            int var_2 = 10;

            Console.WriteLine($"Before swap:\nVar_1: {var_1}\nVar_2: {var_2}\n");
            program.Swap(ref var_1, ref var_2);

            Console.WriteLine($"After swap:\nVar_1: {var_1}\nVar_2: {var_2}");
        }
        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< END <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> OUT PARAMETER >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        void CalculateSum(out int sum, params int[] numbers)
        {
            // Out parameter behaves similar to changing a ref parameter - however, this out parameter must
            // always have a value assigned to it within the function, or else it would not work

            sum = 0;
            // Best to assign a default value at start of function
            // Giving an out parameter a default value is not allowed and will throw an error

            for (int i = 0; i < numbers.Length; ++i)
            {
                sum += numbers[i];
            }
        }

        static void OutParameter()
        {
            Program program = new Program();
            int sum = 0;

            program.CalculateSum(out sum, 5, 10, 15, 20, 25);
            // Calling a function with an out parameter requires you to add the keyword 'out' before the argument

            Console.WriteLine(sum);
        }
        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< END <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> UNORDERED PARAMETERS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        void CreateAddress(string City, int ZipCode)
        {
            Console.WriteLine($"Josh lives in {City} with a Zip code of {ZipCode}");
        }

        static void CallParamsUnordered()
        {
            Program program = new Program();

            program.CreateAddress(ZipCode: 69420, City: "Metro Manila");
            // Arguments can be passed not in order as long as parameter names are set on function call
        }
        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< END <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        static void DateTime()
        {
            DateTime celesteBirthday = new DateTime(1999, 5, 10, 8, 30, 45); // 5/10/1999, 8:30:45 AM
            // Create date with order: Year, Month, Day, Hour, Minute, Seconds arguments
            // You can create with only Year, Month, Day arguments
            // Or you can add milliseconds by adding another argument after 'Seconds' argument
            // EXTRA: Calendar objects can be included along with DateTimeKind (e.g. UTC+8, etc.,)

            Console.WriteLine("----------\n");
            Console.WriteLine(celesteBirthday);
            // Outputs the date along with the set time

            Console.WriteLine(celesteBirthday.Date);
            // Outputs the date with time at 12:00:00 AM (Very start of the day)

            Console.WriteLine(celesteBirthday.Year);
            // Outputs the year

            Console.WriteLine(celesteBirthday.Month);
            // Outputs the numerical month

            Console.WriteLine(celesteBirthday.Day);
            // Outputs the numerical day of the month

            Console.WriteLine(celesteBirthday.DayOfWeek);
            // Outputs the day of the week (Monday, Tuesday, etc.,)

            Console.WriteLine(celesteBirthday.DayOfYear);
            // Outputs the numerical day of the year

            Console.WriteLine(celesteBirthday.TimeOfDay);
            // Outputs the set time of the day

            Console.WriteLine("----------\n");

            celesteBirthday = celesteBirthday.AddYears(4);
            celesteBirthday = celesteBirthday.AddMonths(2);
            celesteBirthday = celesteBirthday.AddDays(10);
            // You can also do... AddHours, AddMinutes, AddSeconds, AddMilliseconds

            Console.WriteLine(celesteBirthday.Date + "\n----------\n");

            // USE OF TimeSpan CLASS
            TimeSpan time = new TimeSpan(12, 30, 0);
            Console.WriteLine("Default" + time);

            time = time.Subtract(new TimeSpan(0, 30, 0));
            Console.WriteLine("Subtract 30 mins: " + time);

            time = time.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("Add 1 hour: " + time);

            if (time.Equals(new TimeSpan(13, 0, 0)))
            {
                Console.WriteLine("Equal to 1:00:00 PM");
            }
        }

        static void Randomizer()
        {
            Random random = new Random();
            int number;
            while (true)
            {
                number = random.Next(1, 11);
                // Generates a number from 1 to 10

                Console.WriteLine(number);
                Console.ReadKey();
                Console.Clear();
            }
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ENUMS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        enum Difficulty : int // You can set the type of enum with any numerical datatype (e.g. int, short, long, etc.,)
        {
            Peaceful = 1,
            // Default starting index is 0 unless assigned, proceeding values will be adjusted (incremented) accordingly
            Easy,
            // Will be 2
            Normal,
            // If this is set to 5 (Normal = 5), preceeding indices will remain unchanged, but succeeding indices are adjusted
            Hard,
            // Will be 6 if Normal was set to 5, else this would be 4 as Normal would have its supposed index of 3
            Extreme
            // Same with the previous member, this would be 7, else it would be 5
        }

        static void SetDifficulty()
        {
            Difficulty selectedDifficulty = Difficulty.Normal;
            string input;

            Console.WriteLine("Choose difficulty:\n- Peaceful\n- Easy\n- Normal\n- Hard\n- Extreme");
            input = Console.ReadLine();

            foreach (string element in Enum.GetNames(typeof(Difficulty)))
            {
                if (String.Equals(element, input, StringComparison.OrdinalIgnoreCase))
                {
                    selectedDifficulty = (Difficulty)Enum.Parse(typeof(Difficulty), input, true);
                }
            }
            // Enum members can be displayed as its name by calling the enum class name itself
            // To show the number code of the enum member, cast the enum with numerical datatype such as int: (int)enum_name
            // To show the member name by using its number code, cast the number by the enum class name: (enum_name)x
            // where 'x' is any integer or number value

            Console.WriteLine("{0} difficulty with {1} multiplier selected", selectedDifficulty, (int)selectedDifficulty);
        }
        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< END <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        static void Main(string[] args)
        {
            UtilityClass.createLine(61);
        }
    }

    class GetSetClass
    {
        private int number;
        // Backing field - stores the data within get setters

        public int GetSet1
        {
            get { return this.number; }
            // Explicitly return the value of backing field "number"
            set { this.number = value; }
            // Explicitly set the value of backing field "number"
        }

        public int GetSet2
        {
            get => this.number;
            // Explicitly return the value of backing field "number"
            set => this.number = value;
            // Explicitly return the value of backing field "number"
        }
        
        public int LoneNumber { get; set; }
        // Get setter which stores the value returned to it - not stored to any backing fields such as "number"
    }

    /*static*/ class UtilityClass
    {
        // Static classes or utility classes contain only static fields and methods
        // This means that the class does not need to and can not be instantiated
        // All methods within a static class MUST be declared as static

        private static char _symbol = '-';
        public static char Symbol {
            get => _symbol;
            set => _symbol = value;
        }

        public static void createLine(char symbol = '-', int pLength = 25)
        {
            _symbol = symbol;
            for (int i = 0; i < pLength; ++i)
            {
                Console.Write(_symbol);
            }
            Console.WriteLine();
        }
        public static void createLine(string symbol = "=", int length = 25)
        {
            _symbol = symbol[0];
            for (int i = 0; i < length; ++i)
            {
                Console.Write(_symbol);
            }
            Console.WriteLine();
        }
        public static void createLine(int ascii = 61, int length = 25)
        {
            _symbol = (char)ascii;
            for (int i = 0; i < length; i++)
            {
                Console.Write(_symbol);
            }
            Console.WriteLine();
        }
    }
}