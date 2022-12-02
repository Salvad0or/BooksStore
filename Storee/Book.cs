using System;

namespace Storee
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }

        public Book(string title, int id)
        {
            Title = title;
            Id = id;
        }

    }
}
