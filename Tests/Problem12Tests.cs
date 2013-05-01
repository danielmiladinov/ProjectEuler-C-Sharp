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
    }
}