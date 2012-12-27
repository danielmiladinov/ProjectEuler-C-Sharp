using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler {
    public class Problem2 {

        public long GetTheValue () {
            return FibonacciSequence(34).Where(
                x => x % 2L == 0L && x <= 4000000L
            ).Sum();
        }
        
        private static IEnumerable<long> FibonacciSequence (long numberOfTerms) {
            long currentTerm = 0, previousTerm = 0, nextTerm = 1;

            do {
                yield return currentTerm;

                previousTerm = currentTerm;
                currentTerm = nextTerm;
                nextTerm = previousTerm + nextTerm;
            } while (--numberOfTerms > 0);
        }
    }
}
