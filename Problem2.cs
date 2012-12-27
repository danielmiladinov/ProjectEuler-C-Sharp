﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem2 {

        public long GetTheValue () {
            return FibonacciSequence(34).Where(
                x => x % 2L == 0L && x <= 4000000L
            ).Sum();
        }
        
        private static IEnumerable<long> FibonacciSequence (long numberOfTerms) {
            long firstTerm = 0, previousTerm = 0, nextTerm = 1;

            do {
                yield return firstTerm;

                previousTerm = firstTerm;
                firstTerm = nextTerm;
                nextTerm = previousTerm + nextTerm;
            } while (--numberOfTerms > 0);
        }
    }
}
