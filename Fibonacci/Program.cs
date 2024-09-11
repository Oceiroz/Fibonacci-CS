using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new() {0, 1};
            int fibonacciLength = GetInput("How many stages of fibonacci would you like to see?");
            for (int i = 0; i <= fibonacciLength; i++)
            {
                int nextStage = fibonacci[i] + fibonacci[i + 1];
                fibonacci.Add(nextStage);
            }
            Console.WriteLine(fibonacci[fibonacciLength]);

        }
        static int GetInput(string inputMessage)
        {
            int userInput = 0;
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                var rawInput = Console.ReadLine();
                try
                {

                    userInput = int.Parse(rawInput);
                    if (userInput < 1000 && userInput > 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                        
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            return userInput;
        }
    }
}
