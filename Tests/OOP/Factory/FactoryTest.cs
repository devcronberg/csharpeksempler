using CSharpEksempler.OOP.Faktory;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.Tests.OOP.Factory
{
    public class FactoryTest
    {
        [Fact]
        public void TestCsvReader()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "test_people.csv");
            File.WriteAllText(tempPath, "Name,Age,City\nJens,30,Copenhagen\nMette,25,Aarhus\nLars,40,Odense");

            IDataReader reader = DataReaderFactory.GetReader(tempPath);
            List<Person> people = reader.ReadData(tempPath);

            Assert.Equal(3, people.Count);
            Assert.Equal("Jens", people[0].Name);
            Assert.Equal(30, people[0].Age);
            Assert.Equal("Copenhagen", people[0].City);
        }

        [Fact]
        public void TestJsonReader()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "test_people.json");
            string jsonData = "[ { \"Name\": \"Jens\", \"Age\": 30, \"City\": \"Copenhagen\" }, { \"Name\": \"Mette\", \"Age\": 25, \"City\": \"Aarhus\" }, { \"Name\": \"Lars\", \"Age\": 40, \"City\": \"Odense\" } ]";
            File.WriteAllText(tempPath, jsonData);

            IDataReader reader = DataReaderFactory.GetReader(tempPath);
            List<Person> people = reader.ReadData(tempPath);

            Assert.Equal(3, people.Count);
            Assert.Equal("Jens", people[0].Name);
            Assert.Equal(30, people[0].Age);
            Assert.Equal("Copenhagen", people[0].City);
        }
    }
}
