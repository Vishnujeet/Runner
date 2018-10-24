using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            var isContinue = false;

            do
            {
                string userinput;
                do
                {
                    Console.WriteLine("Which problem would you like to solve choose between 1 or 2?");
                    Console.WriteLine("1.Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.");
                    Console.WriteLine("2.Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically");
                    userinput = Console.ReadLine();
                    if (!RunnerHelpers.CheckValidInput(userinput))
                    {
                        Console.WriteLine("Invalid User input. You can enter only 1 or 2.");
                        Console.WriteLine();
                    }
                } while (!RunnerHelpers.CheckValidInput(userinput));


                if (userinput == "1")
                    RunnerHelpers.SumOfNaturalsNumbersMultipleOf3Or5();

                if (userinput == "2")
                {
                    RunnerHelpers.StringAnalysisOrderedUppercases();
                }

                isContinue = RunnerHelpers.CheckStatus();

            } while (isContinue);
            Console.ReadKey();

        }

       

    }
}
