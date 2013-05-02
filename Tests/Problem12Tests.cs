using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    class Problem12Tests {
        private Problem12 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem12();
        }

        [TestCaseSource("getSomeNsAndTheirExpectedTriangularNumbers")]
        public void ShouldCorrectlyReturnTheNthTriangularNumber (int n, int expectedTriangularNumber) {
            Assert.AreEqual(expectedTriangularNumber, problem.nthTriangularNumber(n));
        }

        public object[][] getSomeNsAndTheirExpectedTriangularNumbers () {
            return new object[][] {
                new object[] { 1, 1  },
                new object[] { 2, 3  },
                new object[] { 3, 6  },
                new object[] { 4, 10 },
                new object[] { 5, 15 },
                new object[] { 6, 21 },
                new object[] { 7, 28 },
            };
        }

        [TestCaseSource("getSomeNumbersAndTheirExpectedNumbersOfDivisors")]
        public void ShouldCorrectlyReturnTheNumberOfDivisorsForANumber (int n, int expectedNumberOfDivisors) {
            Assert.AreEqual(expectedNumberOfDivisors, problem.numberOfDivisors(n));
        }

        public object[][] getSomeNumbersAndTheirExpectedNumbersOfDivisors () {
            return new object[][] {
                new object[] { 1, 1 },
                new object[] { 3, 2 },
                new object[] { 6, 4 },
                new object[] { 10, 4 },
                new object[] { 15, 4 },
                new object[] { 21, 4 },
                new object[] { 28, 6 },
                new object[] { 36, 9 },
            };
        }

        [Test]
        public void ShouldCorrectlyReturnTheFirstTriangularNumberWithMoreThanFiveHundredDivisors () {
            Assert.AreEqual(76576500, problem.firstTriangularNumberWithMoreDivisorsThan(500));
        }
    }
}