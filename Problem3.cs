using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem3 {
        public long LargestPrimeFactorOf (long number) {
            return PrimeFactorsOf(number).Max();
        }
    }

    public static class LongExtensions {
        public static bool IsPrime (this long number) {
            if ((number % 2) == 0) {
                return number == 2;
            }

            long sqrt = (long)Math.Sqrt(number);

            for (long t = 3; t <= sqrt; t = t + 2) {
                if (number % t == 0) {
                    return false;
                }
            }

            return number != 1;
        }
    }
}
