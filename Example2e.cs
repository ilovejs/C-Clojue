using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    /// <summary>
    /// First iteration, filter with length 1, then length 2, then length 3 etc.
    /// </summary>
    class Example2e
    {
        static void Main()
        {
            int maxLength = 0;

            Predicate<string> predicate = item => { maxLength++; return item.Length <= maxLength; };
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
