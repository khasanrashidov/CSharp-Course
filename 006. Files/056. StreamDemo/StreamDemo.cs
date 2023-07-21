using System;
using System.IO;
using System.Text;

namespace Files
{
    class StreamDemo
    {
        static void Main(string[] args)
        {
            // Writing to a file
            Stream stream = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string text = "Hello World! Some text to write to the file.";
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();

            // Reading from a file
            stream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            byte[] readBytes = new byte[stream.Length];
            stream.Read(readBytes, 0, readBytes.Length);
            string readText = Encoding.UTF8.GetString(readBytes);
            Console.WriteLine(readText);
            stream.Close();

            //////////////////////////////////////////////

            // try-catch-finally block
            try
            {
                // Reading from a file
                stream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                byte[] readBytes2 = new byte[stream.Length];
                stream.Read(readBytes2, 0, readBytes2.Length);
                string readText2 = Encoding.UTF8.GetString(readBytes2);
                Console.WriteLine(readText2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

            // Reading from a file
            using (stream = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] readBytes3 = new byte[stream.Length];
                stream.Read(readBytes3, 0, readBytes3.Length);
                string readText3 = Encoding.UTF8.GetString(readBytes3);
                Console.WriteLine(readText3);
            }

            //////////////////////////////////////////////

            // Writing to a file
            using (stream = new FileStream("test2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                string text2 = "Hello World! Some text to write to the file. This text is written to the file using using";
                byte[] bytes2 = Encoding.UTF8.GetBytes(text2);
                stream.Write(bytes2, 0, bytes2.Length);
            }

            // Reading from a file
            using (stream = new FileStream("test2.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] readBytes4 = new byte[stream.Length];
                stream.Read(readBytes4, 0, readBytes4.Length);
                string readText4 = Encoding.UTF8.GetString(readBytes4);
                Console.WriteLine(readText4);
            }

            //////////////////////////////////////////////

            // Writing to a file
            string text3 = "Hello World! Some text to write to the file." + Environment.NewLine + "Some more text to write to the file.";
            File.WriteAllText("test3.txt", text3);

            // Reading from a file
            string readText5 = File.ReadAllText("test3.txt");
            Console.WriteLine(readText5);

            //////////////////////////////////////////////

        }
    }
}