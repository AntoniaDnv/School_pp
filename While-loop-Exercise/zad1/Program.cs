using System;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();           
            int counter = 0;
            while( true )
            {
                string book = Console.ReadLine();

                if (favBook == book ) 
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
               
               
                if ( book == "No More Books")
                {
                 Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
            }
        }
    }
}