using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler {
    public class Problem7 {
        public long FromThePrimeNumberSequenceTheElement (long number) {
            long theNextPrime = 2;
            Longs.Range(1, number - 1).ToList().ForEach(x => theNextPrime = theNextPrime.NextPrime());
            return theNextPrime;
        }
    }
}
