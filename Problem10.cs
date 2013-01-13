using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler {
    public class Problem10 {
        public long getSummationOfPrimesBelow (long upperLimit) {
            return GetPrimesBelow(upperLimit).Sum();
        }

        public IEnumerable<long> GetPrimesBelow (long upperLimit) {
            for (long i = 2L; i < upperLimit; i = i.NextPrime()) {
                yield return i;
            }
        }
    }
}
