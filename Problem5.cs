using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

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
}
