using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    /// <summary>
    /// Utility methods operating on lists.
    /// </summary>
    static class ListUtil
    {
        /// <summary>
        /// Creates a new list which contains only the elements in the
        /// original which match the specified predicate.
        /// </summary>
        public static IList<T> Filter<T>(IList<T> source, Predicate<T> predicate)
        {
            List<T> ret = new List<T>();
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    ret.Add(item);
                }
            }
            return ret;
        }

        /// <summary>
        /// Prints the contents of the list to the console.
        /// </summary>
        public static void Dump<T>(IList<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
