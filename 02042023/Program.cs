using System;

namespace _02042023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstuction
            //Dog dog = new Dog();
            //dog.Name = "Artur";
            //dog.Age = 20;
            //Console.WriteLine(dog.GetInfo()); 
            //dog.MakeSound();

            //Console.WriteLine("===================");
            //Cat cat = new Cat();
            //cat.Name = "Mestan";
            //cat.Age = 2;
            //Console.WriteLine(cat.GetInfo()) ;  

            //cat.MakeSound();

            //Console.WriteLine("=========");

            //PetDog petDog = new PetDog();
            //petDog.MakeSound();

            #endregion

            Book book1 = new Book
            {
                Name = "Mathamatics",
                Author = "Jhon Kenedy",
                PageCount = 140
            };
            Book book2 = new Book
            {
                Name = "English",
                Author = "Edward Uwil",
                PageCount = 140
            };

            Console.WriteLine("Library creating...");
            Console.WriteLine("Enter Library's name :");
            string name = Console.ReadLine();

            Library library = new Library
            {
                Name = name,
            };

            library.AddBook(book1);
            library.AddBook(book2);

            //Console.WriteLine(library.GetInfo());

            bool con = true;

            do
            {
                Console.WriteLine("\n------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. About info Library");
                Console.WriteLine("2. About info books of library");
                Console.WriteLine("3. Add new a book to library");
                Console.WriteLine("4. Exit");
                Console.WriteLine("------------------------\n");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine(library.GetInfo());
                        break;
                    case 2:
                        foreach (var item in library.GetAllBooks())
                        {
                            Console.WriteLine(item.GetInfo());
                        };
                        break;
                    case 3:
                        Console.WriteLine("New a book creating...");
                        Console.WriteLine("Enter name of new book :");
                        string bookName = Console.ReadLine();

                        Console.WriteLine("Enter author of new book :");
                        string bookAthor = Console.ReadLine();

                        Console.WriteLine("Enter page count of new book :");
                        int pageCount = int.Parse(Console.ReadLine());

                        Book newBook = new Book
                        {
                            Name = bookName,
                            Author = bookAthor,
                            PageCount = pageCount
                        };

                        library.AddBook(newBook);
                        break;
                    case 4:
                        con=false;
                        break;
                    default:
                        break;
                }
            } while (con);

            


        }
    }
}
