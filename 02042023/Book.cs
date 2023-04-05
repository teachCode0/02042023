using System;
using System.Collections.Generic;
using System.Text;

namespace _02042023
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get;set; }
        public int PageCount { get;set; }   

        public string GetInfo()
        {
            return $"Name : {Name} - Author : {Author} - Page Count : {PageCount}";
        }
    }
}
