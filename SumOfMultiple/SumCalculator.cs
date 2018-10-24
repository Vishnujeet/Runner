using System;

namespace SumOfMultiple
{
    public class SumCalculator
    {
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
