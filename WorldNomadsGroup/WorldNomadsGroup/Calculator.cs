using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNomadsGroup
{
    public class Calculator
    {
        public StringBuilder GetIncrementalSequence(int input)
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

        public StringBuilder GetOddNumbersSequence(int input)
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

        public StringBuilder GetEvenNumbersSequence(int input)
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

        public StringBuilder CheckMultiplesThreeAndFive(int input)
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

        public StringBuilder GetFibonacciSequence(int input)
        {
            /*
             * My original interpretation of this function is that it should display x elements of the Fibonacci sequence, where x is the value of (input + 1).
             * As I have been asked to fix this, so I assume my original interpretation is wrong.
             * 
             * This current new interpretation is to only display all values of the Fibonacci sequence, which does not exceed, or is equal to the value of the input.
             * For example, if our value is 5, our results would be 0, 1, 1, 2, 3, 5.
             * 
             */ 

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

                //Original interpretation, which is wrong
                /*for (int i = 2; i <= input; i++)
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
                }*/

                //new interpretation
                int counter = 2;
                int value = resultsTemp.ElementAt(counter - 2) + resultsTemp.ElementAt(counter - 1); 

                while (value < input)
                {
                    value = resultsTemp.ElementAt(counter - 2) + resultsTemp.ElementAt(counter - 1);

                    resultsTemp.Add(value);

                    if (value < input)
                    {
                        results.Append(value.ToString() + ", ");
                    }

                    counter++;
                }

                //final value - append input value
                //admittedly a rather hacky solution, but we would be adding the input as the final value anyway, regardless if it was a member of a Fibonacci sequence or not
                results.Append(input);
            }

            return results;
        }
    }
}
