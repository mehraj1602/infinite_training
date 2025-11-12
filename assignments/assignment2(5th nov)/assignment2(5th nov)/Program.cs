using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_5th_nov_
{
    class Vehicle
    {
        private string registrationNumber;
        private string ownerName;

        protected int serviceCount;

        public Vehicle(string regNo, string owner)
        {
            this.registrationNumber = regNo;
            this.ownerName = owner;
            this.serviceCount = 0;
            Console.WriteLine("Base class (Vehicle) constructor called");
        }

        public void Registration()
        {
            Console.WriteLine("Vehicle Registration Completed");
            Console.WriteLine($"Owner: {ownerName}, Reg No: {registrationNumber}");
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine("--------Vehicle Basic Info-----------");
            Console.WriteLine($"Registration Number: {registrationNumber}");
            Console.WriteLine($"Owner Name: {ownerName}");
        }

        protected void UpdateServiceCount()
        {
            serviceCount++;
            Console.WriteLine($"Service count updated to: {serviceCount}");
        }

        private void CheckEngine()
        {
            Console.WriteLine("Engine check complete");
        }

        public void PerformInspection()
        {
            Console.WriteLine("Performing Vehicle Inspection");
            CheckEngine();
        }
    }

    class Car : Vehicle
    {
        private string carModel;
        private string fuelType;

        public Car(string regNo, string owner, string model, string fuel) : base(regNo, owner)
        {
            this.carModel = model;
            this.fuelType = fuel;
            Console.WriteLine("Derived class (Car) constructor called");
        }

        public void DisplayVehicleInfo()
        {
            Console.WriteLine("----------Car Details-----------");
            DisplayBasicInfo();
            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Fuel Type: {fuelType}");
        }

        public void PerformMaintenance()
        {
            Console.WriteLine("Performing Maintenance for Car");
            UpdateServiceCount();
            Console.WriteLine("Maintenance completed successfully!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("MH12AB1234", "Humera", "Hyundai", "Diesel");
            Console.WriteLine("\n----------Vehicle Service------------\n");

            car.Registration();
            car.DisplayVehicleInfo();
            car.PerformInspection();
            car.PerformMaintenance();

            Console.ReadLine();
        }
    }
}
