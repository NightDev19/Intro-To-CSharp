using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_To_CSharp.Basics.OOP
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }
    internal class Structures
    {
        

        public static void Demonstrate()
        {
            Books Book1, Book2;
            // book 1 specification

            Book1.title = "C# Programming";
            Book1.author = "Tan Ah Teck";
            Book1.subject = "C# Programming Tutorial";
            Book1.book_id = 6495407;
            // book 2 specification
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;
            // print Book1 info
            Console.WriteLine("Book 1 title : " +  Book1.title);
            Console.WriteLine("Book 1 author : " +  Book1.author);
            Console.WriteLine("Book 1 subject : " +  Book1.subject);
            Console.WriteLine("Book 1 book_id : " +  Book1.book_id);
            // print Book2 info
            Console.WriteLine("Book 2 title : " +  Book2.title);
            Console.WriteLine("Book 2 author : " +  Book2.author);
            Console.WriteLine("Book 2 subject : " +  Book2.subject);
            Console.WriteLine("Book 2 book_id : " +  Book2.book_id);
        }
    }
}
