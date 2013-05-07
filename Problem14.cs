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

        public long GetNumberWithLongestCollatzSequenceBelow (long limit) {
            return Longs.Range(1, limit)
                .ToDictionary(
                    number => number,
                    number => CollatzSequenceOf(number)
                        .TakeWhile(i => i >= 1)
                        .Count()
                ).Aggregate((collatz1, collatz2) =>
                    collatz2.Value > collatz1.Value ? collatz2 : collatz1
                ).Key;
        }
    }
}
