using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_car_lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add cards to car lot
            Car.carList.Add(new Car("Ford", "Focus", 2013, 20000.00M));
            Car.carList.Add(new Car("Chevy", "Cruze", 2013, 20000.00M));
            Car.carList.Add(new Car("Dodge", "Charger", 2013, 20000.00M));
            Car.carList.Add(new UsedCar("Ford", "Focus", 2013, 20000.00M, 100000));
            Car.carList.Add(new UsedCar("Chevy", "Cruze", 2013, 20000.00M, 100000));
            Car.carList.Add(new UsedCar("Dodge", "Charger", 2013, 20000.00M, 100000));

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");

            // Listing all available cars
            Car.ListCars();

            // Asking user for car selection
            Console.Write("\nWhich car would you like?");
            if (int.TryParse(Console.ReadLine(), out int carSelection) && carSelection > 0 && carSelection <= Car.carList.Count)
            {
                // Displaying car details
                Console.WriteLine(Car.carList[carSelection - 1]);
                Console.WriteLine("Excellent choice, our finance dept will be in touch!");

                Car.RemoveCar(carSelection - 1);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }            // Asking user if they would like to remove the car

            // Listing cars after removal
            Console.WriteLine("\nUpdated Car List");
            Car.ListCars();


        }
    }
}
