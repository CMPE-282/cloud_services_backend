using System.Linq;

namespace CloudServiceProjectApi.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string s) => !s?.Any() ?? true;
    }
}