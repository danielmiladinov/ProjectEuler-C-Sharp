using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    class Problem14Tests {
        private Problem14 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem14();
        }

        [Test]
        public void ShouldProduceTheCorrectCollatzSequenceOfThirteen () {
            CollectionAssert.AreEqual(
                new List<int> { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 },
                problem.CollatzSequenceOf(13).TakeWhile(i => i >= 1).ToList()
            );
        }
    }
}
