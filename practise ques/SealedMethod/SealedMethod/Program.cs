using SealedMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Vehicle
    {
        public virtual void Start()
        {
            base.Start();
            Console.WriteLine("vehicle : run for pre-run checks");

        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("car: start with key");
        }
    }
    public class ElectricCar : Car
    {
        
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("electricCar: start with button");
        }
    }

    public class HybridCar : ElectricCar
    {
        {
        base.Start();
        Console.WriteLine("HybridCar : start with hybrid system");
}
    }
    
internal class program
{
    static void Main(string[] args)
    {
        ElectricCar myElectricCar = new ElectricCar();
        myElectricCar.Start();
        Console.ReadLine();
    }
}
      

    
   