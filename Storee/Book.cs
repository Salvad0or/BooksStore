using System.Text.RegularExpressions;

namespace Storee
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }

        public string Isbn { get; }

        public string Author { get; }

        public Book(int id, string title)
        {
            Title = title;
            Id = id;

        }

        public Book(int id, string title, string isbn, string author)
        {
            Title = title;
            Id = id;
            Isbn = isbn;
            Author = author;

        }

        internal static bool IsIsbn(string s)
        {
            if (s is null)
            {
                return false;
            }

            s = s.Replace("-", "")
                 .Replace(" ", "")
                 .ToUpper();

            return Regex.IsMatch(s, "^ISBN\\d{10}(\\d{3})?$");
        }

    }
}
