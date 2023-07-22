using System;
using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // LINQ - Lazy Loading
            // LINQ is a lazy loading technology. 
            // It means that the query is not executed until the result is needed.
            // In the following example, the query is not executed until the foreach loop is executed.
            // The query is executed when the foreach loop is executed because the result is needed to iterate over.

            // Deferred Execution - The query is executed when the result is needed. (or Lazy Loading)
            // Where() is a deferred execution method. 
            // Similarly, Select(), Take(), Skip(), SelectMany(), etc.

            // Greedy Loading - The query is executed immediately. (or Eager Loading or Immediate Execution)
            // Count() is a greedy loading method. 
            // Similarly, ToList(), ToArray(), Average(), First(), Max(), Min(), Sum(), Last(), etc.

            var list = new List<int> { 1, 2, 3 };
            var query = list.Where(x => x >= 2);

            list.Remove(3);

            // The query was executed when we called the Count() method.
            // But by that time, the list had only two items.
            // And where x >= 2 was true only for one item.
            // So, the Count() method returned 1.
            Console.WriteLine(query.Count());

            // The query was executed when we called the foreach loop as the result was needed to iterate over.
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }


            // Now, using ToList() method, we can execute the query immediately.
            // The query is executed immediately and the result is stored in the list.
            var list2 = new List<int> { 1, 2, 3 };
            var query2 = list2.Where(x => x >= 2).ToList();

            list2.Remove(3);

            // The query was executed immediately and the result was stored in the list.
            // So, the Count() method returned 2.
            Console.WriteLine(query2.Count());

            // The query was executed immediately and the result was stored in the list.
            // So, the foreach loop iterated over the list.
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }

        }
    }
}