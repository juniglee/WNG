using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNomadsGroup
{
    public class WorldNomadsGroup
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());            

            StringBuilder output1 = Sequence(input);
            StringBuilder output2 = OddNumbers(input);
            StringBuilder output3 = EvenNumbers(input);
            StringBuilder output4 = MultiplesCheck(input);
            StringBuilder output5 = Fibonacci(input);            

            Console.WriteLine("Numbers up to input: " + output1.ToString());
            Console.WriteLine("Odd numbers up to input: " + output2.ToString());
            Console.WriteLine("Even numbers up to input: " + output3.ToString());
            Console.WriteLine("Multiple of 3/5 check input: " + output4.ToString());
            Console.WriteLine("Fibonacci sequece: " + output5.ToString());
            Console.ReadKey();
        }

        public static StringBuilder Sequence(int input)
        {
            StringBuilder results = new StringBuilder();

            for (int i = 0; i <= input; i++)
            {
                results.Append(i);

                if (i != input)
                {
                    results.Append(", ");
                }
            }

            return results;
        }

        public static StringBuilder OddNumbers(int input)
        {
            StringBuilder results = new StringBuilder();

            for (int i = 0; i <= input; i++)
            {
                if (i % 2 == 1)
                {
                    results.Append(i);

                    if (input % 2 != 0)
                    {
                        if (i % 2 == 1 && i != input)
                        {
                            results.Append(", ");
                        }
                    }
                    else
                    {
                        if (i % 2 == 1 && i != input - 1)
                        {
                            results.Append(", ");
                        }
                    }
                }
            }

            return results;
        }

        public static StringBuilder EvenNumbers(int input)
        {
            StringBuilder results = new StringBuilder();

            for (int i = 0; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    results.Append(i);

                    if (input % 2 != 1)
                    {
                        if (i % 2 == 0 && i != input)
                        {
                            results.Append(", ");
                        }
                    }
                    else
                    {
                        if (i % 2 == 0 && i != input - 1)
                        {
                            results.Append(", ");
                        }
                    }
                }
            }

            return results;
        }

        public static StringBuilder MultiplesCheck(int input)
        {
            StringBuilder results = new StringBuilder();

            for (int i = 0; i <= input; i++)
            {
                //Q4 does not ask to include input number
                if (i < input)
                {
                    if (i != 0)
                    {

                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            results.Append("fizz buzz");
                        }
                        if (i % 3 == 0 && i % 5 != 0)
                        {
                            results.Append("fizz");
                        }
                        if (i % 3 != 0 && i % 5 == 0)
                        {
                            results.Append("buzz");
                        }
                        if (i % 3 != 0 && i % 5 != 0)
                        {
                            results.Append(i);
                        }
                    }
                    else
                    {
                        results.Append("0");
                    }

                    if (i != input - 1)
                    {
                        results.Append(", ");
                    }
                }
            }

            return results;
        }

        public static StringBuilder Fibonacci(int input)
        {
            List<int> resultsTemp = new List<int>();
            StringBuilder results = new StringBuilder();

            //Fibonacci sequence has fixed values for the first two values of the sequence
            if (input == 0)
            {
                results.Append("0");
            }
            else if (input == 1)
            {
                results.Append("0, 1");
            }
            else
            {
                //initial values of Fibonacci sequence
                results.Append("0, 1, ");
                resultsTemp.Add(0);
                resultsTemp.Add(1);

                for (int i = 2; i <= input; i++)
                {
                    int value = resultsTemp.ElementAt(i - 2) + resultsTemp.ElementAt(i - 1);
                    resultsTemp.Add(value);

                    if (i != input)
                    {
                        results.Append(value.ToString() + ", ");
                    }
                    else
                    {
                        results.Append(value.ToString());
                    }
                }
            }

            return results;
        }
    }
}
