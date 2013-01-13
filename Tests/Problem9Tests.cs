using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using NUnit.Framework;

namespace Tests {
    [TestFixture]
    class Problem9Tests {
        private Problem9 problem;

        [SetUp]
        public void SetUp () {
            problem = new Problem9();
        }

        [TestCaseSource("GetSomeNumbersAndThePythagoreanTripletsThatShouldAddUpToThem")]
        public void ShouldGetTheRightAnswer (int theSum, List<int> theList) {
            CollectionAssert.AreEqual(theList, problem.GetPythagoreanTripletWhoseSumEquals(theSum));
        }

        public object[][] GetSomeNumbersAndThePythagoreanTripletsThatShouldAddUpToThem () {
            return new object[][] {
                new object[] { 12, new List<int> { 3, 4, 5 }, },
                new object[] { 1000, new List<int> { 200, 375, 425 }, },
            };
        }
    }
}
