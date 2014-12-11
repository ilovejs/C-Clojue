using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Closures
{
    class Example3b
    {
        static void Main()
        {
            // First build a list of actions
            List<Action> actions = new List<Action>();
            for (int counter = 0; counter < 10; counter++)
            {
                int copy = counter;
                actions.Add(() => Console.WriteLine(copy));
            }

            // Then execute them
            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}
