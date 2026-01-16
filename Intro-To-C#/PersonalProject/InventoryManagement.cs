using System;
using System.Collections.Generic;
using System.Text;
using BookClass = Intro_To_CSharp.PersonalProject.Books;

namespace Intro_To_CSharp.PersonalProject
{
    internal class InventoryManagement
    {
        public static void Run()
        {
            BookClass.Books.ListOfBooks();
        }
    }
}
