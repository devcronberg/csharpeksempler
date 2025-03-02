using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.Faktory
{


    public class CsvReader : IDataReader
    {
        public List<Person> ReadData(string filePath)
        {
            var people = new List<Person>();
            var lines = File.ReadAllLines(filePath).Skip(1); // Skip header

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                people.Add(new Person { Name = parts[0], Age = int.Parse(parts[1]), City = parts[2] });
            }

            return people;
        }
    }

}
