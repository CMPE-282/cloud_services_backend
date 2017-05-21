namespace CloudServiceProjectApi.Infrastructure.Extensions
{
    public static class IntExtensions
    {
        public static int ToZeroIfNegative(this int i) => i < 0 ? 0 : i;
    }
}