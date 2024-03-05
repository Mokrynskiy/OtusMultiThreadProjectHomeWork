using System.Numerics;

namespace OtusMultiThreadProjectHomeWork
{
    public class MultiThreadRangeSum
    {
        static object lockObject = new object();
        public BigInteger GetResult(int startInt, int endInt, int threadQty)
        {
            BigInteger result = new BigInteger();      
            List<BigInteger> results = new List<BigInteger>();
            var ranges = Enumerable.Range(startInt, endInt).Split(threadQty);
            Thread[] threads = new Thread[threadQty];
            int threadIndex = 0;
            foreach (var range in ranges)
            {
                threads[threadIndex] = new Thread(() => GetSum(ref results, range.ToList()));
                threadIndex++;
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            foreach (var item in results)
            {
                result += item;
            }
            return result;
        }
        private void GetSum(ref List<BigInteger> results, List<int> range)
        {
            BigInteger sum = new BigInteger();
            foreach (var item in range)
            {
                sum += item;
            }
            results.Add(sum);
        }
    }
}
