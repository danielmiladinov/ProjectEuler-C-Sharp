using System;
using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler {
    public class Problem6 {
        public long SumOfTheSquaresFromOneTo (long number) {
            return Longs.Range(1, number).Select(x => (long)Math.Pow(x, 2)).Sum();
        }

        public long SquareOfTheSumsFromOneTo (long number) {
            return (long)Math.Pow(Longs.Range(1, number).Sum(), 2);
        }
    }
}
