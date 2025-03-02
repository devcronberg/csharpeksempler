
using System.Text.Json;

namespace CSharpEksempler.OOP.Faktory
{
    public class JsonReader : IDataReader
    {
        public List<Person> ReadData(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Person>>(jsonContent);
        }
    }

}
