using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total = total + number;
            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int totalOfEvens = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    totalOfEvens += number;
                }
            }

            return totalOfEvens;
        }

        public double AverageEvens(int[] numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = Sum(numbers.ToArray());

            if (total % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
