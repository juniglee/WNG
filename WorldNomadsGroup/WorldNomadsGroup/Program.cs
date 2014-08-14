using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNomadsGroup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string inputText = string.Empty;
            int input;

            Console.WriteLine("Welcome to the Calculator App. Please input a number to view 5 different lists of numbers in this order:");
            Console.WriteLine("1. List of sequence up to and including input number, starting from 0");
            Console.WriteLine("2. List of all odd numbers up to and including input number, starting from 1");
            Console.WriteLine("3. List of all even numbers up to and including input number, starting from 2");
            Console.WriteLine("4. List of sequence up to input number, starting from 0 - multiples of 3 and/or 5 are swapped for keywords(fizz = 3, buzz = 5, fizz buzz = both 3 and 5)");
            Console.WriteLine("5. Fibonacci sequence up to and including input number");
            Console.WriteLine();
            Console.Write("Please input a number: ");

            while (!inputText.Equals("x"))
            {
                inputText = Console.ReadLine();
                Console.WriteLine();

                if (Int32.TryParse(inputText, out input))
                {
                    StringBuilder output1 = calculator.GetIncrementalSequence(input);
                    StringBuilder output2 = calculator.GetOddNumbersSequence(input);
                    StringBuilder output3 = calculator.GetEvenNumbersSequence(input);
                    StringBuilder output4 = calculator.CheckMultiplesThreeAndFive(input);
                    StringBuilder output5 = calculator.GetFibonacciSequence(input);

                    Console.WriteLine("Numbers up to input: " + output1.ToString());
                    Console.WriteLine("Odd numbers up to input: " + output2.ToString());
                    Console.WriteLine("Even numbers up to input: " + output3.ToString());
                    Console.WriteLine("Multiple of 3/5 check input: " + output4.ToString());
                    Console.WriteLine("Fibonacci sequece: " + output5.ToString());

                    Console.WriteLine();
                    Console.Write("Please input a number: ");
                }
                else
                {
                    if (inputText.Equals("x"))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid number. Please input a valid number: ");
                    }
                }
            }
        }        
    }
}
