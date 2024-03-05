using System.Numerics;

namespace OtusMultiThreadProjectHomeWork
{
    internal class OneThreadRangeSum
    {
        public BigInteger GetResult(int startInt, int endInt)
        {
            BigInteger result = BigInteger.Zero;
            var range = Enumerable.Range(startInt, endInt);
            foreach (var item in range)
            {
                result += item;
            }
            return result;
        }
    }
}
