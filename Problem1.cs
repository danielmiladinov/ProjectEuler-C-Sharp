﻿using System.Linq;

namespace ProjectEuler {
    public class Problem1 {
        public int getSumOfMultiplesOf3Or5Below (int limit) {
            return Enumerable.Range(1, limit - 1).Where(
                x => (x % 3 == 0 || x % 5 == 0)
            ).Sum();
        }
    }
}
