using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem3 {
        public List<int> PrimeFactorsOf (int number) {
            return Enumerable.Range(1, number - 1).Where(
                x => (x.IsPrime()) && (number % x == 0)
            ).ToList();
        }
    }

    public static class IntExtensions {
        public static bool IsPrime (this int number) {
            if ((number % 2) == 0) {
                return number == 2;
            }

            int sqrt = (int)Math.Sqrt(number);

            for (int t = 3; t <= sqrt; t = t + 2) {
                if (number % t == 0) {
                    return false;
                }
            }

            return number != 1;
        }
    }
}
