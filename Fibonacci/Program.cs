using ReadFile.FileOps;
using ReadFile.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray;
            var notFibonacci = new List<int>();            

            Console.WriteLine("\n\nWelcome to Luke's Number App");
            Console.WriteLine("Please see the output of numbers not in the Fibonacci series\n");

            //test.......................




            // .........................

            try
            {
                if (args.Length == 0)
                    throw new Exception("You must supply an argument for a *.txt file");                

                var filename = args[0];
                var numbersAsString = FileReader.Instance.ReadFile(filename);                

                try
                {
                    numArray = numbersAsString.Split(' ')
                              .Select(n => Convert.ToInt32(n))
                              .ToArray();
                }
                catch (Exception)
                {

                    throw new Exception("The file must contain whole numbers seperated by spaces");
                }

                foreach (var num in numArray)
                {
                    if (!FibonacciService.GetFibonnaci(num))
                        notFibonacci.Add(num);
                }

                notFibonacci.Sort();
                Console.WriteLine("output...");
                notFibonacci.ForEach(x => Console.WriteLine(x.ToString()));


                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
