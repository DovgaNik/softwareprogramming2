using System.Text.Json;

namespace immigrationLib
{
    public class DocumentList : List <GenericDocument>
    {
        string filepath;
        public DocumentList(string filename)
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
                List<GenericDocument> documentList = JsonSerializer.Deserialize<List<GenericDocument>>(json);
                foreach (GenericDocument document in documentList)
                {
                    this.Add(document);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }

        }

        public new void Add(GenericDocument document)
        {
            base.Add(document);
            SaveToJson();
        }

        public new void RemoveAt (int index)
        {
            base.RemoveAt(index);
            SaveToJson();
        }
    }
}
