using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Tools {
    public static class Longs {
        public static long Factorial (this long number) {
            return Longs.Range(1, number).Aggregate(
                (x, y) => x * y
            );
        }

        public static IEnumerable<long> Range (long start, long count) {
            while (count-- > 0) {
                yield return start++;
            }
        }

        public static bool DivisibleBy (this long dividend, long divisor) {
            return dividend % divisor == 0;
        }
    }
}
