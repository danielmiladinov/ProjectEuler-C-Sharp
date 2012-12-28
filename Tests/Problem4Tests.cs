using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    class Problem4Tests {
        private Problem4 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem4();
        }

        [TestCaseSource("getNumbersOfDigitsAndExpectedLargestPalindromicProduct")]
        public void ShouldReturnTheRightResult (int numberOfDigits, int expectedMaxPalindromicProduct) {
            Assert.AreEqual(expectedMaxPalindromicProduct, problem.GetMaxPalindromicProductFromFactorsWithDigits(numberOfDigits));
        }

        public object[][] getNumbersOfDigitsAndExpectedLargestPalindromicProduct () {
            return new object[][] {
                new object[] { 2, 9009, },
            };
        }

        [TestCaseSource("getSomeNumbersAndWhetherOrNotTheyArePalindromic")]
        public void IsPalindromicShouldWorkCorrectly (int candidate, bool expectedResult) {
            Assert.AreEqual(expectedResult, candidate.IsPalindromic());
        }

        public object[][] getSomeNumbersAndWhetherOrNotTheyArePalindromic () {
            return new object[][] {
                new object[] { 1, true, },
                new object[] { 2, true, },
                new object[] { 3, true, },
                new object[] { 4, true, },
                new object[] { 5, true, },
                new object[] { 6, true, },
                new object[] { 7, true, },
                new object[] { 8, true, },
                new object[] { 9, true, },
                new object[] { 10, false, },
                new object[] { 11, true, },
                new object[] { 22, true, },
                new object[] { 100, false, },
                new object[] { 101, true, },
                new object[] { 545, true, },
                new object[] { 309, false, },
                new object[] { 2332, true, },
                new object[] { 9009, true, },
            };
        }
    }
}
