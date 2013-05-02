﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem12 {
        public int nthTriangularNumber (int n) {
            return Enumerable.Range(1, n).Aggregate((x, y) => x + y);
        }

        public int numberOfDivisors (int n) {
            var squareRoot = (int) Math.Sqrt(n);
            var numberOfDivisors = Enumerable.Range(1, squareRoot).Select(x =>
                n % x == 0 ? 2 : 0
            ).Sum();
            if (squareRoot * squareRoot == n) {
                numberOfDivisors -= 1;
            }
            return numberOfDivisors;
        }
    }
}
