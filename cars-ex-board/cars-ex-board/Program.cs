﻿namespace cars_ex_board
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            car.Make = "VM";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}