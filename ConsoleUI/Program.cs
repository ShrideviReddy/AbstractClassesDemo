using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string name;
        public int price;
        public int model;
        public Vehicle(string vname, int vprice, int vmodel)
        {
            name = vname;
            price = vprice;
            model = vmodel;
        }
        public virtual void speed()
        {
            Console.WriteLine("120lmph");
        }
        public abstract void mileage();
    }

    public class Car : Vehicle
    {
        public int seating_capacity;
        // creating constructor and calling base class constructor as well
        public Car(string vname, int vprice, int vmodel, int capacity) : base(vname, vprice, vmodel)
        {
            seating_capacity = capacity;
        }
        public override void mileage()
        {
            Console.WriteLine("Zen mileage:1200cc");
        }
        public void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the car is:" + name);
            Console.WriteLine("The price of the car is:" + price);
            Console.WriteLine("The model of the car is:" + model);
            Console.WriteLine("The seating capacity of car is:" + seating_capacity);
        }
    }
    public class Motorcycle: Vehicle
    {
        //public int mileage;
        public int Motor_capacity;
        public Motorcycle(string vname, int vprice, int vmodel, int capacity) : base(vname, vprice, vmodel)
        {
            Motor_capacity = capacity;
        }
        public override void mileage()
        {
            Console.WriteLine("Zen mileage:1200cc");
        }
        public void Display()
        {
            Console.WriteLine("\nThe name of the car is:" + name);
            Console.WriteLine("The price of the car is:" + price);
            Console.WriteLine("The model of the car is:" + model);
            Console.WriteLine("The seating capacity of car is:" + Motor_capacity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */
            Car car = new Car("Toyota", 750000, 2010, 5);
            car.DisplayInfo();
            Motorcycle Motor = new Motorcycle("Toyota", 750000, 2010, 5);
            Motor.speed();
            Motor.mileage();
            Motor.Display();
            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
