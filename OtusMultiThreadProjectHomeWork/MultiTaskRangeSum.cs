using System.Numerics;

namespace OtusMultiThreadProjectHomeWork
{
    public class MultiTaskRangeSum
    {
        public async Task<BigInteger> GetResult(int startInt, int endInt, int taskQty)
        {
            BigInteger result = new BigInteger();            
            var ranges = Enumerable.Range(startInt, endInt).Split(taskQty);           
            List<Task<BigInteger>> tasks = new List<Task<BigInteger>>();            
            foreach (var range in ranges)
            {
                tasks.Add(GetSum(range.ToList()));
            }
            BigInteger[] results = await Task.WhenAll(tasks);
            foreach (var item in results)
            {
                result += item;
            }
            return result;
        }
        private async Task<BigInteger> GetSum(List<int> range)
        {
            BigInteger sum = new BigInteger();
            await Task.Delay(0);
            foreach (var item in range)
            {
                sum += item;
            }
            return sum;
        }
    }
}
