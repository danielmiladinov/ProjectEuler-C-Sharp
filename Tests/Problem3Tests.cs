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
                new List<long>() { 5, 7, 13, 29 },
                problem.PrimeFactorsOf(13195)
            );
        }

        [TestCaseSource("GetNumbersAndTheirExpectedLargestPrimeFactors")]
        public void ShouldReturnTheCorrectLargestPrimeFactor (long number, long expectedLargestPrimeFactor) {
            Assert.AreEqual(expectedLargestPrimeFactor, problem.LargestPrimeFactorOf(number));
        }

        public static long[][] GetNumbersAndTheirExpectedLargestPrimeFactors () {
            return new long[][] {
                new long[] { 13195, 29, },
            };
        }
    }
}
