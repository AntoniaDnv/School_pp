﻿namespace symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lenght = text.Length;

            for(int i = 0; i<lenght; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}