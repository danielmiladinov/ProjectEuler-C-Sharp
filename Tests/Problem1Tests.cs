using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace Tests {
    [TestFixture]
    public class Problem1Tests {
        private Problem1 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem1();
        }

        [TestCaseSource("GetLimitAndExpectedSumOfMultiplesOf3And5")]
        public void ShouldGetTheCorrectAnswer (int limit, int expectedSum) {
            Assert.AreEqual(expectedSum, problem.getSumOfMultiplesOf3And5Below(limit));
        }

        public object[][] GetLimitAndExpectedSumOfMultiplesOf3And5 () {
            var data = new object[][] {
                new object[] { 10, 23 },
                new object[] { 1000, 233168 },
            };

            return data;
        }
    }
}
