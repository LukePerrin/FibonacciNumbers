using System;
using System.Collections.Generic;
using System.Text;

namespace ReadFile.Utility
{
    static class FibonacciService
    {                      
       
        /// <summary>
        /// Returns true if number is in Fibonacci series
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public bool GetFibonnaci(int number)
        {
            //N is a Fibonacci number if and only if ( 5* N2 + 4 ) or( 5*N2 – 4 ) is a perfect square!
            var result1 = (5 * Square(number)) - 4;
            var result2 = (5 * Square(number)) + 4;
            var isSquare1 = IsSquare(result1);
            var isSquare2 = IsSquare(result2);

            return isSquare1 || isSquare2;
        }

        /// <summary>
        /// Square a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public int Square(int number)
        {
            return number * number;
        }

        /// <summary>
        /// Return whether the number is a clean square
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public bool IsSquare(int number)
        {
            double result = Math.Sqrt(number);
            bool isSquare = result % 1 == 0;
            return isSquare;
        }
    }


}
