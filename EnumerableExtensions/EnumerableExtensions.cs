namespace EnumerableExtensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<TSource>> SplitBy<TSource>(this IEnumerable<TSource> source,
                                                                       Func<TSource, bool> predicate)
        {
            ICollection<ICollection<TSource>> result = new List<ICollection<TSource>>();
            ICollection<TSource> innerCollection = new List<TSource>();

            foreach (TSource item in source) 
            {
                if (!predicate(item))
                {
                    innerCollection.Add(item);

                }
                else
                {
                    result.Add(innerCollection);
                    innerCollection = new List<TSource>();
                    continue;
                }
            }
            result.Add(innerCollection);

            return result.Where(r => r.Any()); // to avoid returning the empty collections. Maybe fix logic so that the .Where() isn't needed.
        }
    }
}