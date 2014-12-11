using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    /// <summary>
    /// Asks the user for a maximum string length before filtering.
    /// The delegate is implemented using a lambda expression.
    /// </summary>
    class Example2c
    {
        static void Main()
        {
            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            Predicate<string> predicate = item => item.Length <= maxLength;
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
