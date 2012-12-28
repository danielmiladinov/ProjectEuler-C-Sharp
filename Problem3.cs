using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem3 {
        public long LargestPrimeFactorOf (long number) {
            long divisor = 3;
            long squareRoot = (long)Math.Floor(Math.Sqrt(number));

            while (divisor < squareRoot) {
                if (number % divisor == 0) {
                    return Math.Max(divisor, LargestPrimeFactorOf(number / divisor));
                }

                divisor += 2;
            }

            return number;
        }
    }
}
