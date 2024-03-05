namespace OtusMultiThreadProjectHomeWork
{
    public static class ExtentionsMethods
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> array, int partsQty)
        {
            int size = array.Count() / partsQty;
            for (var i = 0; i < (float)array.Count() / size; i++)
            {
                yield return array.Skip(i * size).Take(size);
            }
        }
    }
}
