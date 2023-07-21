using System;
using System.IO; // File, FileInfo, Directory, DirectoryInfo
using System.Text; // Encoding

namespace Files
{
    class FileDemo
    {
        static void Main(string[] args)
        {
            Stream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                string text = "Hello, World!" + Environment.NewLine + "This is a test file";
                byte[] strInBytes = Encoding.ASCII.GetBytes(text);

                // fs.CanWrite is used to check if the file is writable or not
                // if (fs.CanWrite)
                // {
                //     byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
                //     fs.Write(bytes, 0, bytes.Length);
                // }

                fs.Write(strInBytes, 0, strInBytes.Length); // Write() accepts byte[] and int, int 
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                fs.Close(); // or fs.Dispose(); but mainly fs.Close(); is used 
            }

            Console.WriteLine("File written successfully");

            Console.WriteLine("Reading file");

            // using is used to dispose the object automatically
            // When the using block is exited, the Dispose method is called on the object
            // We don't need to call fs.Close() or fs.Dispose() explicitly
            using (Stream readingStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[readingStream.Length];

                int numBytesToRead = (int)readingStream.Length; // number of bytes to read
                int bytesRead = 0; // number of bytes read so far
                ASCIIEncoding encoding = new ASCIIEncoding();

                while (numBytesToRead > 0)
                {
                    int n = readingStream.Read(bytes, bytesRead, numBytesToRead);
                    // If n is 0, then we have reached the end of the file
                    if (n == 0)
                        break;

                    bytesRead += n;
                    numBytesToRead -= n;
                }

                string str = encoding.GetString(bytes, 0, bytes.Length);
                Console.WriteLine(str);

            }

            Console.WriteLine("File read successfully");

            // above code is equivalent to the following code
            // Stream readingStream = null;
            // try
            // {
            //     readingStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            // }
            // finally
            // {
            //     if (readingStream != null)
            //     {
            //         readingStream.Dispose();
            //     }
            // }

            // readingStream.Dispose(); // Dispose() is used to free the resources
            // There is no catch block because we are not handling any exception here
            // If we want to handle the exception, we can use try-catch block 
            // and then call Dispose() in finally block
            
            IEnumerable<string> lines = File.ReadLines("test.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // File.ReadAllLines() is used to read all the lines from a file
            // File.ReadAllLines() returns an array of strings
            string[] lines2 = File.ReadAllLines("test.txt");
            foreach (string line in lines2)
            {
                Console.WriteLine(line);
            }

            // File.ReadAllText() is used to read all the text from a file
            // File.ReadAllText() returns a string
            string text2 = File.ReadAllText("test.txt");
            Console.WriteLine(text2);

            // File.WriteAllLines() is used to write all the lines to a file
            // File.WriteAllLines() accepts an array of strings and a string
            string[] lines3 = { "Hello", "World", "This", "is", "a", "test" };
            File.WriteAllLines("test.txt", lines3);

            // File.WriteAllText() is used to write all the text to a file
            // File.WriteAllText() accepts a string and a string
            string text3 = "Hello, World!" + Environment.NewLine + "This is a test file";
            File.WriteAllText("test.txt", text3);

            // File.AppendAllLines() is used to append all the lines to a file
            // File.AppendAllLines() accepts an array of strings and a string
            string[] lines4 = { "Hello", "World", "This", "is", "a", "test" };
            File.AppendAllLines("test.txt", lines4);

            // File.AppendAllText() is used to append all the text to a file
            // File.AppendAllText() accepts a string and a string
            string text4 = "Hello, World!" + Environment.NewLine + "This is a test file";
            File.AppendAllText("test.txt", text4);

            // File.WriteAllBytes() is used to write all the bytes to a file
            // File.WriteAllBytes() accepts a string and a byte[]
            byte[] bytes2 = { 72, 101, 108, 108, 111, 44, 32, 87, 111, 114, 108, 100, 33, 13, 10, 84, 104, 105, 115, 32, 105, 115, 32, 97, 32, 116, 101, 115, 116, 32, 102, 105, 108, 101 };
            File.WriteAllBytes("test.txt", bytes2);

            // File.ReadAllBytes() is used to read all the bytes from a file
            // File.ReadAllBytes() returns a byte[]
            byte[] bytes3 = File.ReadAllBytes("test.txt");
            Console.WriteLine(Encoding.UTF8.GetString(bytes3));
            // or using loop
            // foreach (byte b in bytes3)
            // {
            //     Console.Write(b + " ");
            // }

            // File.Copy() is used to copy a file
            // File.Copy() accepts two strings
            File.Copy("test.txt", "test2.txt"); // copies test.txt to test2.txt

            // File.Move() is used to move a file   
            // File.Move() accepts two strings
            File.Move("test.txt", "test2.txt"); // moves test.txt to test2.txt

            // File.Delete() is used to delete a file
            // File.Delete() accepts a string
            File.Delete("test2.txt"); // deletes test2.txt

            // File.Exists() is used to check if a file exists or not
            // File.Exists() accepts a string
            bool exists = File.Exists("test2.txt"); // checks if test2.txt exists or not
            Console.WriteLine(exists);

            // File.Open() is used to open a file
            // File.Open() accepts two FileMode and FileAccess
            Stream fs2 = File.Open("test2.txt", FileMode.Open, FileAccess.ReadWrite);

            // File.OpenRead() is used to open a file for reading
            // File.OpenRead() accepts a string
            Stream fs3 = File.OpenRead("test2.txt");

            // File.OpenWrite() is used to open a file for writing
            // File.OpenWrite() accepts a string
            Stream fs4 = File.OpenWrite("test2.txt");

            // File.OpenText() is used to open a file for reading
            // File.OpenText() accepts a string
            StreamReader sr = File.OpenText("test2.txt");

            // File.Create() is used to create a file
            // File.Create() accepts a string
            Stream fs5 = File.Create("test2.txt");

            // File.CreateText() is used to create a file for writing
            // File.CreateText() accepts a string
            StreamWriter sw = File.CreateText("test2.txt");

            // File.GetAttributes() is used to get the attributes of a file
            // File.GetAttributes() accepts a string
            FileAttributes attributes = File.GetAttributes("test2.txt");
            Console.WriteLine(attributes);




        }
    }
}