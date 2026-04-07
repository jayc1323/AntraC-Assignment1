using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraC_Assignment1
{
    internal class Program
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
        static void Main(string[] args)
        { 
            Console.WriteLine("Size of int = {0} , maxVal = {1} ,minVal = {2} ", sizeof(int),int.MaxValue,int.MinValue);
            Console.WriteLine("Size of byte = {0} , maxVal = {1} ,minVal = {2} ", sizeof(byte), byte.MaxValue, byte.MinValue);
            Console.WriteLine("Size of decimal = {0} , maxVal = {1} ,minVal = {2} ", sizeof(decimal), decimal.MaxValue, decimal.MinValue);
            Console.WriteLine("Size of double = {0} , maxVal = {1} ,minVal = {2} ", sizeof(double), double.MaxValue, double.MinValue);

            CenturyToString(5);
           

        }
    }
}
