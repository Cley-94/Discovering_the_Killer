using System;

namespace DiscoverKiller.Extensions
{
    public static class Extensions
    {
        public static int FindIndexHypotheseArray<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
}
