using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class Program
    {
        static void numberManipulation()
        {
            Console.WriteLine("Currency : {0:c}", 23.455); // TURN TO CURRENCY 2 DECIMALS
            Console.WriteLine("Currency : {0:d2}", 23); // ADD 0's TO THE FRONT d(x)
            Console.WriteLine("Currency : {0:f2}", 23.455); // ROUND TO DECIMAL PLACES f(x)
            Console.WriteLine("Currency : {0:n2}", 230000.657456); // ADD COMMAS AND ROUND TO DECIMAL PLACES n(x)
        }

        static void stringFuncitons()
        {
            string sample_string = "This is a sample string";

            Console.WriteLine("{0} : {1}", sample_string, sample_string.Length); // Checks string length
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Contains("sample")); // Returns true if string contains value
            Console.WriteLine("{0} : {1}", sample_string, sample_string.IndexOf("a")); // Returns index of first occurence of value
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Remove(5, 3)); // Removes 'y' characters from set index 'x' (x, y)
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Insert(10, "nice ")); // Inserts a string next to the set index
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Replace("a sample", "an example")); // Replaces the first occurence specified to the new value

            Console.WriteLine("{0} : {1}", sample_string, sample_string.CompareTo("This is a sample string")); // Compare current string variable to another string
            Console.WriteLine("{0} : {1}", sample_string, String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)); // Compare two different string by calling 'String'
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Equals("This is another sample string", StringComparison.OrdinalIgnoreCase)); // Returns either true or false
            // COMPARISON RESULTS:
            // 1 - First string is bigger
            // 0 - Strings are equal
            // -1 - First string is smaller

            Console.WriteLine("{0} : {1}", sample_string, sample_string.PadLeft(25, '.')); // Pad value must be greater than string length to apply
            Console.WriteLine("{0} : {1}", sample_string, sample_string.PadRight(25, '.')); // Same as PadLeft. Character set is the padding character
            Console.WriteLine("{0} : {1}", sample_string, sample_string.Trim()); // Removes all whitespaces before and after the string
            Console.WriteLine("{0} : {1}", sample_string, sample_string.ToUpper()); // Whole string to uppercase
            Console.WriteLine("{0} : {1}", sample_string, sample_string.ToLower()); // Whole string to lowercase
            Console.WriteLine("{0} : {1}", sample_string, String.Format("{0} is a very {1} girl", "Celeste", "kinky")); // Create a string from set values
            Console.Write("\t\t" + sample_string + '\n'); // You can concatenate strings
            Console.WriteLine(@"This is a sample string\n\n"); // @ to not apply special characters such as '\n'
        }

        static void arrays()
        {
            // SINGLE DIMENSION ARRAYS -----------------------------------------------------------------------

            int[] my_array = new int[3]; // Declared similar to C++ dynamic arrays
            my_array[0] = 10;
            my_array[1] = 20;
            my_array[2] = 30;

            int[] my_array_2 = { 2, 1, 4, 3, 5 }; // To declare and initialize

            Array.Sort(my_array_2);
            Array.Reverse(my_array_2);

            Console.WriteLine($"Old my_array length: {my_array.Length}");
            Array.Resize(ref my_array, 5);
            my_array.SetValue(40, 3);
            my_array.SetValue(50, 4);

            Console.WriteLine($"New my_array length: {my_array.Length}");
            Console.WriteLine($"Index of the first 40 in my_array: {Array.IndexOf(my_array,40)}");

            int first_element = Array.Find(my_array, p => p > 20); // Finding a value greater than 25 and assigning it to the variable 'first_element'
            Console.WriteLine($"Value greater than 25 in my_array: {first_element}"); // Finding a value greater than 25 with the use of lambda expression
            Console.WriteLine($"Value greater than 25 in my_array: {Array.Find(my_array, p => p > 25)}"); // Finding a value greater than 25 with the use of lambda expression

            Console.Write("\nContents of my_array: ");
            for (int i = 0; i < my_array.Length; i++)
            {
                Console.Write(my_array[i] + " ");
            }

            Console.Write("\nmy_array_2 contents sorted and reversed: ");
            for (int i = 0; i < my_array_2.Length; i++)
            {
                Console.Write(my_array_2[i] + " ");
            }

            Array.Copy(my_array, 0, my_array_2, 2, 3); // Copy from the index 0 of my_array to my_array_2 starting at the index 2, 3 elements from my_array
            Array.Copy(my_array, my_array_2, 5); // Copy contents from my_array to my_array_2, 5 elements from my_array

            Console.Write("\nmy_array contents copied to my_array_2: ");
            for (int i = 0; i < my_array_2.Length; i++)
            {
                Console.Write(my_array_2[i] + " ");
            }

            Array my_array_3 = Array.CreateInstance(typeof(int), 10);
            my_array.CopyTo(my_array_3, 5); // Copy contents of my_array to my_array_3, paste elemenets to my_array_3 starting from index 5 of my_array_3

            Console.Write("\nmy_array contents copied to my_array_3: ");
            foreach (int element in my_array_3)
            {
                Console.Write(element + " ");
            }

            // MULTIDIMENSIONAL ARRAYS ----------------------------------------------------------------------

            int[,] my_multi_array = new int[3, 3]; // A 3x3 multidimensional array
            int[,] my_multi_array_2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // To declare and initialize

            Console.Write("\n\nContents of my_multi_array_2: ");
            for (int i = 0; i < my_multi_array_2.GetLength(0); i++)
            {
                for (int j = 0; j < my_multi_array_2.GetLength(1); j++)
                {
                    Console.Write(my_multi_array_2[i, j] + " ");
                }
            }

            // JAGGED ARRAYS -------------------------------------------------------------------------------

            int[][] my_jagged_array = new int[3][];
            int[][] my_jagged_array_2 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 }, new int[] { 8, 9, 10, 11, 12 } };

            Console.Write("\n\nContents of my_jagged_array_2:");
            for (int i = 0; i < my_jagged_array_2.Length; i++)
            {
                Console.WriteLine($"\nRow {i} length - {my_jagged_array_2[i].Length}:");
                for (int j = 0; j < my_jagged_array_2[i].Length; j++)
                {
                    Console.Write(my_jagged_array_2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void objectDatatype()
        {
            int x = 55;
            object my_object = "55.55"; // Boxing to an object
            object my_object_2 = x + 5; // Boxing to an object

            // Unboxing objects to their proper datatype
            Console.WriteLine($"my_object_1 and my_object_2 added together: {float.Parse(my_object.ToString()) + (int)my_object_2}");
            Console.WriteLine($"my_object_2 as string and concatenated: {my_object_2.ToString() + 'a'}");

            object[] object_array = { x, my_object, my_object_2, "20.45" };
            Console.WriteLine("\nObject array length: " + object_array.Length);

            Console.WriteLine("\nObject array contents:");
            for (int i = 0; i < object_array.Length; i++)
            {
                Console.WriteLine(object_array[i]);
            }
        }

        static void ternary_operator()
        {
            int age = 16;
            string is_legal_age;

            is_legal_age = age > 18 ? "True" : "False"; // Resulting values must be assigned to a variable
            bool is_below_18 = age < 18 ? true : false; // Can be used directly on variable intialization

            Console.WriteLine("Is age above 18? " + is_legal_age);
            Console.WriteLine("Is age below 18? " + is_below_18);
        }

        static void string_builder()
        {
            StringBuilder string_1 = new StringBuilder("This is a stringbuilder text ");
            StringBuilder string_2 = new StringBuilder("and is another stringbuilder text", 256);

            Console.WriteLine(string_1.Capacity);
            Console.WriteLine(string_1.Length);
            Console.WriteLine(string_2.Capacity);
            Console.WriteLine(string_2.Length);

            string_1.AppendLine(string_2.ToString()); // Requires the argument to be a string and adds a newline at the end
            string_1.Append(string_2); // Works the same as AppendLine except it does not add a newline at the end
            Console.WriteLine(string_1);

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string customer = "Celeste Diane";

            string_2.Clear(); // Clears the string
            string_2.Insert(0, "x is a new customer in Dunkin Donuts"); // At the specified index, insert this value
            string_2.AppendFormat(enUS, " buying her favourite coffee");
            string_2.Replace("x", customer);

            Console.WriteLine(string_2);
            string_2.Remove(48, 28);
            Console.WriteLine(string_2);
        }

        // -------------------------------------------------------------------------
        // Unlike in C++, passing by reference requires you to use the keyword 'ref' and not the ampersand
        void swap(ref int var_1, ref int var_2)
        {
            int temporary_var = var_1;
            var_1 = var_2;
            var_2 = temporary_var;
        }
        static void swap_by_reference()
        {
            Program program = new Program();
            int var_1 = 5;
            int var_2 = 10;

            Console.WriteLine($"Before swap:\nVar_1: {var_1}\nVar_2: {var_2}\n");
            program.swap(ref var_1, ref var_2);

            Console.WriteLine($"After swap:\nVar_1: {var_1}\nVar_2: {var_2}");
        }
        // -------------------------------------------------------------------------

        // Using params keyword allows you to add as much arguments as you want in the function call
        // and these params will be put inside the int[] array
        static void add_multiple_params(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of all numbers: {sum}");
        }

        // -------------------------------------------------------------------------
        // Arguments can be passed not in order as long as parameter names are set on function call
        void createAddress(string City, int ZipCode)
        {
            Console.WriteLine($"Josh lives in {City} with a Zip code of {ZipCode}");
        }
        static void call_parameters_unordered()
        {
            Program program = new Program();

            program.createAddress(ZipCode: 69420, City: "Metro Manila");
        }
        // -------------------------------------------------------------------------

        static void Main(string[] args)
        {
        }
    }
}
