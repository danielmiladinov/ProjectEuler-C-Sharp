using System.Collections.Generic;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace Tests {
    [TestFixture]
    class PrimeFactorizationTests {

        [Test]
        public void OneIsNotPrimeFactorizable () {
            CollectionAssert.IsEmpty(PrimeFactorization.Of(1));
        }

        [TestCaseSource("GetSomeNumbersAndTheirPrimeFactorizations")]
        public void PrimeFactorizationShouldWorkCorrectly (int number, List<PrimeFactor> expectedPrimeFactorization) {
            CollectionAssert.AreEquivalent(
                expectedPrimeFactorization,
                PrimeFactorization.Of(number)
            );
        }

        public object[][] GetSomeNumbersAndTheirPrimeFactorizations () {
            return new object[][] {
                new object[] { 2, new List<PrimeFactor> { new PrimeFactor(2) }, },
                new object[] { 3, new List<PrimeFactor> { new PrimeFactor(3) }, },
                new object[] { 4, new List<PrimeFactor> { new PrimeFactor(2, 2) }, },
                new object[] { 5, new List<PrimeFactor> { new PrimeFactor(5) }, },
                new object[] { 6, new List<PrimeFactor> { new PrimeFactor(2), new PrimeFactor(3), }, },
                new object[] { 7, new List<PrimeFactor> { new PrimeFactor(7), }, },
                new object[] { 8, new List<PrimeFactor> { new PrimeFactor(2, 3), }, },
                new object[] { 9, new List<PrimeFactor> { new PrimeFactor(3, 2), }, },
                new object[] { 10, new List<PrimeFactor> { new PrimeFactor(2), new PrimeFactor(5), }, },
                new object[] { 11, new List<PrimeFactor> { new PrimeFactor(11), }, },
                new object[] { 12, new List<PrimeFactor> { new PrimeFactor(2, 2), new PrimeFactor(3), }, },
                new object[] { 13, new List<PrimeFactor> { new PrimeFactor(13), }, },
                new object[] { 14, new List<PrimeFactor> { new PrimeFactor(2), new PrimeFactor(7), }, },
                new object[] { 15, new List<PrimeFactor> { new PrimeFactor(3), new PrimeFactor(5), }, },
                new object[] { 16, new List<PrimeFactor> { new PrimeFactor(2, 4), }, },
                new object[] {
                    232792560,
                    new List<PrimeFactor> {
                        new PrimeFactor(2, 4),
                        new PrimeFactor(3, 2),
                        new PrimeFactor(5),
                        new PrimeFactor(7),
                        new PrimeFactor(11),
                        new PrimeFactor(13),
                        new PrimeFactor(17),
                        new PrimeFactor(19),
                    },
                },
            };
        }

        [TestCaseSource("GetSomePrimeFactorsAndTheirExpectedLongValues")]
        public void PrimeFactorsShouldReturnTheCorrectLongValues (PrimeFactor factor, long expected) {
            Assert.AreEqual(expected, factor.LongValue);
        }

        public object[][] GetSomePrimeFactorsAndTheirExpectedLongValues () {
            return new object[][] {
                new object[] { new PrimeFactor(2, 3), 8, },
                new object[] { new PrimeFactor(5), 5, },
                new object[] { new PrimeFactor(5, 2), 25, },
                new object[] { new PrimeFactor(10, 2), 100, },
                new object[] { new PrimeFactor(2, 32), 4294967296, },
            };
        }
    }
}
