using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_car_lot
{
    public class UsedCar : Car
    {
        public double mileage { get; set; } = 0.0;
        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            this.mileage = mileage;
        }
        public override string ToString()
        {
            return $"Make: {make} Model: {model} Year: {year} Price: {price} Mileage: {mileage}";
        }

    }
}
