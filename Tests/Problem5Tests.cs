using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    class Problem5Tests {
        private Problem5 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem5();
        }

        [TestCaseSource("GetSomeNumbersAndTheirExpectedFactorials")]
        public void ShouldReturnTheCorrectFactorials (long number, long expectedFactorial) {
            Assert.AreEqual(expectedFactorial, number.Factorial());
        }

        public static object[][] GetSomeNumbersAndTheirExpectedFactorials () {
            return new object[][] {
                new object[] { 1, 1, },
                new object[] { 2, 2, },
                new object[] { 3, 6, },
                new object[] { 4, 24, },
                new object[] { 5, 120, },
                new object[] { 6, 720, },
                new object[] { 7, 5040, },
                new object[] { 8, 40320, },
                new object[] { 9, 362880, },
                new object[] { 10, 3628800, },
            };
        }

        [TestCaseSource("GetExpectedSmallestNumbersAndTheirLargestConsecutiveDivisors")]
        public void ShouldReturnTheCorrectResult (int expectedSmallestNumber, int largestConsecutiveDivisor) {
            Assert.AreEqual(expectedSmallestNumber, problem.GetSmallestNumberDivisibleByAllNumbersUpTo(largestConsecutiveDivisor));
        }

        public static object[][] GetExpectedSmallestNumbersAndTheirLargestConsecutiveDivisors () {
            return new object[][] {
                new object[] { 2520, 10, },
                new object[] { 232792560, 20, },
            };
        }
    }
}
