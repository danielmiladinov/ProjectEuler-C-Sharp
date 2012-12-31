using System;
using System.Collections.Generic;

namespace ProjectEuler.Tools {
    public class PrimeFactorization {
        public static List<PrimeFactor> Of (long number) {
            var primeFactors = new List<PrimeFactor>();
            if (number == 1) {
                return primeFactors;
            } else if (number.IsPrime()) {
                primeFactors.Add(new PrimeFactor(number));
            } else {
                long divisor = 2;
                long exponent = 0;

                while (number >= divisor) {
                    if (number % divisor == 0) {
                        exponent += 1;
                        number = number / divisor;
                    } else {
                        if (exponent > 0) {
                            primeFactors.Add(new PrimeFactor(divisor, exponent));
                        }
                        divisor = divisor.NextPrime();
                        exponent = 0;
                    }
                }

                primeFactors.Add(new PrimeFactor(divisor, exponent));
            }

            return primeFactors;
        }
    }

    public struct PrimeFactor {
        private long baseValue;
        private long exponentValue;

        public long BaseValue { get { return baseValue; } }
        public long ExponentValue { get { return exponentValue; } }

        public PrimeFactor (long prime)
            : this() {
            baseValue = prime;
            exponentValue = 1;
        }

        public PrimeFactor (long prime, long exponent)
            : this(prime) {
            exponentValue = exponent;
        }

        public override string ToString () {
            return String.Format("{0}^{1}", baseValue, exponentValue);
        }
    }
}
