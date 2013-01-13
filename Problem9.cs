using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler {
    public class Problem9 {
        public List<int> GetPythagoreanTripletWhoseSumEquals (int sumConstraint) {
            int aUpperBound,
                bUpperBound,
                cUpperBound,
                a = 3, aLowerBound = 3,
                b = 4, bLowerBound = 4,
                c = 5, cLowerBound = 5;

            do {
                aUpperBound = aLowerBound * 2;
                bUpperBound = bLowerBound * 2;
                cUpperBound = cLowerBound * 2;

                for (a = aLowerBound; a <= aUpperBound; a++) {
                    for (b = bLowerBound; b <= bUpperBound; b++) {
                        for (c = cLowerBound; c <= cUpperBound; c++) {
                            if (areThePythagoreanTriple(a, b, c, sumConstraint)) {
                                return new List<int> { a, b, c };
                            }
                        }
                    }
                }

                aLowerBound = aUpperBound;
                bLowerBound = bUpperBound;
                cLowerBound = cUpperBound;
            } while ((a + b + c) < sumConstraint);

            return new List<int>();
        }

        private bool areThePythagoreanTriple (int a, int b, int c, int sumConstraint) {
            int aSquared = a * a;
            int bSquared = b * b;
            int cSquared = c * c;

            return ((aSquared + bSquared == cSquared) && (a + b + c == sumConstraint));
        }
    }
}
