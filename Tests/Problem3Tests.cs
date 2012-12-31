using NUnit.Framework;
using ProjectEuler;

namespace Tests {
    [TestFixture]
    class Problem3Tests {
        private Problem3 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem3();
        }

        [TestCaseSource("GetNumbersAndTheirExpectedLargestPrimeFactors")]
        public void ShouldReturnTheCorrectLargestPrimeFactor (long number, long expectedLargestPrimeFactor) {
            Assert.AreEqual(expectedLargestPrimeFactor, problem.LargestPrimeFactorOf(number));
        }

        public static long[][] GetNumbersAndTheirExpectedLargestPrimeFactors () {
            return new long[][] {
                new long[] { 13195, 29, },
                new long[] { 600851475143, 6857 },
            };
        }
    }
}
