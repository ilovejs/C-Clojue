using System;
using System.Collections.Generic;

namespace Closures
{
    /// <summary>
    /// Creates a Predicate delegate instance using a lambda expression.
    /// </summary>
    class Example1d
    {
        static void Main()
        {
            Predicate<string> predicate = item => item.Length <= 4;
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
