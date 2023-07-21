public class XMLWrite
{

    static void Main(string[] args)
    {
        WriteXML();
    }

    public class Book
    {
        public String? title;
        public String? author;
        public String? genre;
        public String? price;
        public String? publish_date;
        public String? description;

    }

    public static void WriteXML()
    {
        Book overview = new Book();
        overview.title = "Serialization Overview";
        overview.author = "Microsoft";
        overview.genre = "Computer";
        overview.price = "9.99";
        overview.publish_date = "2000-10-01";
        overview.description = "An overview of .NET serialization.";

        // creating XML writer
        System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Book));
        
        
        // printing XML to console
        writer.Serialize(Console.Out, overview);

        // creating file
        string path = System.IO.Directory.GetCurrentDirectory() + "//SerializationOverview.xml";
        System.IO.FileStream file = System.IO.File.Create(path);

        // writing XML to file
        writer.Serialize(file, overview);
        // closing file
        file.Close();
    }
}