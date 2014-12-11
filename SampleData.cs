using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    static class SampleData
    {
        public static readonly IList<string> Words =
            new List<string> { "the", "quick", "brown", "fox", "jumped",
             "over", "the", "lazy", "dog" }.AsReadOnly();    
    }
}
