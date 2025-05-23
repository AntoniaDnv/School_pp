﻿namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            LibraryClass library = new LibraryClass(bookOne, bookTwo, bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
