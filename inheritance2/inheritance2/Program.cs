using inheritance2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    public class Vehicle//Class Created 
    {//non-static instances of the object
        public string brand = "";
        public string model = "";
        public int horsePower = 0;
        public int price = 0;
        public bool crashed = false;
        //static field==================================
        public static int VehiclesForRace = 0;

        public int driver;
        //the AddDetailsOfCar method has been changed to a constructor by
        //1. giving it the same name as the class
        //2. removing the return type
        //===============================================
        public Vehicle(string brand, string model, int horsePower, int price)
        {
            this.brand = brand;
            this.model = model;
            this.horsePower = horsePower;
            this.price = price;
            this.crashed = false;
            //driver = 1;

            VehiclesForRace++;

        }
        public void VehicleCrashed()//FOR THE VEHICLES CRASHED
        {
            this.crashed = true;
            // this.price = price;

            VehiclesForRace--;

            Console.WriteLine("The vehicle crashed is {0} !!!", this.brand);
            Console.WriteLine();
        }
        public static void DisplayAllVehicles(List<Vehicle> vehiclelist)
        {
            int totalValueCarsSmashed = 0;
            int totalValuevehicleRace = 0;

            Console.WriteLine("\nTHE DETAILS OF THE VEHICLES IN THE RACE: \n");
            Console.WriteLine();
            //go through the houses list, displaying details and calculating totals
            foreach (Vehicle item in vehiclelist)
            {

                Console.WriteLine("Brand: {0} \n Model: {1}\n Price: £{2:N0}.", item.brand, item.model, item.price);  //:N0 formats the number
                if (item.crashed)
                {
                    Console.WriteLine("This Vehicle has been smashed agains the wall.");
                    totalValueCarsSmashed += item.price;
                }
                else
                {
                    Console.WriteLine("This Vehicle is still in the race.");
                    totalValuevehicleRace += item.price;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //display summary data
            Console.WriteLine("The total number of Vehicles in the race are: " + Vehicle.VehiclesForRace);
            Console.WriteLine();
            Console.WriteLine("The total value of Vehicles crasehd is: £{0:N0}.", totalValueCarsSmashed);
            Console.WriteLine("The total value of Vehicles still in the race is: £{0:N0}.", totalValuevehicleRace);
            Console.WriteLine();

        }//PUBLIC STATIC VOID

    }//MAIN CLASS

    public class Car : Vehicle//INHERITATING FROM MAIN CLASS
    {
        public Car(string brand, string model, int horsePower, int price) : base(brand, model, horsePower, price)
        {

        }

    }
    
    class Motorcycle : Vehicle//INHERITATING FROM MAIN CLASS
    {
        public string Wheeling;

        public Motorcycle(string brand, string model, int horsePower, int price, string Wheeling) : base(brand, model, horsePower, price)
        {
            this.Wheeling = "wheeling";

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //initialise the static variable
            Vehicle.VehiclesForRace = 0;
            List<Vehicle> vehicleList = new List<Vehicle>();

            //INICIALIZE objects and give values to their fields using add method

            Car car1 = new Car("Audi", "R8", 680, 64000);
            vehicleList.Add(car1);

            Car car2 = new Car("Mercedes", "CLR", 620, 80000);
            vehicleList.Add(car2);

            Car car3 = new Car("Nissan", "GTR", 710, 54000);
            vehicleList.Add(car3);

            Car car4 = new Car("Porsche", "carreraGT", 650, 86000);
            vehicleList.Add(car4);

            //=======================MOTORBIKES========================================================

            Motorcycle bike1 = new Motorcycle("Honda", "CBR", 250, 24000, "wheelie");
            vehicleList.Add(bike1);

            Motorcycle bike2 = new Motorcycle("Yamaha", "R6", 220, 26000, "Didn't wheelie");
            vehicleList.Add(bike2);

            Motorcycle bike3 = new Motorcycle("Ducatti", "GTR", 210, 28000, "wheelie");
            vehicleList.Add(bike3);

            Motorcycle bike4 = new Motorcycle("Suzuki", "GSR", 240, 22000, "wheelie");
            vehicleList.Add(bike4);
            //display the total number in the race
            Vehicle.DisplayAllVehicles(vehicleList);//THIS IS GONNA DISPLAY THE VEHICLES FIRST WITHOUT THE VEHICLES SMASHED 

            car2.VehicleCrashed();//THIS IS THE CAR SMASHED AGAINS THE WALL
            bike4.VehicleCrashed();
            bike2.VehicleCrashed();//THIS IS THE BIKE SMASHED AGAINS THE WALL
            Console.WriteLine("\n THIS IS THE RESULT OF THE RACE, CONSIDERING THE CRASHES AND THE COST OF ALL THE VEHICLES\n");
            Vehicle.DisplayAllVehicles(vehicleList);//THIS IS GONNA DISPLAY THE VEHICLES AFTER THE ACCIDENTS

        }
    }
}

