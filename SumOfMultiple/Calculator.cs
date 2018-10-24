using System;

namespace SumOfMultiple
{
    public class Calculator
    {
        /// <summary>
        /// Calculation to find sum of natural’s number that Multiple By 3 Or 5
        /// </summary>
        /// <param name="limit">10</param>
        /// <returns>23</returns>
        public long FindSumOfNaturalsMultipleBy3Or5(int limit)
        {
            long sum = 0;

            for (var i = 0; i < limit; i++)
            {
                var multipleOf3Or5 = (i % 3 == 0) || (i % 5 == 0);
                if (multipleOf3Or5)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
