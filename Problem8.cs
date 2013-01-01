using System;
using System.Linq;

namespace ProjectEuler {
    public class Problem8 {
        public int GreatestProductOfFiveConsecutiveDigitsIn (string veryLargeNumber) {
            return Enumerable.Range(0, veryLargeNumber.Length - 5)
                .Select(i => veryLargeNumber.Substring(i, 5)
                    .Select(c => Int32.Parse(c.ToString()))
                    .Aggregate((x, y) => x * y))
                    .Max();
        }
    }
}
