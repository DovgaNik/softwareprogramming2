 namespace ConsoleApp4
{
    public class Program
    {
        public static void Main()
        {
            CarsList cars = new CarsList()
            {
                new Car("1111", "Dacia", 10000),
                new Car("2222", "Scoda", 15000),
                new Car("3333", "Ford", 20000),
                new Car("4444", "Jaguar", 100000),
                new Car("5555", "Opel", 5000),
                new Car("6666", "Renault", 17000),
                new Car("7777", "Pegeaut", 25000),
                new ElectricCar("8888", "Tesla", 150000, 500),
            };
            cars.SaveToJson("cars.json");

            cars.Sort();
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine(cars.GetTotalValue());
        }
    }
}