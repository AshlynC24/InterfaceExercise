using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        private static object vehicle;

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car();
            car.NumberOfDoors = 2;
            car.HasAnEngine = true;
            car.Make = "Honda";
            car.Model = "Civic";
            car.CompanyName = "Greggs Gas and Cars";
            car.Slogan = " Gas em and sell em";
            car.HasChangedGears = false;
            car.NumberOfSeats = 4;
            car.IsSafe = false;

            var truck = new Truck();
            truck.NumberOfDoors = 4;
            truck.HasAnEngine = true;
            truck.Make = "Ford";
            truck.Model = "F-150";
            truck.CompanyName = "Automotive Aves";
            truck.Slogan = " Built Tough ";
            truck.HasChangedGears = true;
            truck.HasFourWheelDrive = true;
            truck.CylinderNumber = 6;

            var suv = new SUV();
            suv.NumberOfDoors = 4;
            suv.HasAnEngine = true;
            suv.Make = "Chevy";
            suv.Model = "trailblazer";
            suv.CompanyName = "Mount Auto";
            suv.Slogan = " American Made ";
            suv.HasChangedGears = true;
            suv.HasHatchBack = true;
            suv.Color= "Blue";

            var vehicles = new List<IVehicle>() { car, truck, suv};//object inializer sytax

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine("==============================");
                Console.WriteLine($"Vehicle Make: {vehicle.Make}");
                Console.WriteLine($"Vehicle Model:{vehicle.Model}");
                Console.WriteLine($"Vehicle gear: {vehicle.HasChangedGears}");

            }
     
        }
    }
}
