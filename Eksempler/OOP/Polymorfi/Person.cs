using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEksempler.OOP.Polymorfi
{
    public class Person
    {
        public string? Navn { get; set; }

        public string? By { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Navn: {Navn}, By: {By}");
        }

        override public string ToString()
        {
            return $"Navn: {Navn}, By: {By}";
        }
    }

    public class DanskPerson : Person
    {
        public string? CPR { get; set; }

        override public void PrintInfo()
        {
            Console.WriteLine($"Navn: {Navn}, By: {By}, CPR: {CPR}");
        }

        override public string ToString()
        {
            return $"Navn: {Navn}, By: {By}, CPR: {CPR}";
        }
    }

    public class SpanskPerson : Person
    {
        public string? NIE { get; set; }

        override public void PrintInfo()
        {
            Console.WriteLine($"Navn: {Navn}, By: {By}, NIE: {NIE}");
        }

        override public string ToString()
        {
            return $"Navn: {Navn}, By: {By}, NIE: {NIE}";
        }
    }

    public class Personer : List<Person>
    {
        public void PrintInfo()
        {
            foreach (var person in this)
            {
                person.PrintInfo();
            }
        }
    }
}
