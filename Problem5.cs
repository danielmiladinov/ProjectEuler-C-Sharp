using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem5 {
        public long GetSmallestNumberDivisibleByAllNumbersUpTo (long largestConsecutiveDivisor) {
            var candidates = Longs.Range(
                largestConsecutiveDivisor,
                largestConsecutiveDivisor.Factorial() - largestConsecutiveDivisor
            );

            var divisors = Longs.Range(2, largestConsecutiveDivisor - 2);

            var results = from candidate in candidates
                          where divisors.All(divisor => candidate.DivisibleBy(divisor))
                          select candidate;

            return results.FirstOrDefault();
        }
    }

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
