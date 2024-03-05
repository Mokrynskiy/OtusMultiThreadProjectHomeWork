using System.Numerics;

namespace OtusMultiThreadProjectHomeWork
{
    public class ParallelLinqRangeSum
    {
        public BigInteger GetResult(int startInt, int endInt)
        {
            return Enumerable.Range(startInt, endInt).AsParallel().Aggregate(
                new BigInteger(0),
                        (subtotal, x) => subtotal + x,
                        (total, thisThread) => total + thisThread,
                        (finalSum) => finalSum); ;
        }
    }
}
