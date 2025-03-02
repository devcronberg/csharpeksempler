using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.Faktory
{
    public interface IDataReader
    {
        List<Person> ReadData(string filePath);
    }
}
