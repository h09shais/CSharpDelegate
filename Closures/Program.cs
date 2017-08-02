namespace Closures
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Closures allow you to encapsulate some behaviour, pass it around like any other object, and still have access to the context in which they were first declared
            // A predicate is simply something which matches or doesn't match a given item
            // In C# the natural way of representing a predicate is as a delegate

            Predicate<string> predicate1 = delegate (string item)
            {
                return item.Length <= 5;
            };
            var shortWords = Utilities.Filter(SampleData.Words, predicate1);
            Console.WriteLine(string.Join(",", shortWords));

            var maxLength = 5;
            Predicate<string> predicate2 = delegate (string item)
            {
                maxLength++;
                return item.Length <= maxLength;
            };

            shortWords = Utilities.Filter(SampleData.Words, predicate2);
            Console.WriteLine(string.Join(",", shortWords));
            
            // .NET Action delegate
            var actions = new List<Action>();
            for (var counter = 0; counter < 10; counter++)
            {
                var copy = counter;
                actions.Add(() => Console.WriteLine(copy));
            }

            foreach (var action in actions)
            {
                action();
            }

            Console.ReadLine();
        }
    }
}
