using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace SoftUniExercises
{
    class Tire
    {
        public int Year { get; set; }
        public int Presure { get; set; }

    }
    class Engine
    {   public int horsePowery { get; set; }
        public double cubicCapacity { get; set; }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double	FuelQuantity{ get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }  
        public Tire[] Tire { get; set; }
        

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine, Tire[]tire)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }   

        public void Drive(double razstoqnie)
        {

            var cosumation = razstoqnie *(FuelConsumption / 100.0);
            if (cosumation<=FuelQuantity)
            {
                FuelQuantity -=cosumation;
                Console.WriteLine(FuelQuantity);
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!{razstoqnie}"); 
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make} Model: {this.Model} Year: {this.Year} Fuel: {this.FuelQuantity:F2}";
            



        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Engine engine = new Engine();
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumation = double.Parse(Console.ReadLine());
            var tire = new Tire[4];

            Car car = new Car(make,model,year,fuelQuantity,fuelConsumation,engine,tire);

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");


        }
    }

}