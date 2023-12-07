using Newtonsoft.Json;

namespace Common
{
    public class FileProvider
    {
        private string filepath;

        public FileProvider() { }

        public FileProvider(string filename)
        {
            filepath = filename;
        }

        public void Append<T>(T data)
        {
            var allData = new List<T>();

            if (File.Exists(filepath))
            {
                var oldData = Read<T>();
                allData.AddRange(oldData);
            }

            allData.Add(data);

            Add(allData);
        }

        public void Add<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(filepath, json);
        }

        public List<T> Read<T>()
        {
            if (File.Exists(filepath))
            {
                var json = File.ReadAllText(filepath);

                return JsonConvert.DeserializeObject<List<T>>(json);
            }

            return new List<T>();
        }

        public bool Exists()
        {
            return File.Exists(filepath);
        }
    }
}
