using NUnit.Framework;
using ProjectEuler;

namespace Tests {
    [TestFixture]
    class Problem7Tests {
        private Problem7 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem7();
        }

        [Test]
        public void ShouldReturnTheCorrectAnswerForTheSixthPrime () {
            Assert.AreEqual(13, problem.FromThePrimeNumberSequenceTheElement(6));
        }

        [Test]
        public void ShouldReturnTheCorrectAnswerForTheTenThousandFirstPrime () {
            Assert.AreEqual(104743, problem.FromThePrimeNumberSequenceTheElement(10001));
        }
    }
}
