using System.Linq;

namespace CloudServiceProjectApi.Infrastructure.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> GetPage<T>(this IOrderedQueryable<T> source, int page, int count) => source?
            .Skip(((page - 1) * count).ToZeroIfNegative())
            .Take(count.ToZeroIfNegative())
            ?? Enumerable.Empty<T>().AsQueryable();
    }
}