using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    /// <summary>
    /// RunnerHelpers class it helps to runner application to validate  
    /// user input and check the validation based on user input.
    /// </summary>
    public static class RunnerHelpers
    {
        /// <summary>
        /// check the user input if he want enter the yes then execute the program once again
        /// or else exit the application
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// validation as yes or no based on input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static bool CheckValidconfirmation(string input)
        {
            return input.ToUpperInvariant().Equals("Y") || input.ToUpperInvariant().Equals("N");
        }
        /// <summary>
        /// To select the library between "SequenceAnalysis" or "SumOfMultiple" check the valid input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static bool CheckValidInput(string input)
        {
            return input == "1" || input == "2";
        }
        /// <summary>
        /// validate the user input and pass this input to SumOfMultiple library to find the relative value and calculate it
        /// </summary>
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
                    long result = new SumOfMultiple.Calculator().FindSumOfNaturalsMultipleBy3Or5(limit);
                    Console.WriteLine("Total is :" + result);
                    Console.WriteLine();

                }
            } while (!validNatualNo);
        }
        /// <summary>
        /// this method will accept user input through console and pass it to FindUppercaseFinder class.
        /// </summary>
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
