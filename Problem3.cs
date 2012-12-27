using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem3 {
        public List<long> PrimeFactorsOf (long number) {
            return LongExtensions.Range(1, number - 1).Where(
                x => (x.IsPrime()) && (number % x == 0)
            ).ToList();
        }

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

        public static IEnumerable<long> Range (long start, long stop) {
            for (long i = start; i <= stop; i++) {
                yield return i;
            }
        }
    }
}
