using System;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int PageNumber { get; set; }

        public string ISBN13 { get; init; }

        public Book()
        {
        }

        public string toString()
        {
            return $"Id: {ISBN13}, Title: {Title}, Author: {Author}, PageNumber: {PageNumber}";
        }
    }
}
