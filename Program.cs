/*
Perfect Numbers in Range from Coding Challenges
by Silvio Duka

Last modified date: 2018-04-03

A perfect number is a positive integer that is equal to the sum of its proper positive divisors, that is, the sum of its positive divisors excluding the number itself. 
The smallest perfect number is 6: its proper divisors are 1, 2, and 3, and 1 + 2 + 3 = 6. 

Write a program which will check if the given input is a perfect number or not. 

For Example: 
Input: 6 
Output: true 

Input: 20 
Output: false 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = 0; // Insert a start number of range
            long end = 10000; // Insert a end number of range
            string result = String.Empty;

            for (long n = start; n <= end; n++)
            {
                if(IsPerfectNumber(n) == true) result += n.ToString() + ", ";
            }

            Console.WriteLine($"Input: {start}, {end}");
            Console.WriteLine($"Output: {result.TrimEnd().TrimEnd(',')}.");
        }

        static bool IsPerfectNumber(long n)
        {
            long sum = 1;

            for (long i = 2; i < n; i++)
            {
                if (n % i == 0) { sum += i; if (sum > n) break; }
            }

            return (sum == n);
        }
    }
}
