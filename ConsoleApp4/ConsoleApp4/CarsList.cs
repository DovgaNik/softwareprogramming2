using Newtonsoft.Json;

namespace ConsoleApp4
{
    internal class CarsList : List<Car>
    {
        public override string ToString()
        {
            string text = "";
            foreach (Car car in this)
                text += car + Environment.NewLine;
            return text;
        }

        public void ReadFromJson (string filename)
        {
            string content = File.ReadAllText(filename);
            AddRange(JsonConvert.DeserializeObject<CarsList>(content));
        }

        public void SaveToJson (string filename)
        {
            string output = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filename, output);
        }

        public uint GetTotalValue()
        {
            uint total = 0;
            foreach (Car car in this)
                total += car.Price;
            return total;
        }

    }
}
