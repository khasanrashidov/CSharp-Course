namespace CollectionsForeach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //RemoveInForeach();
            RemoveInFor();
            RemoveInForReverse();
            RemoveAllDemo();
        }

        public static void RemoveAllDemo()
        {
            // Predicate<T> is a delegate that takes one argument of type T and returns a bool.
            // Predicate<T> is used in List<T> methods such as Find, FindAll, RemoveAll, etc.
            // RemoveAll() is greedy operation, it will remove all items that match the condition.
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            list.RemoveAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.Count() == 3);
        }

        public static void RemoveInForReverse()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 0) // or if(list[i] <= 3)
                {
                    list.Remove(list[i]);
                    // no need to decrement the index because we are iterating backwards
                }
            }
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.Count() == 3);
        }

        public static void RemoveInFor()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0) // or if(list[i] <= 3)
                {
                    list.Remove(list[i]);
                    i--; // we need to decrement the index as well because we removed an item
                }
            }
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.Count() == 3);
        }

        // Modifying Collections in Foreach
        // It will throw an exception (InvalidOperationException)
        // because we are modifying the collection 
        // while enumerating over it in the foreach loop.
        // public static void RemoveInForeach()
        // {
        //     var list = new List<int> { 0, 1, 2, 3, 4, 5 };
        //     foreach (var item in list)
        //     {
        //         if (item % 2 == 0)
        //         {
        //             list.Remove(item);
        //         }
        //     }
        //     Console.WriteLine(string.Join(" ", list));
        // }

        // In general, foreach loop is protected against collection modifications
        // foreach loop is translated into a call to the GetEnumerator method
        // and then a series of calls to the MoveNext and Current properties of the enumerator.
        // The enumerator is obtained before the loop starts and is not changed during the loop.
        // The collection is not modified until the loop completes.
        // For example foreach loop looks as follows:
        // List<int>.Enumerator enumerator = list.GetEnumerator();
        // try
        // {
        //     while (enumerator.MoveNext())
        //     {
        //         int item = enumerator.Current;
        //         Console.WriteLine(item);
        //     }
        // }
        // finally
        // {
        //     enumerator.Dispose();
        // }   
    }
}