using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.Nedarvning
{
    public class Person
    {
        public string? Navn { get; set; }

        public string? By { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {Navn}, By: {By}");
        }
    }

    public class DanskPerson : Person
    {
        public string? CPR { get; set; }
    }

    public class SpanskPerson : Person
    {
        public string? NIE { get; set; }
    }


}
