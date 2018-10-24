using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    public static class RunnerHelpers
    {
        internal static bool CheckStatus()
        {
            bool isContinue = false;
            string newInput;
            do
            {
                Console.WriteLine("Would you like to solve another problem?Y/N");
                newInput = Console.ReadLine();
                if (!CheckValidconfirmation(newInput))
                {
                    Console.WriteLine("Invalid parameter. You can choose Y or N.");
                    Console.WriteLine();
                }
                else
                {
                    if (newInput != null) isContinue = newInput.ToUpperInvariant().Equals("Y");
                }

            } while (!CheckValidconfirmation(newInput));
            return isContinue;
        }

        internal static bool CheckValidconfirmation(string input)
        {
            return input.ToUpperInvariant().Equals("Y") || input.ToUpperInvariant().Equals("N");
        }

        internal static bool CheckValidInput(string input)
        {
            return input == "1" || input == "2";
        }
        internal static void SumOfNaturalsNumbersMultipleOf3Or5()
        {
            var validNatualNo = false;
            do
            {
                Console.WriteLine("Enter the limit..");
                var input = Console.ReadLine();
                validNatualNo = (int.TryParse(input, out int limit) && limit > 0);

                if (!validNatualNo)
                {
                    Console.WriteLine("Invalid Input. Try again valid input.");
                }
                else
                {
                    long result = new SumOfMultiple.SumCalculator().FindSumOfNaturalsMultipleBy3Or5(limit);
                    Console.WriteLine("Total is :" + result);
                    Console.WriteLine();

                }
            } while (!validNatualNo);
        }

        internal static void StringAnalysisOrderedUppercases()
        {
            Console.WriteLine("Enter the string?");
            var input = Console.ReadLine();

            var result = new SequenceAnalysis.FindUppercaseFinder().FindUppercaseLettersAsPerPattern(input);
            Console.WriteLine("OutPut :" + result);
            Console.WriteLine();
        }
    }
}
