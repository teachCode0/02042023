using System;
using System.Collections.Generic;
using System.Text;

namespace _02042023
{
    internal class Library
    {
        private int _bookCount;
        public string Name { get; set; }
        public int BookCount { 
            get=>this._bookCount;
            private set
            {
                this._bookCount = books.Length;
            }
        }

        private Book[] books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1]= book;
            this._bookCount++;
        }

        public string GetInfo()
        {
            return $"Name : {Name} - Book Count : {BookCount}";
        }
        public Book[] GetAllBooks()
        {
            return books;
        }
    }
}
