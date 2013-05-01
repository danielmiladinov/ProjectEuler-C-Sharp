﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
    public class Problem12 {
        public int nthTriangularNumber (int n) {
            return Enumerable.Range(1, n).Aggregate((x, y) => x + y);
        }
    }
}
