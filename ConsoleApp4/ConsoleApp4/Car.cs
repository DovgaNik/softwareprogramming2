using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car : IComparable<Car>
    {

        public string VIN { get; set; }
        public string Brand { get; set; }
        public uint Price { get; set; }

        public Car(string VIN, string Brand, uint Price)
        {
            this.VIN = VIN;
            this.Brand = Brand;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"{VIN, 10} {Brand,10} {Price,10}";
        }

        public int CompareTo(Car? other)
        {
            return Price.CompareTo(other.Price);
        }
    }
}
