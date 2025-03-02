using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.IMutableObjekter
{
    // Måske bare bruge en record i stedet for en klasse?

    public class Person
    {
        private string? _navn;
        private string? _by;

        public string? Navn
        {
            get => _navn;
            init => _navn = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string? By
        {
            get => _by;
            init => _by = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Person(string navn, string by)
        {
            Navn = navn;
            By = by;
        }

        public Person()
        {
            Navn = string.Empty;
            By = string.Empty;
        }
    }
}
