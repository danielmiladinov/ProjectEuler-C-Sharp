using NUnit.Framework;
using ProjectEuler;
using System.Collections.Generic;

namespace Tests {
    [TestFixture]
    class Problem3Tests {
        private Problem3 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem3();
        }

        [Test]
        public void ShouldReturnCorrectListOfPrimeFactors () {
            // The prime factors of 13195 are 5, 7, 13 and 29.
            CollectionAssert.AreEqual(
                new List<int>() { 5, 7, 13, 29 },
                problem.PrimeFactorsOf(13195)
            );
        }

        [TestCaseSource("GetNumbersAndTheirExpectedLargestPrimeFactors")]
        public void ShouldReturnTheCorrectLargestPrimeFactor (int number, int expectedLargestPrimeFactor) {
            Assert.AreEqual(expectedLargestPrimeFactor, problem.LargestPrimeFactorOf(number));
        }

        public static int[][] GetNumbersAndTheirExpectedLargestPrimeFactors () {
            return new int[][] {
                new int[] { 13195, 29, },
            };
        }
    }
}
