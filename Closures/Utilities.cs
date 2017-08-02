namespace Closures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    static class Utilities
    {
        public static IList<T> Filter<T>(IList<T> source, Predicate<T> predicate)
        {
            return source.Where(item => predicate(item)).ToList();
        }
    }
}
