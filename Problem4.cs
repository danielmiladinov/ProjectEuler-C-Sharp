using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem4 {

        public int GetMaxPalindromicProductFromFactorsWithDigits (int numberOfDigits) {
            return 0;
        }
    }

    public static class Integers {
        public static bool IsPalindromic (this int candidate) {
            string forwards = candidate.ToString();
            char[] digits = forwards.ToCharArray();
            Array.Reverse(digits);
            string backwards = new String(digits);
            return forwards == backwards;
        }
    }
}
