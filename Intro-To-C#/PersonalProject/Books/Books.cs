using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_To_CSharp.PersonalProject.Books
{
    struct Book
    {
        public string BookName { get; set; }
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Book(string bookName, int bookID, string title, string description, string author)
        {
            BookName = bookName;
            BookID = bookID;
            Title = title;
            Description = description;
            Author = author;
        }
    }

    internal class Books
    {
        
        public static Dictionary<int, Book> books = new Dictionary<int, Book>
        {
            {
                1001,
                new Book(
                    bookName: "C# Programming",
                    bookID: 1001,
                    title: "Learn C#",
                    description: "A comprehensive guide to C# programming.",
                    author: "Sherwin The Greater")
            },
            {
                1002,
                new Book(
                    bookName: "Introduction to Algorithms",
                    bookID: 1002,
                    title: "Algorithms Unlocked",
                    description: "An introduction to algorithms and data structures.",
                    author: "Sherwin The Greater")
            }
        };

        public static void ListOfBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(
                    $"Book ID : {book.Value.BookID}\n" +
                    $"Book Name : {book.Value.BookName}\n" +
                    $"Book Title : {book.Value.Title}\n" +
                    $"Book Description : {book.Value.Description}\n" +
                    $"Book Author : {book.Value.Author}\n"
                );
            }
        }

        public static void AddBook(Book book)
        {
            
            if (!books.ContainsKey(book.BookID))
            {
                books.Add(book.BookID, book);
            }
        }
    }
}
