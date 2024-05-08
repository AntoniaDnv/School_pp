using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_etended_3
{
    internal class Cars
    {
    }
    public Car()
    {
        this.Make 
    }
    public Car(string make, string model, int year)
        : this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
      : this(make, model, year)
    {
        this.FuelConsumption = fuelConsumption;
        this.FuelQuantity = fuelQuantity;
     
    }

}
