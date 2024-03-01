using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car
    {
        private string model;
        private int price;

        public Car(string model, int price)
        {
            this.model = model;
            this.price = price;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{model} costs {price}");
        }


    }
}
