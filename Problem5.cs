using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler {
    public class Problem5 {
        public long GetSmallestNumberDivisibleByAllNumbersUpTo (long largestConsecutiveDivisor) {
            var primesOfGreatestPower = new Dictionary<long, PrimeFactor>();

            Longs.Range(2, largestConsecutiveDivisor - 2).Select(
                x => PrimeFactorization.Of(x)
            ).ToList().ForEach(
                factors => factors.ForEach(
                    factor => {
                        if (primesOfGreatestPower.ContainsKey(factor.BaseValue)) {
                            var currentFactor = primesOfGreatestPower[factor.BaseValue];
                            primesOfGreatestPower[factor.BaseValue] = (
                                currentFactor.ExponentValue > factor.ExponentValue ?
                                currentFactor :
                                factor
                            );
                        } else {
                            primesOfGreatestPower.Add(factor.BaseValue, factor);
                        }
                    }
                )
            );

            return primesOfGreatestPower.Select(
                factorByBaseValue => factorByBaseValue.Value.LongValue
            ).Aggregate((x, y) => x * y);
        }
    }
}
