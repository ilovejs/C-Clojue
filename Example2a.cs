using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    /// <summary>
    /// Asks the user for a maximum string length before filtering.
    /// The delegate is implemented in a VariableLengthMatcher.
    /// </summary>
    class Example2a
    {
        static void Main()
        {
            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            VariableLengthMatcher matcher = new VariableLengthMatcher(maxLength);
            Predicate<string> predicate = matcher.Match;
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
