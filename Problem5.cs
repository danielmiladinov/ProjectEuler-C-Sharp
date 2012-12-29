using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem5 {
        public int GetSmallestNumberDivisibleByAllNumbersUpTo (int largestConsecutiveDivisor) {
            var candidates = Enumerable.Range(
                largestConsecutiveDivisor,
                largestConsecutiveDivisor.Factorial() - largestConsecutiveDivisor
            );

            var divisors = Enumerable.Range(2, largestConsecutiveDivisor - 2);

            var results = from candidate in candidates
                          where divisors.All(divisor => candidate.DivisibleBy(divisor))
                          select candidate;

            return results.FirstOrDefault();
        }
    }
}
