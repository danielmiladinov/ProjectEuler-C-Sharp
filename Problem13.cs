using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler {
    public class Problem13 {
        public string getFirstTenDigitsFromTheSumOf (List<string> bigNumbers) {
            return bigNumbers
                .Select(str => BigInteger.Parse(str))
                .Aggregate((x, y) => x + y)
                .ToString()
                .Substring(0, 10);
        }
    }
}
