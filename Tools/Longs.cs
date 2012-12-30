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

        public static long NextPrime (this long number) {
            switch (number) {
                case 1: return 2;
                default: {
                    long searchLimit = number * 2;

                    for (long i = number + 1; i < searchLimit; ++i) {
                        if (i.IsPrime()) {
                            return i;
                        }
                    }

                    return searchLimit;
                }
            }
        }
    }
}
