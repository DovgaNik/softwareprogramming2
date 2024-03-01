using ConsoleApp3;

List<Car> cars = new List<Car>();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Car {i + 1} name: ");
    var name = Console.ReadLine();
    Console.Write($"Car {i + 1} price: ");
    var price = int.Parse(Console.ReadLine());
    cars.Add(new Car(name, price));
}

foreach (var car in cars)
{
    car.ShowInfo();
}

int total = 0;

foreach (var car in cars)
{
    total += car.Price;
}