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

        public Book(string isbn, string title, string author, int pages)
        {
            ISBN13 = isbn;
            Author = author;
            Title = title;
            PageNumber = pages;
        }

        public string toString()
        {
            return $"Id: {ISBN13}, Title: {Title}, Author: {Author}, PageNumber: {PageNumber}";
        }
    }
}
