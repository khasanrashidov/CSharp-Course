using System;
using System.IO;

namespace Files
{
    class FileDirectories
    {
        static void Main(string[] args)
        {
            // We should always use try-catch-finally block when working with files
            try
            {
                FileDirectoriesDemo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

            string path = @"c:\temp\myfolder\file1.txt";
            Console.WriteLine("Path: " + path);
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            Console.WriteLine("GetTempFileName: " + Path.GetTempFileName());

        }

        static void FileDirectoriesDemo()
        {
            // Create a directory
            Directory.CreateDirectory("C:\\Users\\Public\\TestFolder");

            // Create a file
            File.Create("C:\\Users\\Public\\TestFolder\\TestFile.txt");

            // Copy a file
            File.Copy("C:\\Users\\Public\\TestFolder\\TestFile.txt", "C:\\Users\\Public\\TestFolder\\TestFile2.txt", overwrite: true);

            // Move a file
            File.Move("C:\\Users\\Public\\TestFolder\\TestFile2.txt", "C:\\Users\\Public\\TestFolder\\TestFile3.txt");

            // Get all files in a directory
            string[] files = Directory.GetFiles("C:\\Users\\Public\\TestFolder");
            Console.WriteLine("Files in the directory:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            if (File.Exists("C:\\Users\\Public\\TestFolder\\TestFile3.txt"))
            {
                File.AppendAllText("C:\\Users\\Public\\TestFolder\\TestFile3.txt", "Hello World!");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            // Replace a file
            // arguments: destination file, source file, backup file
            // backup file is used to restore the original file if the replacement fails
            File.Replace("C:\\Users\\Public\\TestFolder\\TestFile3.txt", "C:\\Users\\Public\\TestFolder\\TestFile.txt", "C:\\Users\\Public\\TestFolder\\TestFile4.txt");

            // Delete a file
            File.Delete("C:\\Users\\Public\\TestFolder\\TestFile3.txt");

            // Delete a directory
            Directory.Delete("C:\\Users\\Public\\TestFolder");

            if (Directory.Exists("C:\\Users\\Public\\TestFolder"))
            {
                Console.WriteLine("The directory still exists.");
                IEnumerable<string> files2 = Directory.EnumerateFiles("C:\\Users\\Public\\TestFolder", "*.txt", SearchOption.AllDirectories);
                foreach (string file in files2)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("The directory was successfully deleted.");
            }

            // Path.Combine: combines two or more strings into a path
            Path.Combine("C:\\Users\\Public", "TestFolder", "TestFile.txt");

            Path.GetFullPath("C:\\Users\\Public");
            Path.GetPathRoot("C:\\Users\\Public");
            Path.GetFileName("C:\\Users\\Public\\TestFolder\\TestFile.txt");
            Path.GetFileNameWithoutExtension("C:\\Users\\Public\\TestFolder\\TestFile.txt");
            Path.GetExtension("C:\\Users\\Public\\TestFolder\\TestFile.txt");
            Path.GetDirectoryName("C:\\Users\\Public\\TestFolder\\TestFile.txt");
            Path.GetTempPath(); // returns the path to the temporary folder
            Path.GetTempFileName(); // returns the path to a temporary file

        }
    }
}
