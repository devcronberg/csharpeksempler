using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.Faktory
{
    public class DataReaderFactory
    {
        public static IDataReader GetReader(string filePath)
        {
            if (filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            {
                return new CsvReader();
            }
            else if (filePath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                return new JsonReader();
            }
            else
            {
                throw new NotSupportedException("Filtypen understøttes ikke.");
            }
        }
    }
}
