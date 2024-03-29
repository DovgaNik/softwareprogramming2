namespace ConsoleApp4
{
    internal class ElectricCar : Car
    {
        public uint BatteryCapacity { get; set; }
        public ElectricCar( string VIN, string Brand, uint Price, uint BatteryCapacity) : base(VIN, Brand, Price)
        {
            this.BatteryCapacity = BatteryCapacity;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {BatteryCapacity, 10}";
        }

    }
}
