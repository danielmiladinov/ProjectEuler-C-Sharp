using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace Tests {
    [TestFixture]
    class Problem2Tests {
        private Problem2 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem2();
        }

        [Test]
        public void shouldReturnTheCorrectSumOfEvenFibonacciSequenceTermsWhoseValuesAreLessThanFourMillion () {
            Assert.AreEqual(4613732L, problem.GetTheValue());
        }
    }
}
