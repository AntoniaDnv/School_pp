using Fields;
using Microsoft.VisualBasic;
   using System;

namespace CarManifacturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car firstCar = new Car();


            Console.WriteLine($"{firstCar.Make } {firstCar.Model} {firstCar.Yea} {firstCar.FuelQuantity} {firstCar.FuelQuantity}");
            Car secondCar = new Car(make, model, year);
            Console.WriteLine($"{secondCar.Make} {secondCar.Model} {secondCar.Yea} {secondCar.FuelQuantity} {secondCar.FuelQuantity}");
            Car thirdCar = new Car(make, model,year, fuelQuantity, fuelConsumption);
            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Yea} {thirdCar.FuelQuantity} {thirdCar.FuelQuantity}");

            //car.Make = "VM";
            //car.Model = "MK3";
            //car.Yea = 1992;
            //car.FuelConsumption = 200;
            //car.FuelQuantity = 200;
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());


        }
    }
}