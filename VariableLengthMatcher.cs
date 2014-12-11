using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    /// <summary>
    /// Used by Example2a to create a delegate instance which will only match words
    /// of an appropriate length.
    /// </summary>
    public class VariableLengthMatcher
    {
        int maxLength;

        public VariableLengthMatcher(int maxLength)
        {
            this.maxLength = maxLength;
        }

        /// <summary>
        /// Method used as the action of the delegate
        /// </summary>
        public bool Match(string item)
        {
            return item.Length <= maxLength;
        }
    }
}
