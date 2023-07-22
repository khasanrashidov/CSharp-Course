namespace LINQ
{
    // LINQ - Language Integrated Query 
    // It is a set of technologies based on the integration of query capabilities directly into the C# language
    // LINQ is a set of methods that allow us to query data from different data sources
    // It is very convenient to use LINQ with collections
    // LINQ helps us to write less code and make it more readable
    // and write it inplace where we need it (no need to create methods and call them)

    public static class LinqExtensions
    {
        // this IEnumerable<T> source - this is extension method
        // we use it like this: source.Foreach(item => Console.WriteLine(item));
        public static void Foreach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                throw new ArgumentNullException();

            foreach (var item in source)
            {
                action(item);
            }

        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayLargestFilesWithoutLinq(@"C:\Users\KHASAN\Desktop\books");

            Console.WriteLine("**********");

            DisplayLargestFilesWithLinq(@"C:\Users\KHASAN\Desktop\books");
        }

        private static void DisplayLargestFilesWithLinq(string pathToDir)
        {
            // In LINQ we can access every LINQ method with (after) . (dot)
            // because every LINQ method returns IEnumerable as a result
            // and we can call methods again again on IEnumerable
            new DirectoryInfo(pathToDir)
            .GetFiles()
            .OrderByDescending(file => file.Length) // in one line we don't use return keyword, {} and ;
            .Take(5)
            .Foreach(file => Console.WriteLine($"{file.Name} weighs {file.Length} bytes"));

            // if multiple lines then we use brackets {} and return keyword with ; 
            // .OrderBy(file => {
            //     return file.Length;
            //     });

            // Alternative way
            // IEnumerable<FileInfo> orderedFiles = new DirectoryInfo(pathToDir).GetFiles().OrderBy(file => file.Length).Take(5);
            // foreach (var file in orderedFiles)
            // {
            //     Console.WriteLine($"{file.Name} weighs {file.Length} bytes");
            // }

        }

        // for new DirectoryInfo(pathToDir).OrderBy(KeySelector)
        // static long KeySelector(FileInfo file)
        // {
        //     return file.Length;
        // }

        private static void DisplayLargestFilesWithoutLinq(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files, FilesComparison);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weighs {file.Length} bytes");
            }

        }

        private static int FilesComparison(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        }
    }
}