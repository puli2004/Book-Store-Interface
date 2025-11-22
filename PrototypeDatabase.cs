using System.Collections.Generic;

namespace BookStoreApp
{
    public static class PrototypeDatabase
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book { Id = "12345", Title = "C# Basics", Author = "John Doe" },
            new Book { Id = "67890", Title = "Programming Logic", Author = "Jane Smith" }
        };
    }

    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
