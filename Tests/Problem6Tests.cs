using NUnit.Framework;
using ProjectEuler;

namespace Tests {
    [TestFixture]
    class Problem6Tests {
        private Problem6 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem6();
        }

        [Test]
        public void SumOfTheSquaresOfTheFirstTenNaturalNumbers () {
            Assert.AreEqual(385, problem.SumOfTheSquaresFromOneTo(10));
        }

        [Test]
        public void SquareOfTheSumOfTheFirstTenNaturalNumbers () {
            Assert.AreEqual(3025, problem.SquareOfTheSumsFromOneTo(10));
        }

        [Test]
        public void DifferenceOfTheSquareOfTheSumsAndTheSumOfTheSquaresOfTheFirstTenNaturalNumbers () {
            Assert.AreEqual(2640, problem.SquareOfTheSumsFromOneTo(10) - problem.SumOfTheSquaresFromOneTo(10));
        }
    }
}
