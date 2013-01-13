using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    class Problem10Tests {
        private Problem10 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem10();
        }

        [TestCaseSource("getSomeUpperLimitsAndTheExpectedSumOfAllPrimesBelowThem")]
        public void ShouldReturnTheCorrectSummationOfPrimes (long upperLimit, long expectedSummationOfPrimes) {
            Assert.AreEqual(expectedSummationOfPrimes, problem.getSummationOfPrimesBelow(upperLimit));
        }


        public object[][] getSomeUpperLimitsAndTheExpectedSumOfAllPrimesBelowThem () {
            return new object[][] {
                new object[] { 10L, 17L },
                new object[] { 2000000L, 142913828922L }
            };
        }
    }
}
