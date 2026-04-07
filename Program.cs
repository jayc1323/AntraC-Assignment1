using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AntraC_Assignment1
{   /// <summary> Antra C# Assignment 1 </summary>
    class Program
    {

        private static void CenturyToString(int numCenturies)
        {
            int numYears = numCenturies * 100;
            Console.WriteLine("{0} centuries = {1} years", numCenturies, numYears);
            int numDays = numYears * 365;
            Console.WriteLine("{0} centuries = {1} days", numCenturies, numDays);
            ulong numHours = (ulong)numDays * 24;
            Console.WriteLine("{0} centuries = {1} hours", numCenturies, numHours);
            ulong numMinutes = numHours * 60;
            Console.WriteLine("{0} centuries = {1} minutes", numCenturies, numMinutes);
            ulong numSeconds = numMinutes * 60;
            Console.WriteLine("{0} centuries = {1} seconds", numCenturies, numSeconds);
            ulong numMilliseconds = numSeconds * 1000;
            Console.WriteLine("{0} centuries = {1} milliseconds", numCenturies, numMilliseconds);
            ulong numMicroseconds = numMilliseconds * 1000;
            Console.WriteLine("{0} centuries = {1} microseconds", numCenturies, numMicroseconds);
            ulong numNanoseconds = numMicroseconds * 1000;
            Console.WriteLine("{0} centuries = {1} nanoseconds", numCenturies, numNanoseconds);
            return;
        }
        private static int NumDaysOld(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan age = currentDate - birthDate;
            return (int)age.TotalDays;

        }

        private static string printArray(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int i in arr)
            {
                string s = i.ToString() + " ";
                sb.Append(s);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Size of int = {0} , maxVal = {1} ,minVal = {2} ", sizeof(int), int.MaxValue, int.MinValue);
            Console.WriteLine("Size of byte = {0} , maxVal = {1} ,minVal = {2} ", sizeof(byte), byte.MaxValue, byte.MinValue);
            Console.WriteLine("Size of decimal = {0} , maxVal = {1} ,minVal = {2} ", sizeof(decimal), decimal.MaxValue, decimal.MinValue);
            Console.WriteLine("Size of double = {0} , maxVal = {1} ,minVal = {2} ", sizeof(double), double.MaxValue, double.MinValue);

            CenturyToString(5);
            FizzBuzz fb = new FizzBuzz(100);
            fb.PrintFizzBuzz();
            Pyramid py = new Pyramid(5);
            py.PrintPyramid();
            DateTime time = DateTime.Now;
            switch (time.Hour)
            {
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Good Morning");
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Good Afternoon");
                    break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    Console.WriteLine("Good Evening");
                    break;
                default:
                    Console.WriteLine("Good Night");
                    break;
            }

            int birthYear, birthMonth, birthDay;
            Console.WriteLine("Enter your birth year:");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth month:");
            birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth day:");
            birthDay = Convert.ToInt32(Console.ReadLine());
            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            int numDaysOld = NumDaysOld(birthDate);
            Console.WriteLine("You are {0} days old.", numDaysOld);

            // Assignment 2
            // 1. Copying an array 
            /* Write code to create a copy of an array. First, start by creating an initial array. (You can use
                whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
                assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
                in the array.
                Now create a second array variable. Give it a new array with the same length as the first.
                Instead of using a number for this length, use the Lengthproperty to get the size of the
                original array.
                Use a loop to read values from the original array and place them in the new array. Also
                print out the contents of both arrays, to be sure everything copied correctly.*/
            int[] intArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] intArray2 = new int[intArray1.Length];
            Console.WriteLine("Original array:");
            for (int i = 0; i < intArray1.Length; i++)
            {
                intArray2[i] = intArray1[i];
            }
            foreach (int num in intArray1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Copied array:");
            foreach (int num in intArray2)
            {
                Console.Write(num + " ");

            }
            Console.WriteLine();
            
            // 2. Loop and manage todo list 
            bool runLoop = true;
            List<string> todoList = new List<string>();
            while (runLoop)
            {
                Console.WriteLine("Enter a command (+ itemName, -itemName, -- , exit) :");
                string command = Console.ReadLine();
                command.Trim();
                if (command.StartsWith("+"))
                {
                    string itemName = command.Substring(1).Trim();
                    todoList.Add(itemName);
                    Console.WriteLine("Added: " + itemName);
                }
                else if (command.StartsWith("-"))
                {
                    string itemName = command.Substring(1).Trim();
                    if (todoList.Remove(itemName))
                    {
                        Console.WriteLine("Removed: " + itemName);
                    }
                    else
                    {
                        Console.WriteLine("Item not found: " + itemName);
                    }
                }
                else if (command == "--")
                {
                    todoList.Clear();
                    Console.WriteLine("Cleared all items.");
                }
                else if (command.ToLower() == "exit")
                {
                    runLoop = false;
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }

            }

            /* 4. Write a program to read an array of n integers (space separated on a single line) and an
            integer k, rotate the array right k times and sum the obtained arrays after each rotation as
            shown below.
After r rotations the element at position I goes to position(I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 … k; for I = 0 … n - 1.*/
            Console.WriteLine("Enter an array of 10 integers (space separated):");
            int[] nums = new int[10];
            int[] sumArray = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                nums[i] = a;
                sumArray[i] = 0;


            }

            Console.WriteLine("Enter no of times to rotate array ");
            int numRotations = int.Parse(Console.ReadLine());
            int[] currRotation = new int[nums.Length];
            int[] prevRotation = (int[])nums.Clone();

            for (int i = 0; i < numRotations; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    currRotation[(j + 1) % nums.Length] = prevRotation[j];
                    sumArray[(j + 1) % nums.Length] += currRotation[(j + 1) % nums.Length];
                }

                // Swap references
                var temp = prevRotation;
                prevRotation = currRotation;
                currRotation = temp;

                Console.WriteLine("Array after {0} rotation is {1}", i + 1, printArray(prevRotation));
            }


            Console.WriteLine("Sum is {0}", printArray(sumArray));



        }
    }
}
