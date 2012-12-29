using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem4 {

        public int GetMaxPalindromicProductFromFactorsWithDigits (int numberOfDigits) {
            var topOfRange = (int)Math.Pow(10, numberOfDigits) - 1;
            var bottomOfRange = (int)Math.Pow(10, numberOfDigits - 1);
            var palindromes = new List<int>();

            var outer = Integers.DescendingRange(topOfRange, bottomOfRange).ToList();
            var inner = Integers.DescendingRange(topOfRange, bottomOfRange).ToList();

            foreach (int x in outer) {
                foreach (int y in inner) {
                    var product = x * y;

                    if (product.IsPalindromic()) {
                        palindromes.Add(product);
                    }
                }

                inner.Remove(x);
            }

            return palindromes.Max();
        }
    }
}
