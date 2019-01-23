using System;
using System.Collections.Generic;
using Xunit;

namespace SolveArrays.Tests
{
    public class ArraySolverTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -15)]
        [InlineData(new int[] { 1, -2, 3, -4, 5 }, 3)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        //[InlineData(new int[] { }, 0)]
        //[InlineData(null, 0)]
        public void Sum(int[] numbers, int expected)
        {
            // Arrange
            var arraySolver = new ArraySolver();

            // Act
            int actual = arraySolver.Sum(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -6)]
        [InlineData(new int[] { 1, -2, 3, -4, 5 }, -6)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        //[InlineData(new int[] { }, 0)]
        //[InlineData(null, 0)]
        public void SumEvens(int[] numbers, int expected)
        {
            // Arrange
            var arraySolver = new ArraySolver();

            // Act
            int actual = arraySolver.SumEvens(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -3)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, 2.6666666666)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, -2.6666666666)]
        [InlineData(new int[] { 1, -2, 2, 3, -4 }, -1.3333333333)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 0)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        //[InlineData(new int[] { }, 0)]
        //[InlineData(null, 0)]
        public void AverageEvens(int[] numbers, double expected)
        {
            // Arrange
            var arraySolver = new ArraySolver();

            // Act
            double actual = arraySolver.AverageEvens(numbers);

            // Assert
            Assert.Equal(Math.Round(expected, 5), Math.Round(actual, 5));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, true)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, false)]
        [InlineData(new int[] { 1, -2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, true)]
        [InlineData(new int[] { 1, 3, 5, 8 }, true)]
        [InlineData(new int[] { 10, 10, 10, 10 }, false)]
        [InlineData(new int[] { 0, 1, 0 }, true)]
        //[InlineData(new int[] { }, false)]
        //[InlineData(null, false)]
        public void IsSumOdd(int[] numbers, bool expected)
        {
            // Arrange
            var arraySolver = new ArraySolver();
            var numbersList = numbers == null ? null : new List<int>(numbers);

            // Act
            bool actual = arraySolver.IsSumOdd(numbersList);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
