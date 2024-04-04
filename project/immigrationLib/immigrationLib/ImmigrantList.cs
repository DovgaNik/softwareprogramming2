using System.Text.Json;

namespace immigrationLib
{
    public class ImmigrantList : List<Immigrant>
    {
        string filepath;
        public ImmigrantList(string filename)
        {
            filepath = filename;
            if (File.Exists(filename))
                Load();
        }

        private void SaveToJson()
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void Load()
        {
            try
            {
                string json = File.ReadAllText(filepath);
                List<Immigrant> immigrantList = JsonSerializer.Deserialize<List<Immigrant>>(json);
                foreach (Immigrant immigrant in immigrantList)
                {
                    this.Add(immigrant);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }

        }

        public void Add(Immigrant immigrant)
        {
            base.Add(immigrant);
            SaveToJson();
        }

        public void RemoveAt (int index)
        {
            base.RemoveAt(index);
            SaveToJson();
        }
    }
}
