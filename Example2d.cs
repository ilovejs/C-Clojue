using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    /// <summary>
    /// Asks the user for a maximum string length before filtering,
    /// then change the value of the variable and filter again.
    /// The delegate is implemented using a lambda expression.
    /// </summary>
    class Example2d
    {
        static void Main()
        {
            Console.Write("Maximum length of string to include? ");
            int maxLength = int.Parse(Console.ReadLine());

            Predicate<string> predicate = item => item.Length <= maxLength;
            IList<string> shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);

            Console.WriteLine("Now for words with <= 5 letters:");
            maxLength = 5;
            shortWords = ListUtil.Filter(SampleData.Words, predicate);
            ListUtil.Dump(shortWords);
        }
    }
}
