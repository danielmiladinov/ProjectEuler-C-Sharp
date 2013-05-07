using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler {
    public class Problem14 {
        public IEnumerable<long> CollatzSequenceOf (long start) {
            var i = start;

            while (i > 1) {
                yield return i;

                if (i.DivisibleBy(2)) {
                    i /= 2;
                } else {
                    i = 3 * i + 1;
                }
            }

            yield return 1;
        }
    }
}
