using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler {
    public static class Integers {
        public static IEnumerable<int> DescendingRange (int start, int stop) {
            for (int i = start; i >= stop; i--) {
                yield return i;
            }
        }

        public static bool IsPalindromic (this int candidate) {
            string forwards = candidate.ToString();
            char[] digits = forwards.ToCharArray();
            Array.Reverse(digits);
            string backwards = new String(digits);
            return forwards == backwards;
        }
    }
}
