using System;
using System.Collections.Generic;

namespace Closures
{
    /// <summary>
    /// Creates a Predicate delegate instance using an anonymous method.
    /// </summary>
    class Example1c
    {
        static void Main()
        {
            Predicate<string> predicate = delegate(string item)
                {
                    return item.Length <= 4;
                };
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
