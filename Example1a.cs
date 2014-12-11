using System;
using System.Collections.Generic;

namespace Closures
{
    /// <summary>
    /// Creates a Predicate delegate instance using a static method
    /// in the same class, using C# 1 syntax.
    /// </summary>
    class Example1a
    {
        static void Main()
        {
            Predicate<string> predicate = new Predicate<string>(MatchFourLettersOrFewer);
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }

        static bool MatchFourLettersOrFewer(string item)
        {
            return item.Length <= 4;
        }
    }
}
