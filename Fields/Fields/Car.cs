using CarManifacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
   public class Car
    {
        private string? make;
        private string? model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string? Make
        {
            get { return make; }
            set { make = value; }
        }

        public string? Model
        { 
            get { return model; } 
            set { model = value;  } 
        }

        public int Yea
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public Engine Engine
        {
            get {return engine;}
            set { engine = value; }
        }
        public Tire[] Tire
        {
            get { return tires; }
            set {  tires = value; }
        }


        public void Drive(double distance)
        {
            double consumptionTotal = (fuelQuantity - distance) * fuelConsumption;

            if (consumptionTotal < 0)
            {
                Console.WriteLine($"Not empugh fuel to preform this trip!");
            }
            else
            {
                fuelQuantity = distance * fuelConsumption;
            }
        }
       public string WhoAmI()
       {
          return  $"Make: {this.Make}\nModel: {this.Model}\nYea: {this.Yea}\nFuel:  {this.FuelQuantity:F2}L";


       }

        public Car()
        {
            this.Make = "VM";
            this.Model = "MK5";
            this.Yea = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 200;
    }
        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Yea = year;
        }
        public Car(string make, string model, int year, 
            double fuelQuantity, double fuelConsumption)
          : this(make, model, year)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;

        }

        public Car(string make, string model, int year, 
            double fuelQuantity, double fuelConsumption, 
           Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
           this.Engine = engine;
            this.Tire = tires;
        }
    }
}
