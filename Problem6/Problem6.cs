﻿using System;

namespace ProjectEuler.Problem6
{
    public class Problem6
    {
        // The sum of the squares of the first ten natural numbers is,
        //    
        // 1^2 + 2^2 + ... + 10^2 = 385
        // The square of the sum of the first ten natural numbers is,
        //
        // (1 + 2 + ... + 10)^2 = 55^2 = 3025
        // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        //
        // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        public static void Solve()
        {
            const int target = 100;
            long resultOne = 0;
            for (var i = 1; i <= target; i++)
            {
                resultOne += Square(i);
            }
            long resultTwo = 0;
            for (var i = 1; i <= target; i++)
            {
                resultTwo += i;
            }
            resultTwo = Square(resultTwo);
            Console.WriteLine($"The answer is {resultTwo - resultOne}");
        }

        private static long Square(long n)
        {
            return n * n;
        }
    }
}