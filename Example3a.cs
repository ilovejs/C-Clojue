using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    class Example3a
    {
        static void Main()
        {
            // First build a list of actions
            List<Action> actions = new List<Action>();
            for (int counter = 0; counter < 10; counter++)
            {
                actions.Add(() => Console.WriteLine(counter));
            }

            // Then execute them
            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}
