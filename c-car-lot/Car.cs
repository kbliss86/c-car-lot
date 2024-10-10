using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace c_car_lot
{
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; } = 0.0M;

        // Public static list to hold cars
        public static List<Car> carList = new List<Car>();

        //constructor setting defualt values
        //A no-arguments constructor that sets data members to default values (blanks or your choice)
        public Car()
        {
            make = "Ford";
            model = "Focus";
            year = 2013;
            price = 20000.00M;
        }
        //constructor with four arguments matching the order above
        public Car(string make, string model, int year, decimal price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        //To string method
        public override string ToString()
        {
            return $"Make: {make} Model: {model} Year: {year} Price: {price}";
        }
        //static method to list all cars
        public static void ListCars()
        {
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {carList[i]}");
            }
        }
        //static method to remove a car by index
        public static void RemoveCar(int index)
        {
            if (index > 0 && index <= carList.Count)
            {
                carList.RemoveAt(index - 1);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

}
